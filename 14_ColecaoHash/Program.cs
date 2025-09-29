using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            int valor;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Informe o {i}º valor: "  );
                valor = int.Parse( Console.ReadLine() );
                set.Add( valor );

            }
            foreach (int i in set)
            {
                Console.WriteLine($"Número: {i}" );
            }
        }
    }
}
