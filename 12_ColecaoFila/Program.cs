using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            bool nomeCorreto;
            Queue<string> nomes = new Queue<string>();
            while (true)
            {                
                do
                {
                    Console.WriteLine("Informe o nome");
                    nome = Console.ReadLine().Trim();

                    if (nome.Length < 3)
                    {
                        Console.WriteLine("Prezado usuário,\nO nome dever conter no mínimo 3 caracteres");
                        nomeCorreto = false;
                    }
                    else if (Regex.IsMatch(nome, @"(.)\1\1"))
                    {
                        Console.WriteLine("Prezado usuário,\nO nome não pode conter 3 caracteres iguais sequenciais");
                        nomeCorreto = false;
                    }
                    else
                    {
                        nomeCorreto = true;
                    }

                } while (nomeCorreto == false);
                nomes.Enqueue(nome);

                Console.WriteLine("Deseja informar um novo nome: (S/N)");
                if( Console.ReadLine() == "N")
                    break;
            }
            int qtdeNomes = nomes.Count;
            for (int i = 1; i <= 3; i++) 
            {
                if( i <= qtdeNomes  )
                    Console.WriteLine( $"{i}º da fila: {nomes.Dequeue()}" );
            }
            if (qtdeNomes > 3)
            {
                Console.WriteLine("Pessoas na fila");
                foreach (var nomeQ in nomes)
                {
                    Console.WriteLine($" - {nome}");
                }
            }

        }
    }
}
