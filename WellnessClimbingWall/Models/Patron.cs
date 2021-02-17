using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellnessClimbingWall.Models
{
    public class Patron
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TimeIn { get; set; }
        public string Certifications { get; set; }
    }
}
