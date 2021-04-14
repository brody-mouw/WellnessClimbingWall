using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WellnessClimbingWall.Models;
using WellnessClimbingWall.ViewModels;

namespace WellnessClimbingWall.Controllers
{
    [Authorize(Roles = "Administrators, Staff")]
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

        public IActionResult Csv()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Name, Time in, Time out");
            foreach(var name in Patron)
            {
                builder.AppendLine($"{name.name},{name.timein},{name.timeout}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()),"text.csv","Report.csv");
        }
    }
}
