using DesafiosCSharp.Piramide;

try
{
    Console.WriteLine("PROJETO PIRÂMIDE:");
    Console.WriteLine("DIGITE UM NÚMERO INTEIRO:");
     int numero = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("--------------------------");
     Piramide piramide = new Piramide(numero);
     piramide.Desenha();
 }
catch (ArgumentException e)
{
     Console.WriteLine(e.Message);
}
    
