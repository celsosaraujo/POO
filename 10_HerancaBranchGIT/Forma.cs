using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal abstract class Forma
    {
        public abstract string getTipo();

        public abstract double getArea();

        public void Imprimir()
        {
            Console.WriteLine($"Forma: {getTipo()} com área de: {getArea():n2}");
        }

    }
}
