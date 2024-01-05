using System.Globalization;

namespace Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vetor = csvEmployee.Split(',');
            Name = vetor[0];
            Salary = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
