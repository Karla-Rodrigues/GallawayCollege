using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KarlaR_300997958.Models;

namespace KarlaR_300997958.Components
{
    public class ListCourseViewComponent : ViewComponent
    {
        private ICourseRepository repository;

        public ListCourseViewComponent(ICourseRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCourses = RouteData?.Values["course"];
            return View(repository.Courses);
        }
    }
}
