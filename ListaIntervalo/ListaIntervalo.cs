using DesafiosCSharp.Intervalos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp.ListaIntervalo;

    public class ListaIntervalo
    {
        private List<Intervalo> intervalos = new List<Intervalo> { 
            new Intervalo(new DateTime(2024, 1, 10, 22, 34, 53), new DateTime(2024, 10, 28, 17, 26, 10)),
            new Intervalo(new DateTime(2024, 3, 20, 11, 11, 11), new DateTime(2024, 3, 27, 23, 58, 23)),
        };

        public IReadOnlyList<Intervalo> Intervalos
    {
        get
        {
            return intervalos.OrderBy(i => i.IntervaloInicial).ToList().AsReadOnly();
        }
    }
            

    public void Add(Intervalo novoIntervalo)
        {
            foreach (Intervalo intervalo in intervalos)
            {
                if (intervalo.TemIntersecao(novoIntervalo))
                {
                    throw new ArgumentException("O novo intervalo tem interseção com um outro intervalo");
                }
            }

        Console.WriteLine("ADICIONANDO NOVO INTERVALO NA LISTA...");
        intervalos.Add(novoIntervalo);
    }
 }

