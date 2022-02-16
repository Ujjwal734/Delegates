using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Calculation(int num1, int num2);
    public class DelegateSingle
    {
        public static void Addition(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition : "+ result);
        }
        public static void Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Subtraction : " + result);
        }
        public static void Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Multiplication : " + result);
        }
        public static void Division(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine("Division : " + result);
        }
    }
}
