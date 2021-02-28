using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Models;

namespace WellnessClimbingWall.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult AdminView()
        {
            return View();
        }
    }
}
