using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal static class ExtensionMethods
    {
        public static int WordCount(this string param)
        {
            int count = 0;
            string[] arr = param.Split(" ");
            foreach (string item in arr)
            {
                count++;
            }
            return count;
        }
        public static int Add(this int x, int y)
        {
            return x + y;
        }

        public static void Test(this object obj)
        {

        }

        public static void WordCountG<T>(this T obj)
        {

        }
    }
}
