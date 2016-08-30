using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    /// A simple class that contains everything we need to know about a course.
    public class Course
    {
        [Required]
        public string Name { get; set; }
        // example: "Web Services"
        [Required]
        public string TemplateID { get; set; }
        // example: "T-514-VEFT"
        [Required]
        public int ID { get; set; }
        // example: 1
        [Required]
        public DateTime StartDate { get; set; }
        // example: "2016-08-17"
        [Required]
        public DateTime EndDate { get; set; }
        // example: "2016-11-08"
        
        public IStudentsRepository Students { get; set; }
    }
}