using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarlaR_300997958.Models
{
    public class FakeFacultyRepository /*: IFacultyRepository*/
    {
        private static List<Faculty> fRepository = new List<Faculty>()
        {
            //new Faculty { FacultyCode = 900001234, FacultySurname = "Smith", FacultyName = "John", FacultyEMail = "t@mm.ca" },
            //new Faculty { FacultyCode = 900001235, FacultySurname = "Maclean", FacultyName = "Mary", FacultyEMail = "rt@mm.ca" },
            //new Faculty { FacultyCode = 900001236, FacultySurname = "Seagle", FacultyName = "Joseph", FacultyEMail = "ft@mm.ca" },
            //new Faculty { FacultyCode = 900001237, FacultySurname = "McFarlan", FacultyName = "Carl", FacultyEMail = "yt@mm.ca" },
            //new Faculty { FacultyCode = 900001238, FacultySurname = "McDonald", FacultyName = "Brian", FacultyEMail = "mt@mm.ca" },
            //new Faculty { FacultyCode = 900001239, FacultySurname = "Fergunson", FacultyName = "Ralph", FacultyEMail = "qt@mm.ca" },
            //new Faculty { FacultyCode = 900001240, FacultySurname = "Adams", FacultyName = "Jake", FacultyEMail = "ct@mm.ca" }
            //new Faculty { FacultyCode = 900001241, FacultySurname = "Philips", FacultyName = "Carl", FacultyEMail = "kt@mm.ca" },
            //new Faculty { FacultyCode = 900001242, FacultySurname = "Hodgson", FacultyName = "Ken", FacultyEMail = "lt@mm.ca" }

        };
        public static IEnumerable<Faculty> FRepository
        {
            get
            {
                return fRepository;
            }
        }
        public static void AddFaculty(Faculty faculty)
        {
            fRepository.Add(faculty);
        }        
        public IQueryable<Faculty> Faculties => new List<Faculty>
        {
            new Faculty { FacultyCode = 900001234, FacultySurname = "Smith", FacultyName = "John", FacultyEMail = "t@mm.ca" }
        }.AsQueryable<Faculty>();

    }
}
