using System.Collections.Generic;

namespace WebApplication.Models
{
    /// This class handles a map og courses and every variable contained within it.
    public interface ICoursesRepository
    {
        // Get a list of courses
        IEnumerable<Course> GetAllCourses();
        // Add a course
        Course AddCourse(Course course);
        // Find a course with specific id
        Course FindCourse(int id);
        // Update a course
        Course UpdateCourse(int id, Course newCourse, Course oldCourse);
        // Remove a course
        Course RemoveCourse(int id);
        // TODO: Get a list of stodents in a course
        IEnumerable<Student> GetAllStudentsInCourse(int courseID);
        // TODO: Add a student to a course
        Student AddStudent(int courseID, Student student);
    }
}