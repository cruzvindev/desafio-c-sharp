using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp.Intervalos
{
    public class Intervalo
    {
        public readonly DateTime IntervaloInicial;
        public readonly DateTime IntervaloFinal;
        public TimeSpan Duracao
        {
            get
            {
                return IntervaloFinal - IntervaloInicial;
            }
        }

        public Intervalo(DateTime intervaloInicial, DateTime intervaloFinal)
        {
            if(intervaloInicial > intervaloFinal)
            {
                throw new ArgumentException("O intervalo inicial não pode ser maior que o intervalo final");
            }

            this.IntervaloInicial = intervaloInicial;
            this.IntervaloFinal = intervaloFinal;

        }

        public bool TemIntersecao(Intervalo outroIntervalo)
        {
            return (this.IntervaloFinal <= outroIntervalo.IntervaloFinal && this.IntervaloFinal >= outroIntervalo.IntervaloFinal) ||
                (outroIntervalo.IntervaloInicial <= this.IntervaloFinal && outroIntervalo.IntervaloFinal >= this.IntervaloInicial);
        }

        public static bool SaoIguais(Intervalo intervaloA, Intervalo intervaloB)
        {
            return intervaloA.IntervaloInicial == intervaloB.IntervaloInicial && intervaloA.IntervaloFinal == intervaloB.IntervaloFinal;
        }
    }
}
