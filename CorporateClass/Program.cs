using System;
using System.Linq;
using System.Collections.Generic;

namespace CorporateClass
{
    class Program
    {
        public class Company
        {
            /*
                Some readonly properties
            */
            public string Name { get; }
            public DateTime CreatedOn { get; }

            // Create a property for holding a list of current employees
            public List<Employee> Employees { get; set; }

            // Create a method that allows external code to add an employee
            public void addEmployee(Employee empl)
            {
                Employees.Add(empl);
            }

            // Create a method that allows external code to remove an employee
            public void removeEmployee(Employee empl)
            {
                Employees.Remove(empl);
            }
            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */
            public Company(string nameOfCompany, DateTime createdOn)
            {
                Name = nameOfCompany;
                CreatedOn = createdOn;
                Employees = new List<Employee>();
            }

            public void ListEmployees()
            {
                foreach(Employee dude in Employees)
                {
                    Console.WriteLine(dude.EmployeeName);
                }
            }
        }

        static void Main()
        {
            Company NSS = new Company("NSS", DateTime.Now);
            Employee steve = new Employee("steve", "Coach");
            Employee john = new Employee("john", "CEO");
            Employee nathan = new Employee("nathan", "teacher");

            NSS.addEmployee(steve);
            NSS.addEmployee(john);
            NSS.addEmployee(nathan);
            NSS.ListEmployees();

            Console.ReadLine();
        }
    }
}
