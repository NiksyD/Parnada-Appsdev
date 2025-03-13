using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnada_Appsdev.Models
{
    public class ModelStudent
    {
        public int ID;
        public string FirstName = "";
        public string MiddleName = "";
        public string LastName = "";
        public string FullName = "";
        public string Course = "";
        public string CurriculumYear = "";
        public int YearLevel;
        public int Semester;
        public string Remarks = "";
        public string Status = "";
    }
}
