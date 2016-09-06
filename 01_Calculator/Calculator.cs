using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        public static int Add(int x, int y) /* definition for ADD*/
        { return x + y;
        }
        public static int Subtract(int x, int y) /*definition for SUBTRACT*/
        {
        return x - y;
        }
        public static int Multiply(int x, int y)/* definition for MULTIPLY*/
        {
        return x * y;
        }
        public static int divide(int x, int y)/*definition for DIVIDE*/
        {
        return x / y;
        }

        public static int Sum(int[] numbers)/*definition for SUM*/
         { 
            return numbers[0] + numbers[1];   
         } 
  


        internal static int Factorial(int x1) /*definition for FACTORIAL*/
        { 
        int sum = x1;
        for (int x = x1 - 1; x > 0; x--)
        { 
        sum = sum* x;
        }      
        return sum;
        }
        internal static double Power(int p1, int p2) /*definition for POWER*/
        {
            return Math.Pow(p1, p2);
        }
    }
}
