using Student_Management_System.Data;
using Student_Management_System.Models;
using System;
using System.Collections.Generic;

namespace Student_Management_System.Services
{
    internal class StudentService
    {
        private StudentRepository repository = new StudentRepository();

        public string AddStudent(Student student)
        {
            if (student.Id <= 0)
            {
                return "Student id must be greater than 0.";
            }

            Student existingStudent = repository.FindStudent(student.Id);
            if (existingStudent != null)
            {
                return "Student with this Id already exists.";
            }

            if (string.IsNullOrWhiteSpace(student.Name))
            {
                return "Student name cannot be empty.";
            }

            if (student.Age <= 0 || student.Age > 100)
            {
                return "Student age must be between 1 to 100.";
            }

            repository.AddStudent(student);
            return "Student added successsfully.";
        }

        public List<Student> GetAllStudents()
        { 
            return repository.GetAllStudents();
        }

        public Student FindStudent(int id)
        {
            return repository.FindStudent(id);
        }

        public string DeleteStudent(int id)
        {
            bool result = repository.DeleteStudent(id);

            if (result)
            {
                return "Student delete successfully.";
            }
            else
            {
                return "Student not found";
            }
        }

    }
}
