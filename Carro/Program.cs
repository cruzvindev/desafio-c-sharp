using DesafiosCSharp.Carros;
using DesafiosCSharp.Motores;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Motor motor1 = new Motor(1.6);
            Carro carro1 = new Carro("ABC-1234", "HB20 S", motor1);

            Console.WriteLine($"Placa: {carro1.Placa}");
            Console.WriteLine($"Modelo: {carro1.Modelo}");
            Console.WriteLine($"Cilindrada do motor: {carro1.Motor.Cilindrada}");
            Console.WriteLine($"Velocidade máxima: {carro1.CalcularVelocidadeMaxima()} km/h");

            Motor motor2 = new Motor(2.0);
            carro1.TrocarMotor(motor2);

            Console.WriteLine("Novo motor instalado.");
            Console.WriteLine($"Cilindrada do novo motor: {carro1.Motor.Cilindrada}");
            Console.WriteLine($"Velocidade máxima: {carro1.CalcularVelocidadeMaxima()} km/h");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
    }
}
