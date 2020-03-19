using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarlaR_300997958.Models
{
    public interface ICourseRepository
    {
        IQueryable<Course> Courses { get; }
        void SaveCourse(Course course);
        Course DeleteCourse(string courseCode);
    }
}
