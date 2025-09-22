using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class FormaNova : Forma
    {
        public int Altura {  get; set; }

        public override double getArea()
        {
            return Altura * Math.PI;    
        }

        public override string getTipo()
        {
            return "FORMA NOVA";
        }
    }
}
