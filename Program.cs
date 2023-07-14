using System;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noe, nod, total = 0;
            Console.WriteLine("Enter No of Employees:");
            noe = int.Parse(Console.ReadLine());
            string[][] employee = new string[noe][];
            int[] employeeSalaries = new int[noe];

            for (int i = 0; i < noe; i++)
            {
                Console.WriteLine("Enter No of Working days for Employee:");
                nod = int.Parse(Console.ReadLine());
                employee[i] = new string[nod];
                for (int j = 0; j < nod; j++)
                {
                    Console.WriteLine($"Enter Salary for Day {j + 1} for Employee {i + 1}:");
                    employee[i][j] = Console.ReadLine();
                    employeeSalaries[i] += int.Parse(employee[i][j]);
                    total += int.Parse(employee[i][j]);
                }
            }

            Console.WriteLine("\nEmployee Salaries:");

            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine($"Employee {i + 1} Salaries:");
                for (int j = 0; j < employee[i].Length; j++)
                {
                    Console.WriteLine($"Day {j + 1}: {employee[i][j]}");
                }
                Console.WriteLine("Total Salary: " + employeeSalaries[i]);
                Console.WriteLine();
            }

            Console.WriteLine("Total Salary of all Employees: " + total);
            Console.ReadKey();
        }
        
    }
    
}
