using System.Collections.Generic;

namespace EmployeeList.Models.ViewModels
{
    public class ViewModel
    {
        public List<Employee> Employees { get; set; }

        public PageViewModel PageViewModel { get; set; }
    }
}
