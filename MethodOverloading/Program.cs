using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new NotImplementedException();
        }

        class Employee
        {
            public string _firstName { get; set; }
            public string _lastName { get; set; }

            public Employee(string firstName, string lastName)
            {
                _firstName = firstName;
                _lastName = lastName;
            }

            public void eat()
            {

            }

            public void eat(string food)
            {

            }

            public void eat(List<Employee> companions)
            {

            }

            public void eat(string food, List<Employee> companions)
            {

            }
        }
    }
}
