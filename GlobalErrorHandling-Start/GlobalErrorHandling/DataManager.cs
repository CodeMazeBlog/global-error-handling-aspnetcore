using GlobalErrorHandling.Models;
using System.Collections.Generic;

namespace GlobalErrorHandling
{
    public class DataManager
    {
        public static List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student { Name="Joe", LastName="Doe", Age=35, Gender="Male"},
                new Student { Name="Jane", LastName="Doe", Age=25, Gender="Female"},
                new Student { Name="Mick", LastName="Simon", Age=32, Gender="Male"},
                new Student { Name="Sandra", LastName="Summer", Age=30, Gender="Female"},
            };
        }
    }
}
