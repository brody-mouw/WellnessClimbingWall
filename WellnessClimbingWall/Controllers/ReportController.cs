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
using WellnessClimbingWall.Controllers;
using WellnessClimbingWall.Data;

namespace WellnessClimbingWall.Controllers
{
    [Authorize(Roles = "Administrators, Staff")]
    public class ReportController : Controller
    {
        private readonly IPatronRepository _patronRepository;   //Does not need a report model
        private readonly IVisitRepository _visitRepository;
        private readonly AppDbContext _context;
        public DateTime date1;
        public DateTime date2;

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
            Report report;
            var builder = new StringBuilder();
            builder.AppendLine("Name, Time in, Time out");
            foreach(var name in _visitRepository.AllVisits)
            {
                if(name.timeIn>=date1&&name.timeIn<=date2)
                {
                    builder.AppendLine($"{name.Name},{name.timeIn},{name.timeOut}");
                }
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()),"text.csv","Report.csv");
        }
    }
}
