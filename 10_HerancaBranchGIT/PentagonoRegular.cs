using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class PentagonoRegular : Forma
    {
        public int lado { get; set; }
        public override double getArea()
        {
            return (5 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 5));
        }

        public override string getTipo()
        {
            return "PENTAGONO REGULAR";
        }
    }
}
