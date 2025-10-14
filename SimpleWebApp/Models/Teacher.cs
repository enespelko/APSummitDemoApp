using System;

namespace SimpleWebApp.Models;

public class Teacher
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }

    public string HomeAddress { get; set; } = string.Empty;
}
