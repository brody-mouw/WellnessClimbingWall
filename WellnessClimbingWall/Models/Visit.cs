using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellnessClimbingWall.Models
{
    public class Visit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Certifications { get; set; }
        public DateTime timeIn { get; set; }
        public DateTime timeOut { get; set; }
    }
}
