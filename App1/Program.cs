using System;
using System.Globalization;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle();

            Console.WriteLine("Entre a largura e em seguida a altura do retângulo: ");
            a.width = double.Parse(Console.ReadLine());
            a.height = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + a.Area().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + a.Perimeter().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + a.Diagonal().ToString("f2", CultureInfo.InvariantCulture));
            
        }
    }
}
