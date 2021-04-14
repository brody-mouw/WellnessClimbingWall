using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellnessClimbingWall.Models
{
    public interface IVisitRepository
    {
        IEnumerable<Visit> AllVisits { get; }
        Visit GetVisitById(int userID);
    }
}
