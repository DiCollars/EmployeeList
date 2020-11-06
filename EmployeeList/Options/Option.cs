using EmployeeList.Controllers;
using EmployeeList.Models;
using EmployeeList.Models.ViewModels;
using System;
using System.Linq;

namespace EmployeeList.Options
{
    public class Option : IOption
    {
        private ViewModel _viewModel;
        private Context _context;

        public Option(Context context)
        {
            _viewModel = new ViewModel();
            _context = context;
        }

        public ViewModel GetPaginatedEmployees(int pageSize, int page)
        {
            IQueryable<Employee> source = _context.Employees;
            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            var viewModel = new ViewModel
            {
                PageViewModel = pageViewModel,
                Employees = items
            };
            return viewModel;
        }

        public void AddEmployee(Employee newEmployee)
        {
            if(!_context.Employees.Any(u => u.FullName.ToLower() == newEmployee.FullName.ToLower() 
            && u.Position.ToLower() == newEmployee.Position.ToLower()))
            {
                _context.Employees.Add(newEmployee);
                _context.SaveChanges();
            }
        }

        public void Initialize()
        {
            if (!_context.Employees.Any())
            {
                _context.Employees.AddRange(
                    new Employee
                    {
                        FullName = "Alex Morgen Garryson",
                        Birthday = new DateTime(1994, 12, 25),
                        Decree = false,
                        Position = "Office menager",
                        Characteristic = "Always ready to help and answer any questions"
                    },
                    new Employee
                    {
                        FullName = "Addy Frenkon Stanlyes",
                        Birthday = new DateTime(1981, 12, 30),
                        Decree = false,
                        Position = "Backend developer",
                        Characteristic = "Has resistance to stress and doesn’t lose composure in difficult situations"
                    },
                    new Employee
                    {
                        FullName = "Cox Migeloo Dannyson",
                        Birthday = new DateTime(1954, 1, 13),
                        Decree = true,
                        Position = "Office menager",
                        Characteristic = "An ambitious and determined leader"
                    },
                    new Employee
                    {
                        FullName = "Forty Cisko Foodrexson",
                        Birthday = new DateTime(1980, 5, 19),
                        Decree = false,
                        Position = "Team leader",
                        Characteristic = "Fast learner and punctual"
                    },
                    new Employee
                    {
                        FullName = "Bob Hortybald Francines",
                        Birthday = new DateTime(1959, 8, 22),
                        Decree = false,
                        Position = "Support specialist",
                        Characteristic = "Responsible and reliable"
                    },
                    new Employee
                    {
                        FullName = "Arragin Andryeld Garfields",
                        Birthday = new DateTime(1999, 2, 9),
                        Decree = false,
                        Position = "Backend developer",
                        Characteristic = "Hardworking and tenacious, ready to solve any difficult task"
                    },
                    new Employee
                    {
                        FullName = "Roberty Stacyier Ctasynson",
                        Birthday = new DateTime(1988, 10, 17),
                        Decree = false,
                        Position = "Frontend developer",
                        Characteristic = "Performs tasks in good faith"
                    },
                    new Employee
                    {
                        FullName = "Ally Entonianno Carrensyetto",
                        Birthday = new DateTime(1979, 9, 11),
                        Decree = true,
                        Position = "Frontend developer",
                        Characteristic = "Sociable and non-conflict, able to find a common language in a team"
                    },
                    new Employee
                    {
                        FullName = "Greg Simon Oddinson",
                        Birthday = new DateTime(1997, 11, 29),
                        Decree = false,
                        Position = "Janitor",
                        Characteristic = "Self-assured"
                    },
                    new Employee
                    {
                        FullName = "Julliette Kapriotte Palpello",
                        Birthday = new DateTime(1977, 12, 12),
                        Decree = false,
                        Position = "Full-stack developer",
                        Characteristic = "Attentive to detail and creative"
                    }
                );
                _context.SaveChanges();
            }
        }
    }
}
