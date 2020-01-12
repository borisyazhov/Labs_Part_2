using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_DelegateArray_
{
    class Program
    {

        public delegate double MyDelegate(double a);
        public static double ctg(double a)
        {
            return 1 / Math.Tan(a);
        }
        public static double Atan2(double a)
        {
            return Math.Pow(Math.Atan(a), 2);
        }
        public static double f(MyDelegate op, int x, int y, int s)
        {
            double sum = 0;
            Func<int, double> stap = c => Convert.ToDouble(op(c).ToString().Substring(1, 3));
            for (double i = x; i < y; i += stap(s))
            {
                Console.WriteLine(sum);
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
           MyDelegate[] arr = new MyDelegate[12];
            arr[0] =Math.Tan;
            arr[1] = (double x) => 1.0/ Math.Tan(x);
            arr[2] = Math.Sin;
            arr[3] = Math.Cos;
            arr[4] = Math.Sinh;
            arr[5] = Math.Cosh;
            arr[6] = Math.Log10;
            arr[7] = (double x) => Math.Pow(Math.Atan(x), 2);
            arr[8] = Math.Asin;
            arr[9] = Math.Tanh;
            arr[10] = Math.Log10;
            arr[11] = Math.Acos;
            for(int i = 1; i != 12; ++i)
            {
                Console.WriteLine(f(arr[i], -1, 1, 1));
            }
     
            Console.ReadKey();
        }
    }
}
