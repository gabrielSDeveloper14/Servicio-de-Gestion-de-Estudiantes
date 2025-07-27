using StudentManagementService.Contract;
using StudentManagementService.Dtos;
using System;
using System.Collections.Generic;

namespace StudentManagementService.Servises
{
    public class StudentService : IStudentService
    {

        private readonly List<StudentDto> students = new();

        public void AddStudent(StudentDto student)

        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(student.Name))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(student.Email))
                throw new ArgumentException("El email es obligatorio.");

            students.Add(student);
        }

        public List<StudentDto> GetAllStudents()
        {
            return students;
        }
    }


}
    








