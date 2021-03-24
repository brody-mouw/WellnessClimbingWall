using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Data;

namespace WellnessClimbingWall.Models
{
    public class PatronRepository : IPatronRepository
    {

        private readonly AppDbContext _appDbContext;

        public PatronRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Patron> AllPatrons
        {
            get
            {
                return _appDbContext.Patron;
            }
        }

        public Patron GetPatronById(int ID)
        {
            return _appDbContext.Patron.FirstOrDefault(p => p.ID == ID);
        }
    }
}
