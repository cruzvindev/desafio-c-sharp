using DesafiosCSharp.Motores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp.Carros;

public class Carro
{
    public string Placa { get; }
    public string Modelo { get; }
    public Motor Motor { get; private set; }

    public Carro(string placa, string modelo, Motor motor)
    {
        if (string.IsNullOrWhiteSpace(placa))
        {
            throw new ArgumentException("Placa não pode ser nula ou vazia.");
        }
        if (string.IsNullOrWhiteSpace(modelo))
        {
            throw new ArgumentException("Modelo não pode ser nulo ou vazio.");
        }
        if (motor == null)
        {
            throw new ArgumentException("Motor não pode ser nulo.");
        }
        if (motor.Carro != null)
        {
            throw new ArgumentException("O motor já está instalado em outro carro.");
        }

        Placa = placa;
        Modelo = modelo;
        Motor = motor;
        Motor.SetCarro(this);
    }

    public void TrocarMotor(Motor novoMotor)
    {
        if (novoMotor == null)
        {
            throw new ArgumentException("Novo motor não pode ser nulo.");
        }
        if (novoMotor.Carro != null)
        {
            throw new ArgumentException("O motor já está instalado em outro carro.");
        }

        Motor.RemoverCarro();
        Motor = novoMotor;
        Motor.SetCarro(this);
    }

    public double CalcularVelocidadeMaxima()
    {
        double cilindrada = Motor.Cilindrada;
        if (cilindrada <= 1.0)
        {
            return 140.0;
        }
        else if (cilindrada <= 1.6)
        {
            return 160.0;
        }
        else if (cilindrada <= 2.0)
        {
            return 180.0;
        }
        else
        {
            return 220.0;
        }
    }
}


