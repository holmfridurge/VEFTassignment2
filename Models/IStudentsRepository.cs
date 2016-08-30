using System.Collections.Generic;

namespace WebApplication.Models
{
    /// This class will handle a map of students.
    /// The functions are few, only adding, finding, and 
    /// seeing all students in the map.
    public interface IStudentsRepository
    {
        IEnumerable<Student> GetAllStudents();

        Student AddStudent(Student student);
        Student FindStudent(string ssn);
    }
}