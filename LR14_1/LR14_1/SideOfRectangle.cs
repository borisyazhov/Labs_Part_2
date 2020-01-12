using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR14_1
{
    class QuadRagle
    {
        private int A1;
        private int R;
        private int a1
        {
            get
            {
                return A1;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("false");
                }
                A1 = value;
            }
        }
        private int r
        {
            get
            {
                return R;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("i");
                }
                R = value;
            }
        }
       public  QuadRagle()
        {

        }
        public QuadRagle(int a1, int r)
        {
            A1 = a1;
            R = r;
        }
        public double FindCircleRadius(int a1, int r)
        {
            return Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(a1, 2)) / 2;
        }
        public double FindCircleRadius_ChapterTwo(int a1, int r)
        {
            return a1 / 2;
        }
       
        
    }
}
