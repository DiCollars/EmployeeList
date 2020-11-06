using EmployeeList.Models;
using EmployeeList.Models.ViewModels;

namespace EmployeeList.Options
{
    public interface IOption
    {
        ViewModel GetPaginatedEmployees(int pageSize, int page = 1);

        void AddEmployee(Employee newEmployee);

        void Initialize();
    }
}
