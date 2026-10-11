using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    internal class Tournament
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxTeams { get; set; }
    }
}
