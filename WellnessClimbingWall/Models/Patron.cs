using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WellnessClimbingWall.Models
{
    public class Patron
    {
        public int ID { get; set; }
        [Range(1000000, 9999999)]
        public int BadgeNumber { get; set; }
        public string Name { get; set; }
        public string Certifications { get; set; }
    }
}
