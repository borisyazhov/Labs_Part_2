using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR14
{
    class Program
    {
        public delegate double UnaryOperation(double a);
        public static double ctg(double a)
        {
            return 1 / Math.Tan(a);
        }
        public static double Atan2(double a)
        {
            return Math.Pow(Math.Atan(a), 2);
        }
        public static double f(UnaryOperation op, int x, int y, int s)
        {
                

            double sum = 0;
            for (double i = x; i < y; i += Convert.ToDouble(op(s).ToString().Substring(1,3)))
            {
                Console.WriteLine(sum);
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(f(Math.Sin, -1, 0, 2));  // variant 1
            Console.WriteLine(f(Math.Cos, -1, 0, 2));  // variant 1
            Console.WriteLine(f(Math.Cos, -1, 0, 3));  // variant 2
            Console.WriteLine(f(Math.Tan, -1, 0, 3));  // variant 2
            Console.WriteLine(f(Math.Tan, -1, 1, 4));  // variant 3
            Console.WriteLine(f(ctg, -1, 1, 4)); // variant 3
            Console.WriteLine(f(ctg, 0, 3, 5)); // variant 4
            Console.WriteLine(f(Math.Acos, 0, 3, 5)); // variant 4
            Console.WriteLine(f(Math.Acos, -3, -1, 6)); // variant 5
            Console.WriteLine(f(Math.Asin, -3, -1, 6)); // variant 5
            Console.WriteLine(f(Math.Asin, -1, 1, 3)); // variant 6
            Console.WriteLine(f(Math.Atan, -1, 1, 3)); // variant 6
            Console.WriteLine(f(Math.Atan, 0, 1, 7)); // variant 7
            Console.WriteLine(f(Atan2, 0, 1, 7)); // variant 7
            Console.WriteLine(f(Atan2, -1, 4, 1)); // variant 8
            Console.WriteLine(f(Math.Cosh, -1, 4, 1)); // variant 8
            Console.WriteLine(f(Math.Cosh, 0, 2, 1)); // variant 9
            Console.WriteLine(f(Math.Sinh, 0, 2, 1)); // variant 9
            Console.WriteLine(f(Math.Sinh, -2, 0, 1)); // variant 10
            Console.WriteLine(f(Math.Log, -2, 0, 2)); // variant 10
            Console.WriteLine(f(Math.Log, -4, 0, 1)); // variant 11
            Console.WriteLine(f(Math.Log10, -4, 0, 1)); // variant 11
            Console.WriteLine(f(Math.Log10, 0, 3, 3)); // vaiant 12
            Console.WriteLine(f(Math.Tanh, 0, 3, 3)); // variant 12
            Console.WriteLine(f(Math.Tanh, -1, 1, 5));  // variant 13
            Console.WriteLine(f(Math.Cos, -1, 1, 5)); // variant 13
            Console.WriteLine(f(Math.Tanh, -1, 0, 1)); // variant 14
            Console.WriteLine(f(Math.Sin, -1, 0, 1)); // variant 14
            Console.WriteLine(f(Math.Tanh, 0, 3, 1));   // variant 15
            Console.WriteLine(f(Math.Acos, -1, 4, 1)); // variant 16
            Console.WriteLine(f(Math.Sin, -1, 4, 1)); // variant 16
            Console.WriteLine(f(Math.Acos, 0, 2, 3)); // variant 17
            Console.WriteLine(f(Math.Cos, 0, 2, 3)); // variant 17
            Console.WriteLine(f(Math.Sinh, -2, 0, 3)); // variant 18
            Console.WriteLine(f(Math.Sin, -2, 0, 3)); // variant 18
            Console.WriteLine(f(Math.Sin, -1, 0, 2)); // variant 19
            Console.WriteLine(f(ctg, -4, 0, 3)); // variant 19
            Console.WriteLine(f(Math.Cosh, 0, 3, 2)); // variant 20
            Console.WriteLine(f(Math.Cos, 0, 3, 2)); // variant 20
            Console.WriteLine(f(Math.Tan, -1, 1, 5)); // variant 21
            Console.WriteLine(f(Math.Sin, -1, 1, 5)); // variant 21
            Console.WriteLine(f(Math.Tan, -5, 5, 3)); // variant 22
            Console.WriteLine(f(Math.Cos, -5, 5, 3)); // variant 22
            Console.WriteLine(f(Atan2, -3, 0, 2)); // variant 23
            Console.WriteLine(f(Atan2, -3, 0, 2)); // variant 23
            Console.ReadKey();
        }
    }
}
