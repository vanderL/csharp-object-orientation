using System.Globalization;

namespace App1
{
    class Funcionario
    {
        public string Name;
        public double Salary;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salary - Imposto;
        }
        
        public void AumentarSalario(double porcentagem)
        {
            Salary = Salary + (Salary * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Name
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
