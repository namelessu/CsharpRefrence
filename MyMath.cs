using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    public static class MyMath
    {
        static MyMath()
        {
            
        }
        public static int Add(int x, int y) { return x + y; }
        public static int Add(int x, int y,int z) { return x + y+z;}

        public static int Sub(int x, int y) { return x - y; }
        public static int Mul(int x, int y) { return x * y; }
        public static float Div(float x, float y)
        {
            if (x == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return x / y;
        }
    }
}