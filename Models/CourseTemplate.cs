
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    /// A simple class that contains everything we need to know about a course.
    public class CourseTemplate
    {
        [Required]
        public string Name { get; set; }
        // example: "Web Services"
        [Required]
        public string CourseID { get; set; }
        // example: "T-514-VEFT"
    }
}