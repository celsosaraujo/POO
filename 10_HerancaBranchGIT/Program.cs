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
           

            Losango losango = new Losango { DiagonalMaior = 12, DiagonalMenor = 8 };
            losango.Imprimir();
        }
    }
}
