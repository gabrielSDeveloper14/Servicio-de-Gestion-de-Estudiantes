using StudentManagementService.Contract;
using StudentManagementService.Dtos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StudentManagementService.Services
{
    public class StudentSqlService : IStudentService
    {
        private readonly string connectionString = "Server=GABRIEL\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;";

        public void AddStudent(StudentDto student)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var cmd = new SqlCommand("INSERT INTO Students (Name, Email) VALUES (@Name, @Email)", connection);
            cmd.Parameters.AddWithValue("@Name", student.Name);
            cmd.Parameters.AddWithValue("@Email", student.Email);
            cmd.ExecuteNonQuery();
        }

        public List<StudentDto> GetAllStudents()
        {
            var students = new List<StudentDto>();

            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var cmd = new SqlCommand("SELECT Id, Name, Email FROM Students", connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                students.Add(new StudentDto
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    Email = reader["Email"].ToString()
                });
            }

            return students;
        }
    }
}