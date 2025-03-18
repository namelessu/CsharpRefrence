using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Square : GeoShape
    {
        #region properties
        public double Dim

        {
            set { Dim1 = Dim2 = value; }
            get { return Dim1; }
        }
        #endregion
        #region Ctor
        public Square()
        {
            Console.WriteLine("square default ctor");
        }
        public Square(double Dim) : base(Dim, Dim)
        {
            Console.WriteLine("square 2p ctor");
        }
        #endregion
        #region Area
        public new double CArea()
        {
            return Dim1*Dim2;
        }
        public override double CAreaV2()
        {
            return Math.Pow(Dim, 2);
        }
        #endregion
        #region Equals Override
        public override bool Equals(object? obj)
        {
            Square square = (Square)obj;
            return this.Dim == square.Dim;
        }
        #endregion
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    internal class SquareV2 : Rectangle
    {
        #region ctor
        public SquareV2()
        {
            Console.WriteLine("squarev2 Def ctor");

        }
        public SquareV2(double dim):base(dim,dim)
        {
            Console.WriteLine("squarev2 2p ctor");
        }
        #endregion

    }
}
