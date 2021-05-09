using System;
using System.Globalization;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aln1 = new Aluno();

            Console.Write("Nome do aluno: ");
            aln1.Name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aln1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aln1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aln1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nota Final = " + aln1.NotaFinal().ToString("f2", CultureInfo.InvariantCulture));
        
            if (aln1.Aprovado())
            {
                Console.WriteLine("Aprovado");
            } else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram: " + aln1.NotaFaltante().ToString("f2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
