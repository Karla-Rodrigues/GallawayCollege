using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarlaR_300997958.Models
{
    public interface IFacultyRepository
    {
        IQueryable<Faculty> Faculties { get; }
        void SaveFaculty(Faculty faculty);
        Faculty DeleteFaculty(int facultyCode);
    }
}
