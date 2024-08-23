using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSUSIS.Domain.Models
{
    public class Program
    {
        [Key]
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public int ProgramDuration { get; set; }
        public List<ProgramSemester> ProgramSemesters { get; set; }
        public List<Student> EnrolledStudents { get; set; }

    }
}
