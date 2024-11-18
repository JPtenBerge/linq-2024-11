using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo;

internal class GenericClass<T> where T : IComparable // generic type constraints
{
    public void Sorteer(T item)
    {
        //item.
    }
}
