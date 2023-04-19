using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double n1;
            Double n2;
            Double soma;
            Double area;

            Console.WriteLine("Coloque o valor da base(b) do triangulo");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque o valor da altura(h) do triangulo");
            n2 = Double.Parse(Console.ReadLine());
            soma = n1 * n2;
            area = soma / 2;
            Console.WriteLine("O valor da Área do triangulo");
            Console.WriteLine(area);
        }
    }
}
