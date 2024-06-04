using DesafiosCSharp.Intervalos;
using DesafiosCSharp.ListaIntervalo;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("PROJETO LISTA INTERVALO:");
            Console.WriteLine("----------------------------------------------------");
            
            Intervalo intervaloA = new Intervalo(new DateTime(2024, 3, 10, 14, 30, 0), new DateTime(2024, 3, 25, 09, 15, 32));
            Intervalo intervaloB = new Intervalo(new DateTime(2024, 3, 12, 13, 45, 28), new DateTime(2024, 3, 23, 05, 12, 11));
            Intervalo intervaloC = new Intervalo(new DateTime(2024, 6, 22, 17, 54, 33), new DateTime(2024, 7, 25, 16, 00, 09));
            Intervalo intervaloD = new Intervalo(new DateTime(2024, 6, 28, 23, 54, 52), new DateTime(2024, 7, 25, 02, 34, 25));
            
            ListaIntervalo listaIntervalo = new ListaIntervalo();

            foreach (var intervalo in listaIntervalo.Intervalos)
            {
                Console.WriteLine($"Intervalo: {intervalo.IntervaloInicial} - {intervalo.IntervaloFinal}");
            }

            listaIntervalo.Add(intervaloA);
            listaIntervalo.Add(intervaloB);
            listaIntervalo.Add(intervaloC);
            listaIntervalo.Add(intervaloD);
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}