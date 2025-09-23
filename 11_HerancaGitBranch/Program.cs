using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_HerancaGitBranch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bradesco bancoBradesco = new Bradesco { NomeBanco = "Banco Bradesco S.A." };
            bancoBradesco.imprimirDados();

            Nubank nubank = new Nubank { NomeBanco = "NU Pagamentos S.A. – Nubank" };
            nubank.imprimirDados();


        }
    }
}
