using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCSharp.Armstrong
{
    public static class Armstrong
    {

        public static bool IsArmstrong(this int numero)
        {
            int[] numeroArray = numero.ToString().Select(digito => int.Parse(digito.ToString())).ToArray();
            int soma  = 0;
            int numeroDigitos = numeroArray.Length; 

            foreach(int digito in numeroArray)
            {
                soma += (int)Math.Pow(digito, numeroDigitos);
            }

            return soma == numero;
        }
    }
}
