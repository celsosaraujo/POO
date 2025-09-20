using System;

namespace _10_HerancaBranchGIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrianguloIsosceles triangulo = new TrianguloIsosceles
            {
                Base = 10,
                Lado = 8
            };

            triangulo.Imprimir();

            Console.ReadKey();
        }
    }
}
