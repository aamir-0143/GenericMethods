using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    public class MaximumNumber<T> where T : IComparable
    {
        public T MaxMethod(T[] value)
        {
            var max = MaxValue(value);
            return max;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(T[] values)
        {
            var sorted_value = Sort(values);
            return sorted_value[sorted_value.Length - 1];
        }

        public T PrintMaxValue(T[] value)
        {
            var max = MaxValue(value);
            Console.WriteLine("Maximum value is" + max);
            return max;
        }
    }
}