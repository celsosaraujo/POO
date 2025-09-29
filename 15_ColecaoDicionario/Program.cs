using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ra;
            string nome;

            Dictionary<int, string> dados = new Dictionary<int, string>(); 

            while (true)
            {
                Console.Write("Informe o RA: ");
                ra = int.Parse(Console.ReadLine());

                Console.Write("Informe o Nome: ");
                nome = Console.ReadLine();

                dados.Add(ra, nome);

                Console.Write("Deseja incluir outro aluno? (S/N) ");
                if (Console.ReadLine().ToUpper() == "N")
                    break;

            }

            foreach (var item in dados)
            {
                Console.WriteLine( $"RA: {item.Key} Nome: {item.Value}");
            }

        }
    }
}
