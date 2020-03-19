using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KarlaR_300997958.Models;
using Microsoft.AspNetCore.Authorization;

namespace KarlaR_300997958.Controllers
{
    public class CourseController : Controller
    {
        // REPOSITORY FOR COURSE
        private ICourseRepository cRepository;
        public CourseController(ICourseRepository cRepo)
        {
            cRepository = cRepo;
        }

        // LIST OF COURSE
        [AllowAnonymous]
        public ViewResult Course() => View(cRepository.Courses);


        // CREATE A NEW COURSE
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ViewResult CCourse() => View(new Course());

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CCourse(Course course) 
        {
            if (ModelState.IsValid)
            {
                cRepository.SaveCourse(course);
                TempData["message"] = $"{course.CourseName} has been saved";
                return RedirectToAction("Course");
            }
            else
            {
                // there is something wrong with the data values
                return View(course);
            }
        }

        // VIEW
        [AllowAnonymous]
        public ViewResult VCourse(string courseCode) 
        {
            ViewBag.MustDisable = true;
            ViewBag.MDCode = true;
            ViewBag.MDFaculty = true;      
            return View(cRepository.Courses.FirstOrDefault(c => c.CourseCode == courseCode));
        }

        // UPDATE
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ViewResult UCourse(string courseCode)
        {
            ViewBag.MustDisable = false;
            ViewBag.MDCode = true;
            ViewBag.MDFaculty = false;
            return View(cRepository.Courses.FirstOrDefault(c => c.CourseCode == courseCode));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult UCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                cRepository.SaveCourse(course);
                TempData["message"] = $"{course.CourseName} has been saved";
                return RedirectToAction("Course");
            }
            else
            {
                // there is something wrong with the data values
                return View(course);
            }
        }

        // DELETE
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ViewResult DCourse(string courseCode)
        {
            ViewBag.MustDisable = true;
            ViewBag.MDCode = true;
            ViewBag.MDFaculty = true;
            return View(cRepository.Courses.FirstOrDefault(c => c.CourseCode == courseCode));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DCourse(Course course)
        {
            cRepository.DeleteCourse(course.CourseCode);
            TempData["message"] = $"{course.CourseName} was deleted";
            return RedirectToAction("Course");

        }

        // ASSIGN FACULTY TO COURSE
        [HttpGet]
        [Authorize(Roles = "Admin, General")]
        public ViewResult Assign(string courseCode)
        {
            return View(cRepository.Courses.FirstOrDefault(c => c.CourseCode == courseCode));
        }

        [HttpPost]
        [Authorize(Roles = "Admin, General")]
        public IActionResult Assign(Course course)
        {
            if (ModelState.IsValid)
            {
                cRepository.SaveCourse(course);
                TempData["message"] = $"{course.CourseFaculty} has been assign to {course.CourseCode}";
                return RedirectToAction("Course");
            }
            else
            {
                // there is something wrong with the data values
                return View(course);
            }
        }
    }
}