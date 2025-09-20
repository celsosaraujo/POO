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

            Trapezio trapezio = new Trapezio(baseMaior: 10, baseMenor: 5, altura: 4);
            trapezio.Imprimir();


            OctogonoRegular octogonoRegular = new OctogonoRegular { Lado = 8.9 };
            octogonoRegular.Imprimir();
            PentagonoRegular pentagono = new PentagonoRegular { lado = 10 };
            pentagono.Imprimir();
            Quadrado quadrado = new Quadrado { Lado = 10};
            quadrado.Imprimir();

            Estrela estrela = new Estrela(5, 10, 4);
            estrela.Imprimir();

            TrapezioIsosceles trapezioIsoceles = new TrapezioIsosceles {BaseMenor = 10, BaseMaior = 20, Altura = 50  };
            trapezioIsoceles.Imprimir();

            Hexagonoregular hexagonoregular = new Hexagonoregular(10);
           Console.WriteLine($"Tipo: HEXÁGONO REGULAR - Área: {hexagonoregular.AreaHexagono()}");

            TrianguloEquilatero trianguloEquilatero = new TrianguloEquilatero { Lado = 15 };
            trianguloEquilatero.Imprimir();

            Circulo circulo = new Circulo { Raio = 10 };
            circulo.Imprimir();

            SetorCircular setorCircular = new SetorCircular { Raio = 5, Angulo = 90 };
            setorCircular.Imprimir();

            FormaNova formaNova = new FormaNova { Altura = 50 };
            formaNova.Imprimir();
        }
    }
}
