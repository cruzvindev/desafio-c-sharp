using DesafiosCSharp.ValidacaoDados;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DESAFIO VALIDAÇÃO DE DADOS: ");
        Console.WriteLine("-----------------------------------------------");
        Cliente cliente = new Cliente();
        
        Console.WriteLine("Olá, bem-vindo(a) ao cadastro de clientes, por favor insira seu nome: ");
        string nome = Console.ReadLine();
        while(cliente.validaNome(nome) != true)
        {
            Console.WriteLine("Ops ! Parece que você inseriu um nome com menos de 5 caracteres, insira um nome válido: ");
            nome = Console.ReadLine();
        }
        
        Console.WriteLine("Agora por favor insira os 11 dígitos do seu CPF no formato (xxxxxxxxxx):");
        string cpf = Console.ReadLine();
        while(cliente.validaCpf(cpf) != true)
        {
            Console.WriteLine("Ops ! Parece que você inseriu um CPF em um formato inválido, insira um CPF válido: ");
            cpf = Console.ReadLine();
        }
        
        Console.WriteLine("Agora por favor insira sua data de nascimento no formato(dd/MM/yyyy):");
        string dataNascimento = Console.ReadLine();
        while (cliente.validaData(dataNascimento) != true)
        {
            Console.WriteLine("Ops ! Parece que você inseriu uma data de nascimento em um formato inválido ou não tem 18 anos, insira uma data válida(formato: dd/MM/yyyy): ");
            dataNascimento = Console.ReadLine();
        }

        Console.WriteLine("Agora por favor insira sua renda mensal com duas casas decimais após a vírgula:");
        string rendaMensal = Console.ReadLine();
        while (cliente.validaRenda(rendaMensal) != true)
        {
            Console.WriteLine("Ops ! Parece que você inseriu uma renda mensal em um formato inválido: ");
            rendaMensal = Console.ReadLine();
        }

        Console.WriteLine("Agora por favor insira a sigla do seu estado civil:  C, S, V ou D (Em maiúsculo):");
        string estadoCivil = Console.ReadLine();
        while (cliente.validaEstadoCivil(estadoCivil) != true)
        {
            Console.WriteLine("Ops ! Parece que você inseriu um estado civil em um formato inválido: ");
            estadoCivil = Console.ReadLine();
        }

        Console.WriteLine("Agora por favor insira o seu número de dependentes(No máximo 10):");
        string dependentes = Console.ReadLine();
        while (cliente.validaDependentes(dependentes) != true)
        {
            Console.WriteLine("Ops ! Parece que você inseriu um número de dependentes inválido ou em um formato inválido, tente novamente: ");
            dependentes = Console.ReadLine();
        }
        
        Console.WriteLine("CLIENTE CADASTRADO COM SUCESSO !");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("INFORMAÇÕES DO CLIENTE: ");
        Console.WriteLine("Nome do cliente: " + cliente.Nome);
        Console.WriteLine("CPF do cliente: " + cliente.CPF);
        Console.WriteLine("Data de nascimento do cliente: " + cliente.DataNascimento);
        Console.WriteLine("Renda mensal do cliente: " + cliente.RendaMensal);
        Console.WriteLine("Estado civil do cliente: " + cliente.EstadoCivil);
        Console.WriteLine("Número de dependentes do cliente: " + cliente.Dependentes);
        Console.WriteLine("--------------------------------------------------------------------------");

    }
}