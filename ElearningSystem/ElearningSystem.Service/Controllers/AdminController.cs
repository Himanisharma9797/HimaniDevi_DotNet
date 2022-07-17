using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElearningSystem.Service.Controllers
{
    public class AdminController : Controller
    {
       public IActionResult AdminMenu()
        {
            Log.Information("Admin Menu function executed");
            return View();
        }
        public IActionResult Projects()
        {
            Log.Information("Projects in admin function executed");
            return View();
        }
    }
}
