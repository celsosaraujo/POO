using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class TrianguloEquilatero : Forma
    {
        public double Lado { get; set; }

        public override double getArea()
        {
            return (Math.Pow(Lado, 2) * Math.Sqrt(3)) / 4;
        }

        public override string getTipo()
        {
            return "Triângulo Equilátero";
        }
    }
}
