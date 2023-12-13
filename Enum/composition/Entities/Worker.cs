using System.Collections.Generic;
using composition.Entities.Enums;
namespace composition.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        // O worker possui propriedades, incluindo o departament (composição).
        // Cria uma instância do trabalhador associada a um departament.
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); 
        //O worker pode ter varios contratos, por isso uma lista. A instanciação é pra garantir que ela nao seja nula

        public Worker()
        {

        }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); // Retorna o valor do contrato
                }
            }
            return sum;
        }
        
    }
}
