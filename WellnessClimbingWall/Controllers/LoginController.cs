using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WellnessClimbingWall.Models;

namespace WellnessClimbingWall.Controllers
{
    public class LoginController : Controller
    {
        public ViewResult LoginView()
        {
            Login login = new Login();

            return View(login);
        }

    }
}