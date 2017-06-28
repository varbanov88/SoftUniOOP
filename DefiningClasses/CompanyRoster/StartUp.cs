using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var employeesCount = int.Parse(Console.ReadLine());

        var employees = new List<Employee>();
        var departmentAvSalary = new Dictionary<string, List<double>>();

        for (int i = 0; i < employeesCount; i++)
        {
            var input = Console.ReadLine().Split();

            var name = input[0];
            var salary = double.Parse(input[1]);
            var position = input[2];
            var department = input[3];

            var employee = new Employee(name, salary, position, department);

            if (!departmentAvSalary.ContainsKey(department))
            {
                departmentAvSalary[department] = new List<double>();
            }

            departmentAvSalary[department].Add(salary);

            if (input.Length > 4)
            {
                if (input.Length == 5)
                {
                    var age = 0;
                    var isAge = int.TryParse(input[4], out age);

                    if (isAge)
                    {
                        employee.Age = age;
                    }

                    else
                    {
                        employee.Email = input[4];
                    }
                }

                else
                {
                    employee.Age = int.Parse(input[5]);
                    employee.Email = input[4];
                }
            }

            employees.Add(employee);
        }

        var result = departmentAvSalary.OrderByDescending(d => d.Value.Average()).First();
        var highestAverageDepartment = result.Key;
        var employeesResult = employees.Where(e => e.Department == highestAverageDepartment)
                                       .OrderByDescending(s => s.Salary)
                                       .ToList();

        Console.WriteLine($"Highest Average Salary: {highestAverageDepartment}");
        foreach (var em in employeesResult)
        {
            Console.WriteLine($"{em.Name} {em.Salary:f2} {em.Email} {em.Age}");
        }
    }
}

