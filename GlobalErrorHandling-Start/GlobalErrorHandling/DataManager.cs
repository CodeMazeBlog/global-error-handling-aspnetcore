using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlobalErrorHandling.Models;

namespace GlobalErrorHandling
{
    public static class DataManager
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
