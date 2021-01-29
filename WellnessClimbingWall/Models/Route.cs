using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellnessClimbingWall.Models
{
    public class Route
    {
        public int RouteId { get; set; }
        public string Grade { get; set; }
        public string Color { get; set; }
        public int Rope { get; set; }
        public DateTime DateCreated { get; set; }
        public string Location { get; set; }
        public string Setter { get; set; }

    }
}
