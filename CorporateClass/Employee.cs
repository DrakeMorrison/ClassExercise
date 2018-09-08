using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public DateTime StartDate;
        public string JobTitle;

        public Employee(string name, string title)
        {
            changeName(name);
            startJob(DateTime.Now, title);
        }

        public void changeName(string name)
        {
            EmployeeName = name;
        }

        public void startJob(DateTime startDate, string jobTitle)
        {
            StartDate = startDate;
            JobTitle = jobTitle;
        }
    }
}
