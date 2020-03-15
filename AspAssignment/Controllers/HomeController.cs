using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspAssignment.Models;
using AspAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspAssignment.Controllers
{
    public class HomeController : Controller
    {
        
       
        
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
