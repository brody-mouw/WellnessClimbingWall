using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WellnessClimbingWall.Models;
using WellnessClimbingWall.ViewModels;

namespace WellnessClimbingWall.Controllers
{
    public class ReportController : Controller
    {
        private readonly IPatronRepository _patronRepository;   //Does not need a report model

        public ReportController(IPatronRepository patronRepository)
        {
            _patronRepository = patronRepository;
        }

        public ViewResult ReportView()
        {
            PatronListViewModel patronListViewModel = new PatronListViewModel();
            patronListViewModel.Patrons = _patronRepository.AllPatrons;

            return View(patronListViewModel);
        }
    }
}
