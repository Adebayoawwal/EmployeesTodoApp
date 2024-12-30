using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Employee
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required] 
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int NextOfCin { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public int Password { get; set; }
        [Required]
        public string Gender { get; set; }
   }
}
