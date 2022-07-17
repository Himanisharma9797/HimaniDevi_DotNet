using ElearningSystem.BusinessLayer.InterfaceBL;
using ElearningSystem.DataLayer.Models;
using ElearningSystem.DataLayer.Models.Upload;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ElearningSystem.Service.Controllers
{
    public class StudentController : Controller
    {
        private IStudentBusinessLayer _studentBusinessLayer;
        public StudentController(IStudentBusinessLayer studentBusinessLayer, IWebHostEnvironment iweb)
        {
            _studentBusinessLayer = studentBusinessLayer;
            _iweb = iweb;
        }
        [HttpGet]
        public IActionResult DisplayStudent()
        {
            Log.Information("Display in Student function executed");
            try
            {
                List<StudentModel> getStudent = _studentBusinessLayer.DisplayStudent();
                if (getStudent != null)
                {
                    return View(getStudent);
                }
                else
                {
                    return NotFound("No data to Display");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Displaying data");
            }
        }
        [HttpGet]
        public IActionResult DeleteStudent(int studentId)
        {
            Log.Information("Delete in Student function executed");
            try
            {
                List<StudentModel> DeleteStudent = _studentBusinessLayer.DeleteStudent(studentId);
                return Ok("Student Deleted Successfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Deleting data");
            }
        }
        public IActionResult MainMenu()
        {
            Log.Information("Main Menu in Student function executed");
            return View();
        }
          public IActionResult Calender()
        {
            Log.Information("Calender in Student function executed");
            return View();
        }
        private readonly IWebHostEnvironment _iweb;
        public IActionResult Projects()
        {
            Log.Information("Projects in Student function executed");
            FileClass ic = new FileClass();
            var displaying = Path.Combine(_iweb.WebRootPath, "Images");
            DirectoryInfo di = new DirectoryInfo(displaying);
            FileInfo[] fileInfo = di.GetFiles();
            ic.FileImage = fileInfo;
            return View(ic);
        }
        [HttpPost]
        public async Task<IActionResult> Projects(IFormFile imgfile)
        {
            String ext = Path.GetExtension(imgfile.FileName);
            if (ext == ".jpg" || ext == ".gif" || ext == ".pdf")
            {
                var imgsave = Path.Combine(_iweb.WebRootPath, "Images", imgfile.FileName);
                var stream = new FileStream(imgsave, FileMode.Create);
                await imgfile.CopyToAsync(stream);
                stream.Close();
            }
            return RedirectToAction("MainMenu");
        }
        public IActionResult Delete(string imgdel)
        {
            imgdel = Path.Combine(_iweb.WebRootPath, "Images", imgdel);
            FileInfo fi = new FileInfo(imgdel);
            if (fi != null)
            {
                System.IO.File.Delete(imgdel);
                fi.Delete();
            }
            return RedirectToAction("MainMenu");
        }
        public FileResult Download(string fileName)
        {
            string path = Path.Combine(_iweb.WebRootPath, "Images\\") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, "application/octet-stream", fileName);
        }
        public IActionResult Knowledge()
        {
            Log.Information("Knowledge in Student function executed");
            return View();
        }
        public IActionResult Documentation()
        {
            Log.Information("Documentation in Student function executed");
            FileClass ic = new FileClass();
            var displaying = Path.Combine(_iweb.WebRootPath, "Images");
            DirectoryInfo di = new DirectoryInfo(displaying);
            FileInfo[] fileInfo = di.GetFiles();
            ic.FileImage = fileInfo;
            return View(ic);
        }
        public IActionResult Chat()
        {
            Log.Information("Chat in Student function executed");
            return View();
        }
        public IActionResult Directory()
        {
            try
            {
                List<StudentModel> getStudent = _studentBusinessLayer.DisplayStudent();
                if (getStudent != null)
                {
                    return View(getStudent);
                }
                else
                {
                    return NotFound("No data to Display");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Displaying data");
            }
        }
    }
}
