using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a name (Leave empty to end): ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                Employee currentEmployee = new Employee();
                currentEmployee.FirstName = input;
                employees.Add(input);
            }
            return employees;
        }
        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
        static void Main(string[] args)
        {
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}


// Employee</td>
//     <td></td>
//   </tr>
//   <tr>
//     <td>string</td>
//     <td>First Name</td>
//   </tr>
//   <tr>
//     <td>string</td>
//     <td>Last Name</td>
//   </tr>
//   <tr>
//     <td>integer</td>
//     <td>Id</td>
//   </tr>
//   <tr>
//     <td>string</td>
//     <td>Photo URL
