using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    /// A simple class that keeps the name and SSN of a student.
    public class Student
    {
        [Required]
        public string SSN { get; set; }
        [Required]
        public string Name { get; set; }
    }
}