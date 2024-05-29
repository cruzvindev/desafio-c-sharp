using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp.Vertices
{
    public class Vertice
    {
        public double X { get; private set; }  
        public double Y { get; private set; }     


        public Vertice(double x, double y) 
        { 
            this.X = x;
            this.Y = y;   
        }

        public static double Distancia(Vertice a, Vertice b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));  
        }

        public void Move(double a, double b)
        {
            this.X = a;
            this.Y = b;
        }

        public static bool VerificaVertices(Vertice a, Vertice b)
        {
            return a.X == b.X && a.Y == b.Y ? true : false;
        }
    }

    public enum TipoTriangulo
    {
        Equilatero,
        Isosceles,
        Escaleno
    }
}
