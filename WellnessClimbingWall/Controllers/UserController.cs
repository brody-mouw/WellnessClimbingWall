using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Models;
using WellnessClimbingWall.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WellnessClimbingWall.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ViewResult UserView()
        {
            UserListViewModel userListViewModel = new UserListViewModel();
            userListViewModel.Users = _userRepository.AllUsers;

            return View(userListViewModel);
        }
    }
}
