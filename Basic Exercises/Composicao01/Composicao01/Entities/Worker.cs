using Composicao01.Entities.Enums;
using System.Collections.Generic;

namespace Composicao01.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } //Associoacao de duas classes diferentes
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();//liSTA DE CONTRATOS

        public Worker()
        {

        }
        //Construtor
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        //ADD CONTRATOS
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContracts(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                //Daquele ano e daquele mes
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
