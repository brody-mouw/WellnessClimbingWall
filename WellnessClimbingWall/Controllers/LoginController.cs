using Microsoft.AspNetCore.Mvc;
using WellnessClimbingWall.Models;
using System.Text.Encodings.Web;

namespace WellnessClimbingWall.Controllers
{
    public class LoginController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}