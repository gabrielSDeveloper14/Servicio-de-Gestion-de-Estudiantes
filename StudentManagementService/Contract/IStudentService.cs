using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementService.Dtos;

namespace StudentManagementService.Contract
{
    public interface IStudentService
    {
        void AddStudent(StudentDto student);
        List<StudentDto> GetAllStudents();
    }
}
