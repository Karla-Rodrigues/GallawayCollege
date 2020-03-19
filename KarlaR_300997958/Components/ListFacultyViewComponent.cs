using KarlaR_300997958.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KarlaR_300997958.Components
{
    public class ListFacultyViewComponent : ViewComponent
    {
        private IFacultyRepository repository;

        public ListFacultyViewComponent(IFacultyRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedFaculties = RouteData?.Values["faculty"];
            return View(repository.Faculties);
        }

    }
}
