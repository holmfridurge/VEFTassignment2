using System.Collections.Generic;
using System.Collections.Concurrent;

namespace WebApplication.Models
{
    public class StudentsRepository : IStudentsRepository
    {
        // the map variable that contains all the students.
        private ConcurrentDictionary<string, Student> _students =
            new ConcurrentDictionary<string, Student>();

        public StudentsRepository()
        {
            // SSN needs to be unique
            AddStudent(new Student
            {
                Name = "Hólmfríður Guðlaug Einarsdóttir",
                SSN = "0104932859"
            });
            AddStudent(new Student
            {
                Name = "Þorvarður Bergmann",
                SSN = "123456789"
            });
            AddStudent(new Student
            {
                Name = "Daníel Brandur",
                SSN = "12345678986"
            });
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _students.Values;
        }

        public Student AddStudent(Student student)
        {
            _students.TryAdd(student.SSN, student);
            return student;
        }
        
        public Student FindStudent(string ssn)
        {
            Student student;
            _students.TryGetValue(ssn, out student);
            return student;
        }

    }
}