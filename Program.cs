using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company exoTravel = new Company("Exo-Travel", DateTime.Now);
            
            // Create three employees
            Employee marcus = new Employee()
            {
                FirstName = "Marcus",
                LastName = "Fulbright",
                Title = "Peon",
                StartDate = DateTime.Now
            };
            Employee jack = new Employee()
            {
                FirstName = "Jack",
                LastName = "Black",
                Title = "Sr. Shredder",
                StartDate = DateTime.Now
            };
            Employee derick = new Employee()
            {
                FirstName = "Derick",
                LastName = "Cravens",
                Title = "CEO",
                StartDate = DateTime.Now
            };
            // Assign the employees to the company
            List<Employee> employees = new List<Employee>();
                employees.Add(marcus);
                employees.Add(jack);
                employees.Add(derick);
            foreach(Employee employee in employees)
            {
                Console.WriteLine(exoTravel.ListEmployees(employee));
            }
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}