using System;
using System.Collections.Generic;

namespace Bangazon_Orientation
{

    public interface IHandicap
    {
        bool IsHandicapped { get; set; }
        string Handicap { get; set; }
    }

    public abstract class Department
    {
        protected string _name;
        protected string _supervisor;
        protected int _employee_count;
        protected double _budget;

        public Department(string name, string supervisor, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_count = employees;
        }

        public abstract DateTime Meet(DateTime date);

        public virtual double SetBudget(double budget)
        {
            return _budget = budget;
        }
    }

    public class HumanResources : Department
    {

        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public HumanResources(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        { }

        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text);

            foreach (KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"{policy.Value}");
            }
        }

        public override string ToString()
        {
            return $"{_name} {_supervisor} {_employee_count} {_budget}";
        }

        public override DateTime Meet(DateTime date)
        {
            return date;
        }
    }

    public class InformationTechnology : Department
    {
        private string TechStack { get; set; } = "MEAN";

        public InformationTechnology(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        { }

        public void changeStack(string newStack)
        {
            TechStack = newStack;
        }

        public override string ToString()
        {
            return $"{_name} {_supervisor} {_employee_count} {TechStack} {_budget}";
        }

        public override DateTime Meet(DateTime date)
        {
            return date.AddYears(3);
        }

        public override double SetBudget(double budget)
        {
            return _budget += budget + 1000000.00;
        }
    }

    public class Marketing : Department
    {
        private Dictionary<string, string> _cateringOrders = new Dictionary<string, string>();

        public Marketing(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        { }

        public void AddOrder(string name, string text)
        {
            _cateringOrders.Add(name, text);

            foreach (KeyValuePair<string, string> order in _cateringOrders)
            {
                Console.WriteLine($"{order.Value}");
            }
        }

        public override string ToString()
        {
            return $"{_name} {_supervisor} {_employee_count} {_budget}";
        }

        public override DateTime Meet(DateTime date)
        {
            return date.AddDays(-2);
        }

        public override double SetBudget(double budget)
        {
            return _budget = budget + 30000.00;
        }
    }

    class Employee : IHandicap
    {
        protected string _firstName;
        protected string _lastName;

        private List<string> _restaurants = new List<string>
        {
            "Chick-fil-A",
            "Oscar's Taco Shop",
            "Nine Fruits"
        };

        public bool IsHandicapped { get; set; } = false;
        public string Handicap { get; set; } = "none";

        Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        private string GetRandomResaurant()
        {
            var rnd = new Random();

            var indexor = rnd.Next(_restaurants.Count + 1);

            return _restaurants[indexor];
        }

        public string Eat()
        {
            var shop = GetRandomResaurant();
            Console.WriteLine($"{_firstName} is at {shop}");
            return shop;
        }

        public string Eat(string food)
        {
            Console.WriteLine($"{_firstName} ate {food} at the office");
            return food;
        }

        public string Eat(List<Employee> companions)
        {
            var shop = GetRandomResaurant();
            Console.Write($"{_firstName} is at {shop} with ");

            foreach (var peer in companions)
            {
                Console.Write(peer._firstName + " and ");
            }

            return shop;
        }

        public string Eat(string food, List<Employee> companions)
        {
            var shop = GetRandomResaurant();

            Console.Write($"{_firstName} is eating {food} at {shop} with ");
            foreach (var peer in companions)
            {
                Console.Write(peer._firstName + " and ");
            }
            return shop;
        }

    }

    class Program
    {
        public static void Main()
        {
            double baseBudget = 75000.00;

            var departments = new List<Department>();

            var hr = new HumanResources("HR", "Amy Schumer", 2);
            var it = new InformationTechnology("IT", "Technowizard", 4);
            var marketing = new Marketing("Marketing", "Christi", 3);

            hr.AddPolicy("super hiring", "We will hire good people");
            it.changeStack(".NET Core");
            marketing.AddOrder("CHS", "500 CFA Biscuits");

            departments.Add(hr);
            departments.Add(it);
            departments.Add(marketing);

            foreach (Department d in departments)
            {
                d.SetBudget(baseBudget);
                Console.WriteLine($"{d.ToString()}");
            }

            Console.ReadLine();
        }
    }
}
