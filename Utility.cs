using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal static class Utility
    {
        #region SumAreaV01
        public static double SumAreas(Rectangle[] rectangles, Square[] squares, Triangle[] triangles)
        {
            double sum = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                sum += rectangles[i].CAreaV2();
            }
            for (int i = 0; i < squares.Length; i++)
            {
                sum += squares[i].CAreaV2();
            }
            for (int i = 0; i < triangles.Length; i++)
            {
                sum += triangles[i].CAreaV2();
            }
            return sum;
        }
        #endregion
        #region SumAreasV02
        public static double SumAreas2(GeoShape[] geoShapes)
        {
            double sum = 0;
            foreach (GeoShape shape in geoShapes)
            {
                sum += shape.CAreaV2();
            }
            return sum;
        }
        #endregion
        public static void Swap(int left,int right)
        {
            int temp;
            temp = left;
            left = right;
            right = temp;

        }
        public static void SwapRef(ref int left,ref int right)
        {
            int temp;
            temp = left;
            left = right;
            right = temp;
        }
        public static void Add(int x,int y,ref int result)
        {
            result = x + y;
        }
        public static void AddV02(int x,int y,out int result) //out keyword helps so i do not need to initialize a value or allocate in memory
        {
            result = x + y;
        }
    }
}
