using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Models;
using WellnessClimbingWall.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WellnessClimbingWall.Controllers
{
    public class PatronController : Controller
    {
        private readonly IPatronRepository _patronRepository;

        public PatronController (IPatronRepository patronRepository)
        {
            _patronRepository = patronRepository;
        }

        public ViewResult PatronView()
        {
            PatronListViewModel patronListViewModel = new PatronListViewModel();
            patronListViewModel.Patrons = _patronRepository.AllPatrons;

            return View(patronListViewModel);
        }
    }
}
