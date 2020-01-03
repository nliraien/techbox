using System;
using System.Linq;
using System.Linq.Expressions;

namespace ExpressionTreeTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int>> addFive = (num) => num + 5;

            if (addFive.NodeType == ExpressionType.Lambda)
            {
                var lambdaExp = (LambdaExpression)addFive;
                var parameter = lambdaExp.Parameters.First();

                Console.WriteLine(parameter.Name);
                Console.WriteLine(parameter.Type);
            }

            var one = Expression.Constant(1, typeof(int));
            var two = Expression.Constant(2, typeof(int));
            var addition = Expression.Add(one, two);
        }
    }
}
