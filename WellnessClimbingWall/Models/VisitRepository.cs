using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Data;

namespace WellnessClimbingWall.Models
{
    public class VisitRepository : IVisitRepository
    {
        private readonly AppDbContext _appDbContext;

        public VisitRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Visit> AllVisits
        {
            get
            {
                return _appDbContext.Visit;
            }
        }

        public Visit GetVisitById(int ID)
        {
            return _appDbContext.Visit.FirstOrDefault(p => p.ID == ID);
        }
    }
}
