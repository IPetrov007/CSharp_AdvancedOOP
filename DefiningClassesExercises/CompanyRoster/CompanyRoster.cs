using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class CompanyRoster
    {
        public static void Main()
        {
            var employees = new List<Employee>();

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var name = inputLine[0];
                var salary = double.Parse(inputLine[1]);
                var position = inputLine[2];
                var department = inputLine[3];

                var employee = new Employee(name, salary, position, department);

                if (inputLine.Length > 4 && inputLine[4].Contains("@"))
                {
                    var email = inputLine[4];
                    employee.Email = email;
                }
                if(inputLine.Length > 4 && !inputLine[4].Contains("@"))
                {
                    var age = int.Parse(inputLine[4]);
                    employee.Age = age;
                }
                if (inputLine.Length > 5)
                {
                    var age = int.Parse(inputLine[5]);
                    employee.Age = age;
                }

                employees.Add(employee);
            }

            var result = employees
                .GroupBy(e => e.department)
                .OrderByDescending(x => x.Average(em => em.salary))
                .First()
                .OrderByDescending(s => s.salary)
                .ToList();
            Console.WriteLine($"Highest Average Salary: {result.First().department}");
            foreach (var em in result)
            {
                Console.WriteLine($"{em.name} {em.salary:f2} {em.email} {em.age}");
            }
        }
    }
}
