using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class Quadrado : Forma
    {
        public int Lado { get; set; }

        public override double getArea()
        {
           return Lado*Lado;
        }

        public override string getTipo()
        {
            return "QUADRADO";
        }
    }
}
