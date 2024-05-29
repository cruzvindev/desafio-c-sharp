using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DesafiosCSharp.Vertices;


namespace DesafiosCSharp.Poligono
{
    public class Poligono
    {

        public List<Vertice> Vertices;
        public int QuantidadeVertices
        {
            get
            {
                return Vertices.Count;
            }
        }

        public Poligono(List<Vertice> vertices) 
        {
            if(vertices == null || vertices.Count < 3)
            {
                throw new ArgumentException("Um polígono deve ter pelo menos três vértices.");
            }

            this.Vertices = new List<Vertice>(vertices);
        }  

        public void RemoveVertice()
        {
            if(this.Vertices.Count == 3)
            {
                throw new ArgumentException("O vertíce não pode ser removido pois o polígono ficaria com menos de 3 vertíces");
            } else
            {
                this.Vertices.RemoveAt(Vertices.Count - 1);
            }
        }

        public double Perimetro()
        {
            double perimetro = 0.0;
            
            for (int i = 0; i < Vertices.Count; i++)
            {
                Vertice verticeAtual = Vertices[i];
                Vertice proximoVertice = Vertices[(i + 1) % Vertices.Count]; 
                perimetro += Vertice.Distancia(verticeAtual, proximoVertice);
            }
            return perimetro;
        }

        public bool AddVertice(Vertice vertice)
        {
            foreach(Vertice v in Vertices)
            {
                if(v.X == vertice.X && v.Y == vertice.Y)
                {
                    return false;
                }
            }

            this.Vertices.Add(vertice);
            return true;
        }
    }
}
