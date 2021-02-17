using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellnessClimbingWall.Models
{
    public interface IPatronRepository
    {
        IEnumerable<Patron> AllPatrons { get; }
        Patron GetPatronById(int patronID);
    }
}
