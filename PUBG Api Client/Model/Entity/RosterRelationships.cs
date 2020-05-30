using System;
using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class RosterRelationships
    {
        public Team Team { get; private set; }
        public Participant[] Participants { get; private set; }

        [JsonConstructor]
        private RosterRelationships(TeamData team, ParticipantsData participants)
        {
            Team = team.Data;
            Participants = participants.Data;
        }
    }
}
