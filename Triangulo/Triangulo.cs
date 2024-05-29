using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafiosCSharp.Vertices;

namespace DesafiosCSharp.Triangulo
{
    public class Triangulo
    {
        public Vertice verticeA { get; set; }
        public Vertice verticeB { get; set; }
        public Vertice verticeC { get; set; }

        public double Perimetro
        {
            get
            {
                double lado1 = Vertice.Distancia(verticeA, verticeB);
                double lado2 = Vertice.Distancia(verticeB, verticeC);
                double lado3 = Vertice.Distancia(verticeC, verticeA);

                return lado1 + lado2 + lado3;
            }
        }

        public TipoTriangulo Tipo
        {
            get
            {
                double lado1 = Vertice.Distancia(verticeA, verticeB);
                double lado2 = Vertice.Distancia(verticeB, verticeC);
                double lado3 = Vertice.Distancia(verticeC, verticeA);

                if (lado1 == lado2 && lado2 == lado3)
                {
                    return TipoTriangulo.Equilatero;
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    return TipoTriangulo.Isosceles;
                }
                else
                {
                    return TipoTriangulo.Escaleno;
                }
            }
        }

        public double Area
        {
            get
            {
                double S = this.Perimetro / 2;
                double lado1 = Vertice.Distancia(verticeA, verticeB);
                double lado2 = Vertice.Distancia(verticeB, verticeC);
                double lado3 = Vertice.Distancia(verticeC, verticeA);

                return Math.Sqrt(S * (S - lado1) * (S - lado2) * (S - lado3));
            }
        }

        public Triangulo(Vertice v1, Vertice v2, Vertice v3) {

            if (VerificaTriangulo(v1, v2, v3))
            {
                this.verticeA = v1;
                this.verticeB = v2;
                this.verticeC = v3;
            }
            else
            {
                throw new Exception("Não forma triângulo");
            }

        }

        public bool VerificaTriangulo(Vertice v1, Vertice v2, Vertice v3)
        {
            double area = Math.Abs((v1.X * (v2.Y - v3.Y) + v2.X * (v3.Y - v1.Y) + v3.X * (v1.Y - v2.Y)) / 2.0);
            return area > 0;
        }
    }
}
