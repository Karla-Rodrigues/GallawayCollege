using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace KarlaR_300997958.Models
{
    public class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Faculties.Any())
            {
                context.Faculties.AddRange
                (
                    /* FacultyCode is generate by system */

                      new Faculty { FacultySurname = "Smith", FacultyName = "John", FacultyEMail = "t@mm.ca", FacultyCourse = "to designate" },
                      new Faculty { FacultySurname = "Maclean", FacultyName = "Mary", FacultyEMail = "rt@mm.ca", FacultyCourse = "to designate" },
                      new Faculty { FacultySurname = "Seagle", FacultyName = "Joseph", FacultyEMail = "ft@mm.ca", FacultyCourse = "to designate" },
                      new Faculty { FacultySurname = "McFarlan", FacultyName = "Carl", FacultyEMail = "yt@mm.ca", FacultyCourse = "to designate" },
                      new Faculty { FacultySurname = "McDonald", FacultyName = "Brian", FacultyEMail = "mt@mm.ca", FacultyCourse = "to designate" },
                      new Faculty { FacultySurname = "Fergunson", FacultyName = "Ralph", FacultyEMail = "qt@mm.ca", FacultyCourse = "to designate" },
                      new Faculty { FacultySurname = "Adams", FacultyName = "Jake", FacultyEMail = "ct@mm.ca", FacultyCourse = "to designate" },
                      new Faculty { FacultySurname = "Philips", FacultyName = "Carl", FacultyEMail = "kt@mm.ca", FacultyCourse = "to designate" },
                      new Faculty { FacultySurname = "Hodgson", FacultyName = "Ken", FacultyEMail = "lt@mm.ca", FacultyCourse = "to designate" }
                );
                context.SaveChanges();
            }

            if (!context.Courses.Any())
            {
                context.Courses.AddRange
                (
                      new Course
                      {
                          CourseCode = "ARTS001",
                          CourseName = "Basic Arts",
                          CourseFaculty = "300012345",
                          CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      },
                      new Course
                      {
                          CourseCode = "ENGI001",
                          CourseName = "Basic Engineering",
                          CourseFaculty = "300012345",
                          CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      },
                      new Course
                      {
                          CourseCode = "MATH001",
                          CourseName = "Basic Math",
                          CourseFaculty = "300012349",
                          CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      },
                      new Course
                      {
                          CourseCode = "ENGL001",
                          CourseName = "Basic English",
                          CourseFaculty = "300012450",
                          CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      },
                      new Course
                      {
                          CourseCode = "BUSS001",
                          CourseName = "Basic Business",
                          CourseFaculty = "300012345",
                          CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      },
                      new Course
                      {
                          CourseCode = "ARTS002",
                          CourseName = "Adv Arts",
                          CourseFaculty = " ",
                          CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      }
                      //new Course
                      //{
                      //    CourseCode = "ENGI002",
                      //    CourseName = "Adv Engineering",
                      //    CourseFaculty = "300012345",
                      //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      //},
                      //new Course
                      //{
                      //    CourseCode = "MATH002",
                      //    CourseName = "Adv Math",
                      //    CourseFaculty = " ",
                      //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      //},
                      //new Course
                      //{
                      //    CourseCode = "ENGL002",
                      //    CourseName = "Adv English",
                      //    CourseFaculty = "300012345",
                      //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      //},
                      //new Course
                      //{
                      //    CourseCode = "BUSS002",
                      //    CourseName = "Adv Business",
                      //    CourseFaculty = "300012345",
                      //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      //},
                      //new Course
                      //{
                      //    CourseCode = "ARTS003",
                      //    CourseName = "Arts",
                      //    CourseFaculty = "300012345",
                      //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      //},
                      //new Course
                      //{
                      //    CourseCode = "ENGI003",
                      //    CourseName = "Engineering",
                      //    CourseFaculty = " ",
                      //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      //},
                      //new Course
                      //{
                      //    CourseCode = "MATH003",
                      //    CourseName = "Math",
                      //    CourseFaculty = "300012345",
                      //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      //},
                      //new Course
                      //{
                      //    CourseCode = "ENGL003",
                      //    CourseName = "English",
                      //    CourseFaculty = "300012345",
                      //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
                      //}

                );
                context.SaveChanges();
            }
        }

    }
}
