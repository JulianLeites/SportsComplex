using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    internal class Sport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinPlayersPerTeam { get; set; }
        public int MaxPlayersPerTeam { get; set; }
        public int MaxPlayersPerMatch { get; set; }
    }
}
