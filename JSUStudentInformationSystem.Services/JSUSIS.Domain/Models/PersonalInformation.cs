using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSUSIS.Domain.Models
{
    public class PersonalInformation
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string? NamePrefix { get; set; }
        public string? NameSuffix { get; set; }
        public DateTime Birthday { get; set; }
        public string EmailAddress { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; } = new Address();
        public int EmergencyContactId { get; set; }
        public EmergencyContactPerson EmergencyContact { get; set; }

    }
}
