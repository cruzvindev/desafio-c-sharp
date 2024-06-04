using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCSharp.ExtensaoLista;

public static class ListExtensions
{
    public static void RemoveRepetidos<T>(this List<T> list, IEqualityComparer<T> comparavel = null)
    {
        if (list == null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        comparavel ??= EqualityComparer<T>.Default;
        var itensDistintos = new HashSet<T>(list, comparavel);
        list.Clear();
        list.AddRange(itensDistintos);
    }
}