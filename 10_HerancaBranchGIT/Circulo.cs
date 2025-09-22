using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class Circulo : Forma
    {
        public int Raio { get; set; }

        public override string getTipo()
        {
            return "Círculo";
        }

        public override double getArea()
        {
           return Math.PI * Raio * Raio;
        }
    }
}
