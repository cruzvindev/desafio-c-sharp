using DesafiosCSharp.Intervalo;

Intervalo intervaloA = new Intervalo(new DateTime(2024, 3, 10), new DateTime(2024, 3, 25));
Intervalo intervaloB = new Intervalo(new DateTime(2024, 3, 12), new DateTime(2024, 3, 23));
Intervalo intervaloC = new Intervalo(new DateTime(2024, 6, 26), new DateTime(2024, 7, 25));
Intervalo intervaloD = new Intervalo(new DateTime(2024, 6, 26), new DateTime(2024, 7, 25));



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


