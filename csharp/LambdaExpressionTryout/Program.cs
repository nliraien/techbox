using System;
using System.Linq;

namespace LambdaExpressionTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            // a lambda expression with no return value can be converted to Action delegate
            Action<string, int> exp1 = (x, y) => Console.WriteLine($"{x}: {y}");
            exp1("test", 3);

            // a lambda expression with return value can be converted to Func delegate
            Func<string, string, int> exp2 = (x, y) => x.Length + y.Length;
            Console.WriteLine(exp2("test", "one"));

            // expression lambdas can also be converted to the express tree types
            System.Linq.Expressions.Expression<Func<int, int>> exp3 = x => x * x;
            Console.WriteLine(exp3); // output is: x => (x * x)
        }
    }
}
