using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }
        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId = 1,
                FirstName = "Herling",
                LastName = "Kalangi",
                Email = "herling@gmail.com",
                DateOfBirth = new DateTime(2001, 9, 20),
                Gender = Gender.Male,
                Department = new Department {DepartmentId = 1, DepartmentName = "Developer"},
                PhotoPath = "image/herling.jpg"
            };

            Employee e2 = new Employee{
                EmployeeId = 2,
                FirstName = "Alex",
                LastName = "Gulo",
                Email = "alex@gmail.com",
                DateOfBirth = new DateTime(2001, 9, 18),
                Gender = Gender.Male,
                Department = new Department {DepartmentId = 1, DepartmentName = "Analize Project"},
                PhotoPath = "image/alex.jpg"
            };

            Employee e3 = new Employee{
                EmployeeId = 3,
                FirstName = "Inggried",
                LastName = "Angelica",
                Email = "inggried@gmail.com",
                DateOfBirth = new DateTime(2001, 10, 9),
                Gender = Gender.Female,
                Department = new Department {DepartmentId = 1, DepartmentName = "Product Designer"},
                PhotoPath = "image/inggried.jpg"
            };

            Employee e4 = new Employee{
                EmployeeId = 3,
                FirstName = "Era",
                LastName = "Angela",
                Email = "era@gmail.com",
                DateOfBirth = new DateTime(2001, 10, 9),
                Gender = Gender.Female,
                Department = new Department {DepartmentId = 1, DepartmentName = "Testing Design"},
                PhotoPath = "image/era.jpg"
            };

            Employees = new List<Employee>{e1, e2, e3, e4};
        }
    }
}