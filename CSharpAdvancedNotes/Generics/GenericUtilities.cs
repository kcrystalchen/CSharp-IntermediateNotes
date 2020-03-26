using System;

namespace Generics
{
    // Generic version B to return the bigger number
    public class GenericUtilities<T> where T : IComparable
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
