using System;
using System.Collections.Generic;

namespace IteratorTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in GetSingleDigitNumbers())
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            yield return 1;
            yield return 3;
            yield return 4;
        }
    }
}
