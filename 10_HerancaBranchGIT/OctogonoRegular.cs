using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10_HerancaBranchGIT
{
    internal class OctogonoRegular : Forma
    {
        public double Lado { get; set; }

        public OctogonoRegular(double lado)
        {
            Lado = lado;
        }

        public override string getTipo()
        {
            return "Octógono Regular";
        }

        public override double getArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(Lado, 2);
        }


    }
}
