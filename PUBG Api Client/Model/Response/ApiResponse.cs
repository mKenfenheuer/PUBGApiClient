using Newtonsoft.Json;
using PUBG.ApiClient.Model.Entity;
using System.Linq;

namespace PUBG.ApiClient.Model.Response
{
    public class ApiResponse<T>
    {
        public T Data { get; private set; }
        public ApiError[] Errors { get; private set; }
        public ApiLink Links { get; private set; }

        [JsonConstructor]
        private ApiResponse(ApiError[] errors, ApiLink links, T data, dynamic[] included)
        {
            Data = data;
            Links = links;
            Errors = errors;

            if(typeof(T) == typeof(Match))
            {
                Match match = (Match)(object)data;

                for(int i = 0; i < match.Relationships.Rosters.Length; i++)
                {
                    Roster orig = match.Relationships.Rosters[i];
                    dynamic incl = included.Where(d => d.type == orig.Type && d.id == orig.Id).FirstOrDefault();
                    if(incl != null)
                    {
                        string inclRosterJson = JsonConvert.SerializeObject(incl);
                        Roster inclRoster = JsonConvert.DeserializeObject<Roster>(inclRosterJson);

                        for (int i2 = 0; i2 < inclRoster.Relationships.Participants.Length; i2++)
                        {
                            Participant origParticipant = inclRoster.Relationships.Participants[i2];
                            dynamic inclParticipant = included.Where(d => d.type == origParticipant.Type && d.id == origParticipant.Id).FirstOrDefault();
                            if (incl != null)
                            {
                                string inclParticipantJson = JsonConvert.SerializeObject(inclParticipant);
                                Participant inclParticipantObj = JsonConvert.DeserializeObject<Participant>(inclParticipantJson);
                                inclRoster.Relationships.Participants[i2] = inclParticipantObj;
                            }
                        }

                        match.Relationships.Rosters[i] = inclRoster;
                    }
                }                
            }
        }
    }
}
