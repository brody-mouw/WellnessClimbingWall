using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WellnessClimbingWall.Models
{
    public class Route
    {
        public int RouteId { get; set; }
        public string Grade { get; set; }
        public string Color { get; set; }
        public ushort Rope { get; set; }
        [Display(Name = "Date and Time")]
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }
        public string Location { get; set; }
        public string Setter { get; set; }

    }
}
