using DesafiosCSharp.Intervalos;

Intervalo intervaloA = new Intervalo(new DateTime(2024, 3, 10, 14, 30, 0), new DateTime(2024, 3, 25, 09, 15, 32));
Intervalo intervaloB = new Intervalo(new DateTime(2024, 3, 12, 13, 45, 28), new DateTime(2024, 3, 23, 05, 12, 11));
Intervalo intervaloC = new Intervalo(new DateTime(2024, 6, 26, 17, 54, 33), new DateTime(2024, 7, 25, 16, 00, 09));
Intervalo intervaloD = new Intervalo(new DateTime(2024, 6, 26, 23, 54, 52), new DateTime(2024, 7, 25, 02, 34, 25));



try
{       
    Console.WriteLine("PROJETO DO INTERVALO:");
    Console.WriteLine("Verificando se o intervalo B possui interseção com o intervalo A...");
    Console.WriteLine(intervaloB.TemIntersecao(intervaloA));
    Console.WriteLine("Verificando se os intervalos C e D são iguais...");
    Console.WriteLine(Intervalo.SaoIguais(intervaloC, intervaloD));
    Console.WriteLine("Tentando criar intervalo com intervalo inicial superior ao final...");
    Intervalo intervaloE = new Intervalo(new DateTime(2024, 3, 25), new DateTime(2024, 3, 2));
} catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}


