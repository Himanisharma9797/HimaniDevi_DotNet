using ElearningSystem.DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ElearningSystem.Service.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult LogInStudent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogInStudent(LogInModel logInModel)
        {
            Log.Information("Log in Student function executed");
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44309/");
            var response = await client.PostAsJsonAsync<LogInModel>($"api/Account/logInStudent", logInModel);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("MainMenu", "Student");
            }
            return View();
        }
        public IActionResult LogInAdmin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogInAdmin(LogInModel logInModel)
        {
            Log.Information("Log in Admin function executed");
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44309/");
            var response = await client.PostAsJsonAsync<LogInModel>($"api/Account/logInAdmin", logInModel);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminMenu", "Admin");
            }
            return View();
        }
        public IActionResult LogInFaculty()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogInFaculty(LogInModel logInModel)
        {
            Log.Information("Log in Faculty function executed");
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44309/");
            var response = await client.PostAsJsonAsync<LogInModel>($"api/Account/logInFaculty", logInModel);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Menu", "Faculty");
            }
            return View();
        }
    }
}
