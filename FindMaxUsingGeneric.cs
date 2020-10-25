using System;
using System.Collections.Generic;
using System.Text;

namespace MaxProblem
{
    class FindMaxUsingGeneric<T> where T:IComparable
    {     
            /// <summary>
            /// Variables to store values firstValue, secondValue, thirdValue
            /// </summary>
            private T firstValue, secondValue, thirdValue;

            /// <summary>
            /// Array of Generic type
            /// </summary>
            private T[] values;

            /// <summary>
            /// Initializes a new instance of the <see cref="FindMaxGeneric{T}"/> class.
            /// </summary>
            /// <param name="values">The values.</param>
            public FindMaxUsingGeneric(T[] values)
            {
                this.values = values;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="FindMaxUsingGeneric{T}"/> class.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            public FindMaxUsingGeneric(T firstValue, T secondValue, T thirdValue)
            {
                this.firstValue = firstValue;
                this.secondValue = secondValue;
                this.thirdValue = thirdValue;
            }

            /// <summary>
            /// Maximums the value.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            /// <returns>
            /// return Generic type
            /// </returns>
            public static T MaxValue(T firstValue, T secondValue, T thirdValue)
            {
                if ((firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0) ||
                    (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0) ||
                    (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0))
                {
                    return firstValue;
                }

                if ((secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0) ||
                    (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0) ||
                    (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0))
                {
                    return secondValue;
                }

                if ((thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0) ||
                    (thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0) ||
                    (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0))
                {
                    return thirdValue;
                }

                return firstValue;
            }

            /// <summary>
            /// Finds the maximum.
            /// </summary>
            /// <returns>
            /// return Generics type
            /// </returns>
            public T FindMax()
            {
                return MaxValue(this.firstValue, this.secondValue, this.thirdValue);
            }

            /// <summary>
            /// Sorts the specified values.
            /// </summary>
            /// <param name="values">The values.</param>
            /// <returns></returns>
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }

            /// <summary>
            /// Determines the maximum of the parameters.
            /// </summary>
            /// <param name="values">The values.</param>
            /// <returns></returns>
            public T MaxFromArray(T[] values)
            {
                //// [^1] means first element from end
                //// End index start with 1, keep this in mind
                return Sort(values)[^1];
            }
        public void PrintMax()
        {
            Console.WriteLine("Max value is: " + MaxFromArray(values));
        }
    }
}
