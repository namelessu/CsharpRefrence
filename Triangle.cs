using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Triangle: GeoShape
    {
        #region ctor
        public Triangle()
        {
            Console.WriteLine("trinagle default ctor");
        }
        public Triangle(double Height,double Base) : base(Height, Base) 
        {
            Console.WriteLine("triangle 2p ctor");
        }
        #endregion
        #region Area
        public new double CArea()
        {
            return 0.5 * base.CArea(); //for static binding
        }
        public override double CAreaV2()
        {
            //return 0.5*base.CArea();
            return 0.5 * Dim1 * Dim2;
        }
        #endregion
    }
}
