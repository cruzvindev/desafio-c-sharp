using DesafioCSharp.Armstrong;
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("PROJETO NÚMERO ARMSTRONG: ");
        Console.WriteLine("-------------------------------------------------");

        int[] numerosTest = { 153, 9474, 123, 370, 371, 407 };

        foreach (int numero in numerosTest)
        {
            if (Armstrong.IsArmstrong(numero))
            {
                Console.WriteLine($"{numero} é um número de Armstrong");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número de Armstrong");
            }
        }

        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("USANDO EXTENSION METHODS PARA IMPRIMIR OS NÚMEROS DE ARMSTRONG DE 1 A 10.000:");

            for (int i = 1; i <= 10000; i++)
            {
                if (i.IsArmstrong())
                {
                    Console.WriteLine(i);
                }
            }
    }
}