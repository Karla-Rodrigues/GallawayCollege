using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarlaR_300997958.Models
{
    public class EFCourseRepository : ICourseRepository
    {
        private ApplicationDbContext context;
        public EFCourseRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Course> Courses => context.Courses;

        public void SaveCourse(Course course)
        {
            Course dbEntry = context.Courses
                .FirstOrDefault(f => f.CourseCode == course.CourseCode);

            if (dbEntry != null)
            {
                dbEntry.CourseCode = course.CourseCode;
                dbEntry.CourseName = course.CourseName;
                dbEntry.CourseFaculty = course.CourseFaculty;
                dbEntry.CourseDesc = course.CourseDesc;
            }
            else
            {
                context.Courses.Add(course);
            }

            context.SaveChanges();
        }

        public Course DeleteCourse(string courseCode)
        {
            Course dbEntry = context.Courses.FirstOrDefault(c => c.CourseCode == courseCode);

            if (dbEntry != null)
            {
                context.Courses.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
