using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class Retangulo : Forma
    {
        public int Altura { get; set; }
        public int Base { get; set; }

        public override double getArea()
        {
            return Altura*Base;
        }

        public override string getTipo()
        {
            return "Retangulo";
        }
    }
}
