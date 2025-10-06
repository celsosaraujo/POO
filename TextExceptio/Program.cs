using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextExceptio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite um número inteiro: ");
                /*string strValor = Console.ReadLine();
                if (Regex.IsMatch(strValor, @"^[-+]?\d+$"))
                {
                    int valor = int.Parse(strValor);
                    Console.WriteLine($"Valor digitado: {valor}");
                }
                else 
                {
                    Console.WriteLine("Número inválido");
                }*/
                try
                {
                    int valor = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Valor digitado: {valor}");
                    break;
                }
                catch ( ArgumentNullException ex)
                {
                    Console.WriteLine("Valor nulo é inválido!");
                }
                catch ( FormatException ex)
                {
                    Console.WriteLine("Número inválido. Digite apenas números inteiros.");
                }
                catch( OverflowException ex)
                {
                    Console.WriteLine("Número muito grande");

                }
                catch (Exception ex) { 
                    Console.WriteLine("Número inválido");
                }
            }
        }
    }
}
