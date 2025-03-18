using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Adv_c__revision
{
    internal class Circle : GeoShape
    {
        #region properties
        public double Radius
        {
            set
            {
                Dim1 = Dim2 = value;
            }
            get
            {
                return Dim1;
            }
        }
        #endregion
        #region ctor
        public Circle()
        {
            Console.WriteLine("circle default ctor");
        }
        public Circle(double radius) : base(radius, radius)
        {
            Console.WriteLine("circle 2p ctor");
        }
        #endregion
        #region Area
        public new double CArea() {
            return Math.PI * Radius; //static binding
        }
        public override double CAreaV2()
        {
            return Math.PI * Math.Pow(Radius,2) ;
        }
        #endregion
    }
}