using Newtonsoft.Json;

namespace PUBG.ApiClient.Model.Entity
{
    public class StatRelationships
    {
        public Player Player { get; private set; }
        public Season Season { get; private set; }
        public PlayerMatch[] MatchesSolo { get; private set; }
        public PlayerMatch[] MatchesSoloFPP { get; private set; }
        public PlayerMatch[] MatchesDuo { get; private set; }
        public PlayerMatch[] MatchesDuoFPP { get; private set; }
        public PlayerMatch[] MatchesSquad { get; private set; }
        public PlayerMatch[] MatchesSquadFPP { get; private set; }

        [JsonConstructor]
        public StatRelationships(PlayerData player, SeasonData season, PlayerMatches matchesSolo, PlayerMatches matchesSoloFPP, PlayerMatches matchesDuo, PlayerMatches matchesDuoFPP, PlayerMatches matchesSquad, PlayerMatches matchesSquadFPP)
        {
            Player = player.Data;
            Season = season.Data;
            if (matchesSolo != null)
                MatchesSolo = matchesSolo.Data;
            if (MatchesSoloFPP != null)
                MatchesSoloFPP = matchesSoloFPP.Data;
            if (MatchesDuo != null)
                MatchesDuo = matchesDuo.Data;
            if (MatchesDuoFPP != null)
                MatchesDuoFPP = matchesDuoFPP.Data;
            if (MatchesSquad != null)
                MatchesSquad = matchesSquad.Data;
            if (MatchesSquadFPP != null)
                MatchesSquadFPP = matchesSquadFPP.Data;
        }
    }
}