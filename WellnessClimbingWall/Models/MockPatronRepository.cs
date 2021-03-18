using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellnessClimbingWall.Models
{
    public class MockPatronRepository: IPatronRepository
    {
        public IEnumerable<Patron> AllPatrons
        {
            get
            {
                return new List<Patron>
                {
                    new Patron {ID = 72343,Name = "Allison", Certifications = "None"},
                    new Patron {ID = 56666,Name = "Robert", Certifications = "None"},
                    new Patron {ID = 62465,Name = "Matthew", Certifications = "Lead, Top Rope"},
                };
            }
        }

        public Patron GetPatronById(int patronID)
        {
            throw new System.NotImplementedException();
        }
    }
}
