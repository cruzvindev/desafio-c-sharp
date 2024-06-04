using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafiosCSharp.Carros;

namespace DesafiosCSharp.Motores;

public class Motor
{
    public double Cilindrada { get; }
    public Carro Carro { get; private set; }

    public Motor(double cilindrada)
    {
        if (cilindrada <= 0)
        {
            throw new ArgumentException("Cilindrada deve ser maior que zero.");
        }
        Cilindrada = cilindrada;
        Carro = null;
    }

    public void SetCarro(Carro carro)
    {
        if (Carro != null)
        {
            throw new InvalidOperationException("O motor já está instalado em um carro.");
        }
        Carro = carro;
    }

    public void RemoverCarro()
    {
        Carro = null;
    }
}


