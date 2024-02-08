using System.ComponentModel;

namespace Blazor_Components.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public DateOnly JoiningDate { get; set; } = new DateOnly();

        public TimeOnly ClassTime { get; set; } = new TimeOnly();
        
    }
}
