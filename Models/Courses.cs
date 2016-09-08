using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    /// A simple class that contains everything we need to know about a course.
    public class Course
    {
        [ForeignKey("TemplateID")]
        public string TemplateID { get; set; }
        // example: "T-514-VEFT"
        [Key]
        public int ID { get; set; }
        // example: 1
        [Required]
        public string Semester { get; set; }
        // example: 20163
        [Required]
        public DateTime StartDate { get; set; }
        // example: "2016-08-17"
        [Required]
        public DateTime EndDate { get; set; }
        // example: "2016-11-08"
        [ForeignKey("StudentID")]
        public ICollection<Student> Students { get; set; }
    }
}