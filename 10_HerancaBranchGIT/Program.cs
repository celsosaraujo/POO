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
            OctogonoRegular octogonoRegular = new OctogonoRegular { Lado = 8.9 };
            octogonoRegular.Imprimir();
            PentagonoRegular pentagono = new PentagonoRegular { lado = 10 };
            pentagono.Imprimir();
            Quadrado quadrado = new Quadrado { Lado = 10};
            Quadrado quadrado = new Quadrado { Lado = 10 };
            quadrado.Imprimir();

           

            Losango losango = new Losango { DiagonalMaior = 12, DiagonalMenor = 8 };
            losango.Imprimir();

            Estrela estrela = new Estrela(5, 10, 4);
            estrela.Imprimir();

            TrapezioIsosceles trapezioIsoceles = new TrapezioIsosceles {BaseMenor = 10, BaseMaior = 20, Altura = 50  };
            trapezioIsoceles.Imprimir();
            TrianguloEquilatero trianguloEquilatero = new TrianguloEquilatero { Lado = 15 };
            trianguloEquilatero.Imprimir();
        }
    }
}
