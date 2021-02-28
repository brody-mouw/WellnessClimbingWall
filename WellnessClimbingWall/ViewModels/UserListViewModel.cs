using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Models;

namespace WellnessClimbingWall.ViewModels
{
    public class UserListViewModel
    {
        public IEnumerable<User> Users { get; set; }
    }
}
