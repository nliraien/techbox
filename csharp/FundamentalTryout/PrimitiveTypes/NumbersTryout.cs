using System;

namespace FundamentalTryout.PrimitiveTypes
{
    public static class NumbersTryout
    {
        public static void IntTypeTryout()
        {
            IntDividedByIntIsInt();
            IntDivisionRemainder();
            IntOverflow();
            IntUnderflow();
        }

        public static void DoubleTypeTryout()
        {
            DoubleHasRoundingIssues();
            DoubleTypeBoundaryTryout();
        }

        public static void DecimalTypeTryout()
        {
            DecimalHasGreaterPrecisionThanDouble();
        }

        #region Int type

        private static void IntDividedByIntIsInt()
        {
            int a = 10;
            int b = 3;
            var c = a / b;
            Console.WriteLine($"Int divided by int is int: 10 / 3 = { c }");
        }

        private static void IntDivisionRemainder()
        {
            int a = 10;
            int b = 3;
            var c = a % b;
            Console.WriteLine($"Remainder of int division is produced by using modulo operator: 10 % 3 = { c }");
        }

        private static void IntOverflow()
        {
            int a = int.MaxValue;
            var b = a + 1;
            // Int overflow doesn't throw exception, instead it wraps around to near MinValue
            Console.WriteLine($"Int overflow: int.MaxValue + 1 = { b }");
        }

        private static void IntUnderflow()
        {
            int a = int.MinValue;
            var b = a - 1;
            // Int underflow doesn't throw exception, instead it wraps around to near MaxValue
            Console.WriteLine($"Int underflow: int.MinValue - 1 = { b }");
        }

        #endregion

        #region Double type
        private static void DoubleHasRoundingIssues()
        {
            double a = 1;
            double b = 3;
            double c = a / b;
            Console.WriteLine($"Double has rounding issues too: 1.0 / 3.0 = { c }");
        }

        private static void DoubleTypeBoundaryTryout()
        {
            Console.WriteLine($"What is double.MaxValue: { double.MaxValue }");
            Console.WriteLine($"What is double.MinValue: { double.MinValue }");
            Console.WriteLine($"What is double.MaxValue + 1.0: { double.MaxValue + 1.0 }");
            Console.WriteLine($"What is double.MaxValue + 1000.0: { double.MaxValue + 1000.0 }");
            Console.WriteLine($"What is double.MaxValue + double.MaxValue: { double.MaxValue + double.MaxValue }");
            Console.WriteLine($"What is double.MinValue * 2: { double.MinValue * 2 }");
        }
        #endregion

        #region Decimal type
        private static void DecimalHasGreaterPrecisionThanDouble()
        {
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine($"Precision of double type division 1.0 / 3.0: { a / b }");

            // The M suffix is mandatory to indicate that a constant is decimal type
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine($"Precision of decimal type division 1.0 / 3.0: { c / d}");
        }
        #endregion
    }
}