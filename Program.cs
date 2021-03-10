using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("First name (Leave empty to end):");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    break;
                }
                Console.WriteLine("Last name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Id:");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Photo Url:");
                string photoUrl = Console.ReadLine();
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
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
