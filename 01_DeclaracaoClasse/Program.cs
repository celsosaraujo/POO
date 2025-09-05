using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();

            obj1.Lado = 15;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 25;
            obj2.ImprimeArea();

            Retangulo obj3 = new Retangulo();
            obj3.Largura = 15;
            obj3.Altura = 5;
            obj3.ImprimeArea();

            Circulo obj4 = new Circulo();
            obj4.Raio = 7.5;
            obj4.ImprimeArea();  
            
            Triangulo obj5 = new Triangulo();
            obj5.Altura = 25.5;
            obj5.Base = 12.75;
            obj5.ImprimeArea();

            Conta contaCelso = new Conta();
            contaCelso.Banco = 237;
            contaCelso.Agencia = "002-7";
            contaCelso.Numero = "99520-7";
            contaCelso.Saldo = 0.00;
            contaCelso.Limite = 500.00;

            contaCelso.Depositar(1050.55);
            Console.WriteLine($"Saldo Atual: {contaCelso.ConsultaSaldo()}");

            contaCelso.Sacar(200.00);
            Console.WriteLine($"Saldo Atual: {contaCelso.ConsultaSaldo()}");
                        

            Aluno alunoCelso = new Aluno();

            alunoCelso.Codigo = 1;
            alunoCelso.Nome = "Celso Serrano Araujo";
            alunoCelso.LancarNota(1, 8.6);
            alunoCelso.LancarNota(2, 9.0);
            alunoCelso.LancarNota(3, 9.5);
            alunoCelso.LancarNota(4, 10.0);

            Console.WriteLine($"Aluno {alunoCelso.Nome} {alunoCelso.Mencao()} com média de {alunoCelso.CalcularMedia():N2}");
              

        }
    }

    public class  Quadrado
    {
        public int Lado;

        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea() 
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}");
        }
    }

    public class Retangulo
    {
        public int Largura, Altura;

        public int CalculaArea()
        {    
            return Largura * Altura;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Retângulo com largura de {Largura}, altura de {Altura} possui uma área de {CalculaArea()}");
        }

    }

    public class Circulo
    {
        public double Raio;

        public double CalculaArea() 
        {
            return Math.Pow(Raio,2) * Math.PI;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio:N2} possui uma área de {CalculaArea():N2}");
        }
    }
    
    public class Triangulo
    {
        public double Base, Altura;

        public double CalculaArea() 
        {
            return Base * Altura / 2;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base:N2}, altura de {Altura:N2} possui uma área de {CalculaArea():N2}");
            
        }
    }

    public class Conta
    {
        public int Banco;
        public string Agencia;
        public string Numero;
        public double Saldo;
        public double Limite;

        public void Depositar(double valor)
        {
            //Saldo = Saldo + valor;
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo = Saldo - valor;
        }

        public double ConsultaSaldo() 
        { 
            return Saldo;
        }

    }

    public class  Aluno
    {
        public int Codigo;
        public string Nome;
        public double[] Notas = new double[4];

        public void LancarNota( int trimestre, double nota)
        {
            Notas[trimestre - 1] = nota;
        }

        public double CalcularMedia()
        {
            double media = 0;

            foreach (double nota in Notas )
            {
                media += nota;
            }
            return media/4.0;
        }

        public string Mencao()
        {
            //   if (CalcularMedia() >= 5.0)
            //      return "Aprovado";
            //  else
            //      return "Reprovado";
            return (CalcularMedia() >= 5.0)? "Aprovado" : "Reprovado";

        }

    }

}
