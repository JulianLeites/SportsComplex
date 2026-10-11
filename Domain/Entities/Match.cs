using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    internal class Match
    {
        public int Id { get; set; }
        public DateTime MatchStartDateTime { get; set; }
        public DateTime MatchEndDateTime { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public enum MatchStatus
        {
            Scheduled,
            Live,
            Finished,
            Suspended
        }
    }
}
