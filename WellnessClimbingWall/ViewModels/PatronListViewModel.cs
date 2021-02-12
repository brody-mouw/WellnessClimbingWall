using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Models;

namespace WellnessClimbingWall.ViewModels
{
    public class PatronListViewModel
    {
        public IEnumerable<Patron> Patrons { get; set; }
    }
}
