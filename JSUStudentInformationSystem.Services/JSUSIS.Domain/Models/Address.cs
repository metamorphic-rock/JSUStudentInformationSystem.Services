using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSUSIS.Domain.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string FirstLineAddress { get; set; } = string.Empty;
        public string? SecondLineAddress { get; set; }
        public string? AlternateAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
    }
}
