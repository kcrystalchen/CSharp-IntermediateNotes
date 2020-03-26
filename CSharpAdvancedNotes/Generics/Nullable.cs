namespace Generics
{
    public class Nullable<T> where T : struct   // constraint struct needs to be a value type
    {
        // value type can not be Null 
        private object _value;    // box the _value as an object


        public Nullable()
        {
            // default constructor
        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }

        }


        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;  // casting it, unboxing the _value from the object
            }

            return default(T);


        }
    }
}
