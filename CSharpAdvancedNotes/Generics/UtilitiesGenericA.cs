using System;

namespace Generics
{
    // Generic version A to return the bigger number 
    public class UtilitiesGenericA 
    {
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
