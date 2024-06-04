using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp.ExtensaoLista;

public class ClienteComparavel : IEqualityComparer<Cliente>
{
    public bool Equals(Cliente x, Cliente y)
    {
        if (x == null || y == null)
        {
            return false;
        }

        return x.CPF == y.CPF;
    }

    public int GetHashCode(Cliente obj)
    {
        return obj.CPF.GetHashCode();
    }
}
