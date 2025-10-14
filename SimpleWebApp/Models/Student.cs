using System;

namespace SimpleWebApp.Models;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateTime EnrollmentDate { get; set; }
    public int GradeLevel { get; set; }
}
