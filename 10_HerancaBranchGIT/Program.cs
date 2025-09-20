using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado { Lado = 10};
            quadrado.Imprimir();

            Estrela estrela = new Estrela(5, 10, 4);
            estrela.Imprimir();
        }
    }
}
