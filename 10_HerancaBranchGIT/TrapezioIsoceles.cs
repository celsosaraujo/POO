using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    class TrapezioIsosceles : Forma
    {
        public double BaseMaior { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
       public override string getTipo()
        {
            return "TRAPÉZIO ISÓCELES";
        }

        public override double getArea()
        {
            return ((BaseMaior + BaseMenor) * Altura) / 2.0;
        }
    }
}
