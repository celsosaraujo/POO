using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HerancaBranchGIT
{
    internal class Estrela : Forma
    {
        public int Pontas { get; set; }
        public double RaioExterno { get; set; }
        public double RaioInterno { get; set; }

        public Estrela(int pontas, double raioExterno, double raioInterno)
        {
            Pontas = pontas;
            RaioExterno = raioExterno;
            RaioInterno = raioInterno;
        }

        public override string getTipo()
        {
            return $"ESTRELA {Pontas} pontas";
        }

        public override double  getArea()
        { 
            var vertices = GerarVertices(Pontas, RaioExterno, RaioInterno);
            return CalcularArea(vertices);
        }
        private List<(double x, double y)> GerarVertices(int pontas, double raioExterno, double raioInterno)
        {
            var vertices = new List<(double x, double y)>();
            double angulo = Math.PI / pontas;
            for (int i = 0; i < pontas * 2; i++)
            {
                double raio = (i % 2 == 0) ? raioExterno : raioInterno;
                double x = raio * Math.Cos(i * angulo);
                double y = raio * Math.Sin(i * angulo);
                vertices.Add((x, y));
            }
            return vertices;
        }
        private double CalcularArea(List<(double x, double y)> vertices)
        {
            double area = 0;
            int n = vertices.Count;
            for (int i = 0; i < n; i++)
            {
                var (x1, y1) = vertices[i];
                var (x2, y2) = vertices[(i + 1) % n];
                area += x1 * y2 - x2 * y1;
            }
            return Math.Abs(area) / 2.0;
        }
    }
}
