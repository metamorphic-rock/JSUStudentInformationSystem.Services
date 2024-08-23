using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSUSIS.Domain.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public List<CourseSchedule> CourseSchedules { get; set; }

    }
}
