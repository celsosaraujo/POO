using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class HeptagonoRegular : Forma
    {
        public int Lado {get;set;}

        public override double getArea()
        {
           return (7 * Math.Pow(Lado,2)) / (4 * Math.PI / 7);
        }
        public override string getTipo()
        {
            return "HeptagonoRegular";
        }





    }
}
