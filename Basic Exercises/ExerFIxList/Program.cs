using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExerFIxList
{
    class Program
    {
        static void Main(string[] args)
        {
                            //Quantos funcionários serãp registrados
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> lista = new List<Employee>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}:");

                //Entre com o ID do funcionario
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                //Entre com o nome do funcionário
                Console.Write("Name: ");
                string name = Console.ReadLine();

                //Entre com o Salário do funcionário
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Adicionando a lista
                lista.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

                           //Insira o id do funcionário que terá aumento de salário
            Console.Write("Enter the employee id that will have salary increase: ");
            int increase = int.Parse(Console.ReadLine());

            Employee emp = lista.Find(x => x.Id == increase);

            if(emp != null)
            {
                            //Entre com a porcentagem
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);

            }
            else
            {                       //Esse id não existe
                Console.WriteLine("This is id does not exist");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:"); //Atualização da lista de funcionários

            foreach(Employee cont in lista)
            {
                Console.WriteLine(cont);
            }



        }
    }
}
