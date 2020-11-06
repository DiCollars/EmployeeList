using System;

namespace EmployeeList.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FullName {get;set;}

        public string Position { get; set; }

        public DateTime Birthday { get; set; }

        public string Characteristic { get; set; }

        public bool Decree { get; set; }
    }
}
