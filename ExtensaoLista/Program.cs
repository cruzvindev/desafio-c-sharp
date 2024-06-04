using DesafioCSharp.ExtensaoLista;
using DesafiosCSharp.ExtensaoLista;

class Program
{
    static void Main(string[] args)
    {
        var numeros = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        numeros.RemoveRepetidos();
        Console.WriteLine("Lista de inteiros sem repetidos: " + string.Join(", ", numeros));

        var palavras = new List<string> { "uva", "banana", "maçã", "manga", "banana" };
        palavras.RemoveRepetidos();
        Console.WriteLine("Lista de strings sem repetidos: " + string.Join(", ", palavras));

        // Teste com lista de Clientes
        var clientes = new List<Cliente>
        {
            new Cliente("123.244.654-90", "Alice"),
            new Cliente("123.244.654-90", "Alice"),
            new Cliente("456.754.896-21", "Fernando"),
            new Cliente("789.198.476-92", "Pedro"),
            new Cliente("456.754.896-21", "Fernando"),
            new Cliente("234.456.678-20", "Vinicius")
        };
        clientes.RemoveRepetidos(new ClienteComparavel());
        Console.WriteLine("Lista de clientes sem elementos repetidos:");
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"CPF: {cliente.CPF}, Nome: {cliente.Nome}");
        }
    }
}
