using Student_Management_System.Models;
using System.Collections.Generic;

namespace Student_Management_System.Data
{
    internal class StudentRepository
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public  List<Student> GetAllStudents()
        {
            return students;
        }

        public Student FindStudent(int id)
        {
            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    return s;
                }
            }
            return null;
        }

        public bool DeleteStudent(int id)
        {
            Student student = FindStudent(id);

            if (student == null)
            {
                return false;
            }
            students.Remove(student);
            return true;
        }
    }

}
