using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class Hexagonoregular
    {
        public double Lado { get; set; }

        public Hexagonoregular(double lado)
        {
            Lado = lado;
        }

        public double AreaHexagono()
        {
            return (3.0 * Math.Sqrt(3) / 2.0) * Lado * Lado;
        }
    }
}
