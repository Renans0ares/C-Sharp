using Composicao01.Entities.Enums;
using System.Globalization;
using System;
using Composicao01.Entities;

namespace Composicao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior, MidLevel, Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando OO   
            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                Console.WriteLine("Enter #{i} contract data: ");

            }

        }
    }
}
