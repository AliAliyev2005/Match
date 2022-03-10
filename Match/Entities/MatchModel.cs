using System;

namespace Match.Entities
{    
    public class MatchModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public int FirstTeamId { get; set; }
        public Team FirstTeam { get; set; }
        public int SecondTeamId { get; set; }
        public Team SecondTeam { get; set; }
        public int FirstScore { get; set; }
        public int SecondScore { get; set; }
    }
}