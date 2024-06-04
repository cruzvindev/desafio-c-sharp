using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp.ExtensaoLista;

public class Cliente
{
    public string CPF { get; set; }
    public string Nome { get; set; }

    public Cliente(string cpf, string nome)
    {
        CPF = cpf;
        Nome = nome;
    }
}

