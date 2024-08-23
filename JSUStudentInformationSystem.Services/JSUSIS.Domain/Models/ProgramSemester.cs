using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace JSUSIS.Domain.Models
{
    public class ProgramSemester
    {
        [Key]
        public int Id { get; set; }
        public string YearAndSemesterLevel { get; set; }

        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public Program Program { get; set; }
        public List<Course> Courses { get; set; }
    }
}
