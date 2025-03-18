using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    class Trial<T> where T : IComparable, INumber<T>
    {
        public Trial()
        {
            // valid statement foe Any T before knowing Data Type 
            // 1 - Declaration
            T x;
            T y;

            //2- initiate 
            //x = 0 ;  /// Error   //// still unknown DT
            x = default;
            y = default;

            //3- assignment operator
            x = y;

            //4- return type from fun 
            T MyFun() { T z = default; return z; }
            //5- System .Object 
            object o1 = x;

            // 6,7,8,9 All system.Object Methods
            string str = x.ToString();
            if (x.Equals(o1)) { }
            var a = x.GetHashCode();
            var b = x.GetType();

            // if class implemnt IComparable
            // if(x.CompareTo(y) == 0){};

            //where T : class
            // x= null; 
            // if (x == y)  

            //where T : struct
            // x= null;    XXXXX
            // if (x == y)   XXXX

            /// Not Valid AT ALL
            /// z = x+y
            /// x == y
            /// y = null
            /// x =0 ;
        }

        public static T Add(T x, T y)
        {
            return x + y;
        }

        public static void Swap<T>(ref T left, ref T right)
        {
            T temp = left;
            left = right;
            right = temp;
        }

        public static int SearchArray(T[] param, T value)
        {
            int index = -1;
            for (int i = 0; i < param.Length; i++)
            {
                if (param[i] == value)
                {
                    index = i;
                }
            }
            return index;
        }

        public static void SortArray(T[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                for (int j = 0; j < param.Length; j++)
                {
                    if (param[j] > param[i])
                    {
                        Trial<T>.Swap(ref param[i], ref param[j]);
                    }
                }
            }
        }
    }
}
