
using StudentManagementService.Dtos;
using StudentManagementService.Services;

var studentService = new StudentSqlService();

try
{
    studentService.AddStudent(new StudentDto { Name = "Gabriel", Email = "gabriel@email.com" });
    var students = studentService.GetAllStudents();

    foreach (var student in students)
    {
        Console.WriteLine($"{student.Id}: {student.Name} - {student.Email}");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}