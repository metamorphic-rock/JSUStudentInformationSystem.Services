using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSUSIS.Domain.Models
{
    public class Professor: PersonalInformation
    {
        public List<Class> Classes { get; set; }
        public DateTime EmployementDate { get; set; }
        public Boolean IsFullTime { get; set; }
    }
}
