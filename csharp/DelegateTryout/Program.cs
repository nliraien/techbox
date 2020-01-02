using System;
using System.Collections.Generic;

namespace DelegateTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            DTryout dt = new DTryout();
            dt.DoSomething();
        }
    }

    public class DTryout
    {
        public delegate int Comparison<in T>(T left, T right);

        private int CompareLength(string left, string right)
        {
            if (left.Length < right.Length)
            {
                return -1;
            }
            else if (left.Length == right.Length)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private int CompareLenthRev(string left, string right)
        {
            if (left.Length < right.Length)
            {
                return 1;
            }
            else if (left.Length == right.Length)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        private List<T> MySort<T>(List<T> sourceList, Comparison<T> comparer)
        {
            for (int i = 0; i < sourceList.Count; i++)
            {
                for (int j = i + 1; j < sourceList.Count; j++)
                {
                    if (comparer(sourceList[i], sourceList[j]) == 1)
                    {
                        var temp = sourceList[j];
                        sourceList[j] = sourceList[i];
                        sourceList[i] = temp;
                    }
                }
            }

            return sourceList;
        }

        public void DoSomething()
        {
            Comparison<string> comparer = CompareLength;
            Comparison<string> comp2 = CompareLenthRev;
            
            List<string> strList = new List<string>()
            {
                "this",
                "on",
                "a",
                "something",
                "yes"
            };

            foreach (var s in strList)
            {
                Console.WriteLine(s);
            }

            var ret = MySort(strList, comparer);

            foreach (var s in ret)
            {
                Console.WriteLine(s);
            }

            var ret2 = MySort(strList, comp2);

            foreach (var s in ret)
            {
                Console.WriteLine(s);
            }
        }
    }
}
