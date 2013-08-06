using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib
{
    public interface ListInterface<T>
    {
        int IndexOf(T item);
        void Push(T item);
        void InsertAt(T item, int index);
        T Pop();
        void RemoveAt(int index);
        int Size();
    }
}
