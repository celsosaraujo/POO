using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class SetorCircular : Forma
    {
        public double Raio { get; set; }
        public double Angulo { get; set; } // em graus

        public override double getArea()
        {
            return (Angulo * Math.PI * Math.Pow(Raio, 2)) / 360;
        }

        public override string getTipo()
        {
            return "SETOR CIRCULAR";
        }
    }
}
