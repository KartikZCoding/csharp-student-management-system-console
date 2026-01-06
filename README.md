# 🎓 Student Management System

*C# Console Application*

------------------------------------------------------------------------

## 📌 Project Overview

The **Student Management System** is a **console-based C# application**
that allows users to manage student records using a **menu-driven
interface**.

This system is built with a clear separation of concerns and applies
**Object-Oriented Programming (OOP)** principles.\
All data is stored **in memory** using collections.

------------------------------------------------------------------------

## 🎯 Functionalities

The system supports the following operations:

-   ➕ Add Student\
-   📋 View All Students\
-   🔍 Search Student (by ID)\
-   ❌ Delete Student (by ID)\
-   🚪 Exit application

------------------------------------------------------------------------

## 🧍 Student Fields (IMPORTANT)

### 🔹 Fields Taken From User Input

When adding a student, the system asks the user to enter:

  Field    Type     Description
  -------- -------- ---------------------------
  `Id`     int      Unique student identifier
  `Name`   string   Student name
  `Age`    int      Student age

📌 **Only these three fields are used in the system.**

------------------------------------------------------------------------

### 🔹 Fields Shown to the User

Whenever a student is: - Viewed - Searched - Listed

The system displays:

    Id: <Student Id>
    Name: <Student Name>
    Age: <Student Age>

This output is generated using the `ToString()` method of the `Student`
class.

------------------------------------------------------------------------

## 🧱 Project Structure

    Student management System
    │
    ├── Program.cs
    │
    ├── Models
    │   └── Student.cs
    │
    ├── Services
    │   └── StudentService.cs
    │
    ├── Data
    │   └── StudentRepository.cs

------------------------------------------------------------------------

## 📂 File Responsibilities

### 🔹 Program.cs

-   Entry point of the application\
-   Displays menu options\
-   Takes user input\
-   Calls service methods

------------------------------------------------------------------------

### 🔹 Models/Student.cs

-   Defines the `Student` class\
-   Properties:
    -   `Id`
    -   `Name`
    -   `Age`
-   Overrides `ToString()` to format output for display

------------------------------------------------------------------------

### 🔹 Services/StudentService.cs

-   Contains **business logic**
-   Validates student data
-   Handles:
    -   Add student
    -   Get all students
    -   Search student by ID
    -   Delete student by ID

------------------------------------------------------------------------

### 🔹 Data/StudentRepository.cs

-   Stores students in `List<Student>`
-   Performs data operations:
    -   Add
    -   Find
    -   Get all
    -   Delete

------------------------------------------------------------------------

## 🔄 Application Flow (Step-by-Step)

1.  Application starts from `Program.cs`
2.  Menu is displayed:
    -   Add Student
    -   View Students
    -   Search Student
    -   Delete Student
    -   Exit
3.  User selects an option
4.  Input is taken (Id, Name, Age where required)
5.  `StudentService` processes the request
6.  `StudentRepository` updates or retrieves data
7.  Output is displayed in the console
8.  Menu repeats until exit

### 🔁 Logical Flow

    Program.cs
       ↓
    StudentService
       ↓
    StudentRepository
       ↓
    List<Student> (In-Memory)

------------------------------------------------------------------------

## 🧠 Concepts Used

-   C# Console Application\
-   Object-Oriented Programming (OOP)
    -   Classes & Objects
    -   Encapsulation
-   Collections (`List<T>`)
-   Menu-driven programming
-   Input validation
-   Separation of Concerns

------------------------------------------------------------------------

## 📚 Learning Outcome

Through this project, I learned:

-   How to take structured user input
-   How to display formatted output
-   How to apply OOP in a real project
-   How to separate UI, business logic, and data layers

------------------------------------------------------------------------

⭐ Part of my **C# to .NET Developer Journey**
