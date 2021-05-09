using System;
using System.Globalization;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produtos: " + p);
            
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProduct(qte);

            Console.WriteLine();
            Console.WriteLine("Datos atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ");
            
            qte = int.Parse(Console.ReadLine());
            p.RemoveProduct(qte);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
