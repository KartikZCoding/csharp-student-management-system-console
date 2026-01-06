using Student_Management_System.Models;
using Student_Management_System.Services;
using System;
using System.Collections.Generic;

namespace Student_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool looping = false;
            StudentService studentService = new StudentService();
            while (looping)
            {
                try
                {
                    Console.WriteLine("1. Add Student\n" +
                                    "2. View Student\n" +
                                    "3. Search Student\n" +
                                    "4. Delete Student\n" +
                                    "5. Exit");
                    Console.WriteLine();

                    Console.Write("Enter your choice :");
                    int choice = Convert.ToInt32(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            Student student = new Student();

                            Console.Write("Enter Id: ");
                            student.Id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            student.Name = Console.ReadLine();

                            Console.Write("Enter Age: ");
                            student.Age = Convert.ToInt32(Console.ReadLine());

                            string addResult = studentService.AddStudent(student);
                            Console.WriteLine(addResult);
                            break;

                        case 2:
                            List<Student> students = studentService.GetAllStudents();

                            if (students.Count == 0)
                            {
                                Console.WriteLine("No students found.");
                            }
                            else
                            {
                                foreach (Student s in students)
                                {
                                    Console.WriteLine("------------------");
                                    Console.WriteLine(s);
                                    Console.WriteLine("------------------");
                                }
                            }
                            break;

                        case 3:
                            Console.Write("Enter Student Id to search: ");
                            int searchId = Convert.ToInt32(Console.ReadLine());

                            Student foundStudent = studentService.FindStudent(searchId);

                            if (foundStudent == null)
                            {
                                Console.WriteLine("Student not found.");
                            }
                            else
                            {
                                Console.WriteLine(foundStudent);
                            }
                            break;

                        case 4:
                            Console.Write("Enter Student Id to delete: ");
                            int deleteId = Convert.ToInt32(Console.ReadLine());

                            string deleteResult = studentService.DeleteStudent(deleteId);
                            Console.WriteLine(deleteResult);
                            break;

                        case 5:
                            Console.WriteLine("Exiting...");
                            looping = false;
                            break;

                        default:
                            Console.WriteLine("Please enter a number between 1 to 5 only!!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter a number between 1 to 5 only!!");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
