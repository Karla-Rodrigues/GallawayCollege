using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KarlaR_300997958.Models;
using Microsoft.AspNetCore.Authorization;

namespace KarlaR_300997958.Controllers
{
    public class FacultyController : Controller
    {
        // REPOSITORY FOR FACULTY
        private IFacultyRepository fRepository;
        public FacultyController(IFacultyRepository fRepo)
        {
            fRepository = fRepo;
        }

        // LIST
        [AllowAnonymous]
        public ViewResult Faculty() => View(fRepository.Faculties);

        // CREATE NEW FACULTY
        [HttpGet]
        [Authorize(Roles="Admin")] 
        public ViewResult CFaculty()
        {
            ViewBag.MustDisable = false;
            ViewBag.MDCode = true;
            ViewBag.MDCourse = true;
            return View(new Faculty());
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CFaculty(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                fRepository.SaveFaculty(faculty);
                TempData["message"] = $"{faculty.FacultyName} has been saved";
                return RedirectToAction("Faculty");
            }
            else
            {
                // there is something wrong with the data values
                return View(faculty);
            }
        }

        // VIEW
        [AllowAnonymous]
        public ViewResult VFaculty(int facultyCode)
        {                                        
            ViewBag.MustDisable = true;
            ViewBag.MDCode = true;
            ViewBag.MDCourse = true;
            return View(fRepository.Faculties.FirstOrDefault(f => f.FacultyCode == facultyCode));
        }

        // UPDATE
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ViewResult UFaculty(int facultyCode)
        {
            ViewBag.MustDisable = false;
            ViewBag.MDCode = true;
            ViewBag.MDCourse = true;
            return View(fRepository.Faculties.FirstOrDefault(f => f.FacultyCode == facultyCode));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult UFaculty(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                fRepository.SaveFaculty(faculty);
                TempData["message"] = $"{faculty.FacultyName} has been saved";
                return RedirectToAction("Faculty");
            }
            else
            {
                // there is something wrong with the data values
                ViewBag.MustDisable = false;
                ViewBag.MDCode = true;
                ViewBag.MDCourse = true;
                return View(faculty);
            }
        }

        // DELETE
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ViewResult DFaculty(int facultyCode)
        {
            ViewBag.MustDisable = true;
            ViewBag.MDCode = true;
            ViewBag.MDCourse = true;
            return View(fRepository.Faculties.FirstOrDefault(f => f.FacultyCode == facultyCode));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DFaculty(Faculty faculty)
        {
            fRepository.DeleteFaculty(faculty.FacultyCode);
            TempData["message"] = $"{faculty.FacultyName} was deleted";
            return RedirectToAction("Faculty");
        }

        // ASSIGN FACULTY TO COURSE
        [HttpGet]
        [Authorize(Roles = "Admin, General")]
        public ViewResult Assign
            (int facultyCode)
        {
            ViewBag.MustDisable = true;
            ViewBag.MDCode = true;
            ViewBag.MDCourse = true;
            return View(fRepository.Faculties.FirstOrDefault(f => f.FacultyCode == facultyCode));
        }

        [HttpPost]
        [Authorize(Roles = "Admin, General")]
        public IActionResult Assign(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                fRepository.SaveFaculty(faculty);
                TempData["message"] = $"{faculty.FacultyCourse} has been assign to {faculty.FacultyCode}";
                return RedirectToAction("Faculty");
            }
            else
            {
                // there is something wrong with the data values
                return View(faculty);
            }
        }
    }
}