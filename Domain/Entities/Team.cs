using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    internal class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string EmblemUrl { get; set; }
    }
}
