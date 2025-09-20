using System;
using Microsoft.SqlServer.Server;

namespace _10_HerancaBranchGIT
{
    internal class TrianguloIsosceles : Forma
    {
       
        public double Lado { get; set; }

        
        public double Base { get; set; }

        public override string getTipo()
        {
            return "Triângulo Isósceles";
        }

        public override double getArea()
        {
            // Fórmula: altura = √(lado² - (base/2)²)
            double altura = Math.Sqrt(Math.Pow(Lado, 2) - Math.Pow(Base / 2, 2));

            return (Base * altura) / 2;
        }
    }
}
