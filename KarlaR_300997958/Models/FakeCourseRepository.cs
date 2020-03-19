using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarlaR_300997958.Models
{
    public class FakeCourseRepository /*: ICourseRepository*/
    {
        private static List<Course> cStatic = new List<Course>();

        private static List<Course> cRepository = new List<Course>()
        {
            //new Course
            //{
            //    CourseCode = "ARTS001",
            //    CourseName = "Basic Arts",
            //    CourseFaculty = "300012345",
            //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
            //},
            //new Course
            //{
            //    CourseCode = "ENGI001",
            //    CourseName = "Basic Engineering",
            //    CourseFaculty = "300012345",
            //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
            //},
            //new Course
            //{
            //    CourseCode = "MATH001",
            //    CourseName = "Basic Math",
            //    CourseFaculty = "300012349",
            //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
            //},
            //new Course
            //{
            //    CourseCode = "ENGL001",
            //    CourseName = "Basic English",
            //    CourseFaculty = "300012450",
            //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
            //},
            //new Course
            //{
            //    CourseCode = "BUSS001",
            //    CourseName = "Basic Business",
            //    CourseFaculty = "300012345",
            //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
            //},
            //new Course
            //{
            //    CourseCode = "ARTS002",
            //    CourseName = "Adv Arts",
            //    CourseFaculty = " ",
            //    CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
            //}
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
        };
        public static IEnumerable<Course> CRepository
        {
            get
            {
                return cRepository;
            }
        }
        public static void AddCourse(Course course)
        {
            cRepository.Add(course);
        }
        public IQueryable<Course> Courses => new List<Course> {
            new Course
            {
                CourseCode = "ARTS001",
                CourseName = "Basic Arts",
                CourseFaculty = "300012345",
                CourseDesc = "Morbi sollicitudin, sed sit amet, incidunt odio at, ictum magna"
            }
        }.AsQueryable<Course>();

    }
}
