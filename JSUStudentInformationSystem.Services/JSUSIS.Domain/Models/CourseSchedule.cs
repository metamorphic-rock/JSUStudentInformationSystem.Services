using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSUSIS.Domain.Models
{
    public class CourseSchedule
    {
        [Key]
        public int Id { get; set; }
        public List<Student> Students { get; set; }
        public List<Class> Classes { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string CourseTitle { get; set; }
    }
}
