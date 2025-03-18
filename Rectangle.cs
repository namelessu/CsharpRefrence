using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Rectangle: GeoShape
    {
        public Rectangle()
        {
            Console.WriteLine("rectangle default ctor");
        }
        public Rectangle(double Dim1, double Dim2):base(Dim1, Dim2)
        {
            Console.WriteLine("rectangle 2p ctor");
        }
        public new double CArea()
        {
            return Dim1*Dim2;
        }
        public override double CAreaV2()
        {
            return Dim1*Dim2;
        }
    }
}
