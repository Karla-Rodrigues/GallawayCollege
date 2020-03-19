using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarlaR_300997958.Models
{
    public class EFFacultyRepository : IFacultyRepository
    {
        private ApplicationDbContext context;
        public EFFacultyRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Faculty> Faculties => context.Faculties;

        public void SaveFaculty (Faculty faculty)
        {
            Faculty dbEntry = context.Faculties
                .FirstOrDefault(f => f.FacultyCode == faculty.FacultyCode);

            if (dbEntry != null)
            {
                dbEntry.FacultyCode = faculty.FacultyCode;
                dbEntry.FacultySurname = faculty.FacultySurname;
                dbEntry.FacultyName = faculty.FacultyName;
                dbEntry.FacultyEMail = faculty.FacultyEMail;
                dbEntry.FacultyCourse = faculty.FacultyCourse;
            }
            else
            {
                context.Faculties.Add(faculty);
            }
           
            context.SaveChanges();
        }
        
        public Faculty DeleteFaculty(int facultyCode)
        {
            Faculty dbEntry = context.Faculties.FirstOrDefault(f => f.FacultyCode == facultyCode);

            if (dbEntry != null)
            {
                context.Faculties.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
