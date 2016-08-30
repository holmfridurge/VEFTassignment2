using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        public CoursesController(ICoursesRepository course)
        {
            Course = course;
        }

        // the map of courses
        public ICoursesRepository Course { get; set; }

        public IEnumerable<Course> GetAllCourses()
        {
            return Course.GetAllCourses();
        }

        [HttpGet("{id}", Name = "GetCourse")]
        public IActionResult GetCourseById(int id)
        {
            var item = Course.FindCourse(id); //Finds course with given ID
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult AddCourse([FromBody] Course course)
        {
            // FromBody = action parameter to bind a simple type from the request body
            if (course == null)
            {
                return BadRequest();
            }
            Course.AddCourse(course);
            var location = Url.Link("GetCourse", new { id = course.ID });
            return Created(location, course);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, [FromBody] Course newCourse)
        {
            if (newCourse == null)
            {
                return BadRequest();
            }

            newCourse.ID = id;

            var oldCourse = Course.FindCourse(id);
            // Checks if course that will be changed exists.
            if (oldCourse == null)
            {
                return NotFound();
            }

            Course.UpdateCourse(id, newCourse, oldCourse);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveCourse(int id)
        {
            var course = Course.FindCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            Course.RemoveCourse(id);
            return new NoContentResult();
        }

        //--------------------------------------------------------
        // functions regarding the students of the courses.
        //--------------------------------------------------------

        // will return all the students in the course with the following id.
        [HttpGet("{id}/students", Name="GetStudent")]
        public IEnumerable<Student> GetStudentsInCourse(int id)
        {
            return Course.GetAllStudentsInCourse(id);
        }

        // Adds a new student to the course with the following 'courseID'.
        [Route("{courseID:int}/students")]
        [HttpPost]
        public IActionResult AddStudent(int courseID, [FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }
            Course.AddStudent(courseID, student);

            var location = Url.Link("GetStudent", new { id = student.SSN });
            return Created(location, student);
        }

    }
}