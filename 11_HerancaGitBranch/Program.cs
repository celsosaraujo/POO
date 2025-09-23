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

            BancoDoBrasil bancoDoBrasil = new BancoDoBrasil { NomeBanco = "Banco do Brasil S.A." };
            bancoDoBrasil.imprimirDados();
        
        }
    }
}
