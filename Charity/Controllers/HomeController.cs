using System.Diagnostics;
using Charity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Charity.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }  
    }
}
