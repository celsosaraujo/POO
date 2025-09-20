using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class Trapezio : Forma
    {
        public double BaseMaior { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
        public Trapezio(double baseMaior, double baseMenor, double altura)
        {
            BaseMaior = baseMaior;
            BaseMenor = baseMenor;
            Altura = altura;
        }
        public override string getTipo()
        {
            return "Trapézio";
        }
        public override double getArea()
        {
            return (BaseMaior + BaseMenor) * Altura / 2;
        }
    }
}
