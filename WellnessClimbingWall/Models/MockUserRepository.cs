using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellnessClimbingWall.Models
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> AllUsers
        {
            get
            {
                return new List<User> //passwords are usernames with a 0 at the end
                {
                    new User {ID = 101, Name="Climbing Wall Admin", AccessLevel = User.AccessType.admin, Username = "CWAdmin", PW = "CWAdmin0", IsHashed = false },
                    new User {ID = 102, Name="Climbing Wall Route Setter", AccessLevel = User.AccessType.routeSetter, Username = "CWRoute", PW = "CWRoute0", IsHashed = false },
                    new User {ID = 103, Name="Climbing Wall General Staff", AccessLevel = User.AccessType.staff, Username = "CWStaff", PW = "CWStaff0", IsHashed = false },
                    new User {ID = 104, Name="No-Access User", AccessLevel = User.AccessType.none, Username = "CWNone", PW = "CWNone0", IsHashed = false },
                };
            }
        }

        public User GetUserById(int userID)
        {
            throw new System.NotImplementedException();
        }
    }
}
