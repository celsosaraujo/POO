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

            Carrefour bancoCarrefour = new Carrefour { NomeBanco = "Banco Carrefour S.A." };
            bancoCarrefour.imprimirDados();

            Original bancoOriginal = new Original { NomeBanco = "Banco Original S.A." };
            bancoOriginal.imprimirDados();

            bancoPAN bancoPAN = new bancoPAN { NomeBanco = "Banco PAN S.A." };
            bancoPAN.imprimirDados();
        }
    }
}
