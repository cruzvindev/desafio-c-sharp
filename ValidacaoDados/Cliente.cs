using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp.ValidacaoDados;

using System;
using System.Globalization;
using System.Linq;

public class Cliente
{
    public string? Nome { get; set; }
    public long CPF { get; set; }
    public DateTime DataNascimento { get; set; }
    public float RendaMensal { get; set; }
    public char EstadoCivil { get; set; }
    public int Dependentes { get; set; }

    public bool validaNome(string clienteNome)
    {
        if (clienteNome.Length > 5)
        {
            this.Nome = clienteNome;
            return true;
        }
        else { return false; }
    }

    public bool validaCpf(string clienteCpf)
    {
        long cpf = 0;
    
        if (clienteCpf.Length == 11)
        {
            bool cond2 = !verificaTodosDigitos(clienteCpf);
            bool cond3 = validaDigitosCpf(clienteCpf);

            if (cond2 && cond3)
            {

                if (long.TryParse(clienteCpf, out cpf))
                {
                    this.CPF = cpf;
                }
                return true;

            }
            return true;
        }
        else { return false; }
    }

    public bool verificaTodosDigitos(string clienteCpf)
    {
        // Verifica se todos os dígitos são iguais ao primeiro
        bool todosIguais = true;
        char primeiroDigito = clienteCpf[0];
        for (int i = 1; i < clienteCpf.Length; i++)
        {
            if (clienteCpf[i] != primeiroDigito)
            {
                todosIguais = false;
                break;
            }
        }
        return todosIguais;
    }

    public bool validaDigitosCpf(string clienteCpf)
    {
        int[] digitos = new int[10];
        int aux = 10;
        double primeiroDigitoSoma = 0;
        double segundoDigitoSoma = 0;
        double J = 0;
        double K = 0;

        for (int i = 0; i < 9; i++)
        {
            digitos[i] = (clienteCpf[i] - '0') * aux;
            aux--;
        }

        for (int i = 0; i < digitos.Length; i++)
        {
            primeiroDigitoSoma += digitos[i];
        }

        // Validação do primeiro dígito verificador J
        if ((primeiroDigitoSoma % 11) == 0 || (primeiroDigitoSoma % 11) == 1)
        {
            J = 0;
        }
        else if ((primeiroDigitoSoma % 11) >= 2 && (primeiroDigitoSoma % 11) <= 10)
        {
            J = 11 - (primeiroDigitoSoma % 11);
        }

        // Validação do segundo dígito verificador K
        aux = 11;
        for (int i = 0; i < 10; i++)
        {
            digitos[i] = (clienteCpf[i] - '0') * aux;
            aux--;
        }

        for (int i = 0; i < digitos.Length; i++)
        {
            segundoDigitoSoma += digitos[i];
        }

        if ((segundoDigitoSoma % 11) == 0 || (segundoDigitoSoma % 11) == 1)
        {
            K = 0;
        }
        else if ((segundoDigitoSoma % 11) >= 2 && (segundoDigitoSoma % 11) <= 10)
        {
            K = 11 - (segundoDigitoSoma % 11);
        }

        if (((clienteCpf[clienteCpf.Length - 1] - '0') == K && (clienteCpf[clienteCpf.Length - 2] - '0') == J))
        {
            return true;
        }
        else { return false; }
    }

    public bool validaData(string dataNascimento)
    {
        DateTime dataNasc;
        if (DateTime.TryParseExact(dataNascimento, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNasc))
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNasc.Year;

            // Se a data de nascimento ainda não chegou este ano, diminui a idade em 1
            if (dataNasc.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            this.DataNascimento = dataNasc;
            return idade >= 18;
        }

        return false;
    }

    public bool validaRenda(string renda)
    {
        float numeroConvertido;

        if (float.TryParse(renda, NumberStyles.Float, new CultureInfo("pt-BR"), out numeroConvertido))
        {
            this.RendaMensal = numeroConvertido;
            return numeroConvertido >= 0;
        }
        else
        {
            return false;
        }
    }

    public bool validaEstadoCivil(string estadoCivil)
    {
        char letraConvertida;
        char[] estadosPossiveis = new char[4] { 'C', 'S', 'V', 'D' };

        if (char.TryParse(estadoCivil, out letraConvertida) && estadosPossiveis.Contains(letraConvertida))
        {
            this.EstadoCivil = letraConvertida;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool validaDependentes(string quantidadeDependentes)
    {
        int numeroConvertido;

        if (int.TryParse(quantidadeDependentes, out numeroConvertido) && numeroConvertido <= 10)
        {
            this.Dependentes = numeroConvertido;
            return true;
        }
        else
        {
            return false;
        }
    }
}


