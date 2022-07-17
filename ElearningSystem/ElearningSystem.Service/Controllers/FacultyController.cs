using ElearningSystem.BusinessLayer.InterfaceBL;
using ElearningSystem.DataLayer.Models;
using ElearningSystem.DataLayer.Models.Upload;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ElearningSystem.Service.Controllers
{
    public class FacultyController : Controller
    {
        private IFacultyBusinessLayer _facultyBusinessLayer;
        public FacultyController(IFacultyBusinessLayer facultyBusinessLayer, IWebHostEnvironment iweb)
        {
            _facultyBusinessLayer = facultyBusinessLayer;
            _iweb = iweb;  
        }
        [HttpGet]
        public IActionResult DisplayFaculty()
        {
            Log.Information("Display Faculty function executed");
            try
            {
                List<FacultyModel> getFaculty = _facultyBusinessLayer.DisplayFaculty();
                if (getFaculty != null)
                {
                    return View(getFaculty);
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
        [HttpDelete]
        public IActionResult DeleteFaculty(int facultyId)
        {
            Log.Information("Delete Faculty function executed");
            try
            {
                List<FacultyModel> DeleteFaculty = _facultyBusinessLayer.DeleteFaculty(facultyId);
                return Ok("Faculty Deleted Successfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Deleting data");
            }
        }
        public IActionResult Menu()
        {
            Log.Information("Menu in Faculty function executed");
            return View();
        }
        private readonly IWebHostEnvironment _iweb;
        public IActionResult Upload()
        {
            Log.Information("Upload in Faculty function executed");
            ImageClass ic = new ImageClass();
            var displaying = Path.Combine(_iweb.WebRootPath, "Facultyimages");
            DirectoryInfo di = new DirectoryInfo(displaying);
            FileInfo[] fileInfo = di.GetFiles();
            ic.fileImage = fileInfo;
            return View(ic);
        }
        [HttpPost]
        public async Task<ActionResult> Upload(IFormFile imgfile)
        {
            string ext = Path.GetExtension(imgfile.FileName);
            if(ext==".jpg"|| ext==".pdf")
            {
                var imgsave = Path.Combine(_iweb.WebRootPath, "Facultyimages", imgfile.FileName);
                var stream = new FileStream(imgsave, FileMode.Create);
                await imgfile.CopyToAsync(stream);
                stream.Close();
            }
            return RedirectToAction("Menu");
        }
        public IActionResult Delete(string imgdel)
        {
            imgdel = Path.Combine(_iweb.WebRootPath, "FacultyImages", imgdel);
            FileInfo fi = new FileInfo(imgdel);
            if (fi != null)
            {
                System.IO.File.Delete(imgdel);
                fi.Delete();
            }
            return RedirectToAction("Menu");
        }
        public IActionResult Documentation()
        {
            Log.Information("Documentation in faculty function executed");
            return View();
        }
        public IActionResult ViewProjects()
        {
            Log.Information("View Project in Faculty function executed");
            FileClass ic = new FileClass();
            var displaying = Path.Combine(_iweb.WebRootPath, "Images");
            DirectoryInfo di = new DirectoryInfo(displaying);
            FileInfo[] fileInfo = di.GetFiles();
            ic.FileImage = fileInfo;
            return View(ic);
        }
        public IActionResult Directory()
        {
            try
            {
                List<FacultyModel> getFaculty = _facultyBusinessLayer.DisplayFaculty();
                if (getFaculty != null)
                {
                    return View(getFaculty);
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
