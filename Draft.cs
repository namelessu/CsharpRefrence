using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Draft
    {
        public static void Swap(int x, int y)
        {
            int temp = x;
            x= y;
            y= temp;
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static int SearchArray(int[] param,int value)
        {
            int index = -1;
            for (int i = 0; i < param.Length; i++){
                if (param[i] == value)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static void SortArray(int[] param)
        {
            for(int i = 0; i < param.Length; i++)
            {
                for(int j = 0; j < param.Length; j++)
                {
                    if (param[j] > param[i])
                    {
                        Draft.Swap(ref param[i], ref param[j]);
                    }
                }
            }
        }
    }
}
