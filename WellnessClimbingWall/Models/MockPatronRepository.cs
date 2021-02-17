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
                    new Patron {ID = 72343,Name = "Allison", TimeIn = "10:30", Certifications = "None"},
                    new Patron {ID = 56666,Name = "Robert", TimeIn = "10:35", Certifications = "None"},
                    new Patron {ID = 62465,Name = "Matthew", TimeIn = "11:00", Certifications = "Bouldering"},
                };
            }
        }

        public Patron GetPatronById(int patronID)
        {
            throw new System.NotImplementedException();
        }
    }
}
