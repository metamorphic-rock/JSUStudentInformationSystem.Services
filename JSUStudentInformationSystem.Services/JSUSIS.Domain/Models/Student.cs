using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSUSIS.Domain.Models
{
    public class Student : PersonalInformation
    {
        public string StudentNumber { get; set; }
        public string YearLevel { get; set; }
        public string Section { get; set; }
        public bool IsEnrolled { get; set; }
        public DateTime EnrollmentDate { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User UserAccount { get; set; }

        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public Program EnrolledProgram { get; set; }
        public List<Program>? PreviousProgram { get; set; }

    }
}
