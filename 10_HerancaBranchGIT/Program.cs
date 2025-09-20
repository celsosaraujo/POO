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
            Trapezio trapezio = new Trapezio(baseMaior: 10, baseMenor: 5, altura: 4);
            trapezio.Imprimir();
        }
    }
}
