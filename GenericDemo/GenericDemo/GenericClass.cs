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

internal class NeverOutOfBoundsList<T> where T : struct // generic type constraints
{
    List<T> _internalList = new List<T>();

    public void Add(T item)
    {
        _internalList.Add(item);
    }

    public T this[int index]
    {
        get { return _internalList.ElementAt(index % _internalList.Count); }
        set { _internalList[index % _internalList.Count] = value; }
    }
}
