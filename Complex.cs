using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Complex
    {
        #region Properties
        public double Real { get; set; }
        public double Img { get; set; }
        #endregion

        #region ctor
        public Complex()
        {
            Real = 0;
            Img = 0;
        }
        public Complex(int real, int img)
        {
            this.Real = real;
            this.Img = img;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"{Real}+{Img}i";
        }
        #endregion
        #region define an Add function
        //public Complex Add(Complex left)
        //{
        //    return new() { Real=this.Real+left.Real,Img=this.Img+left.Img};
        //}
        #endregion
        #region operations
        public double Magnitude(Complex C)
        {
            return Math.Sqrt(Math.Pow(C.Real, 2) + Math.Pow(C.Img, 2));
        }

        public static Complex operator +(Complex left,Complex Right)
        {
            return new Complex { Real = left.Real + Right.Real, Img = left.Img + Right.Img };
        }
        public static Complex operator ++(Complex left)
        {
            return new() { Real = left.Real + 1, Img = left.Img + 1 };
        }
        public static Complex operator --(Complex left)
        {
            return new() { Real = left.Real - 1, Img = left.Img - 1 };
        }
        public static bool operator >(Complex left,Complex right)
        {
            return left.Real > right.Real && right.Real > left.Real;
        }
        public static bool operator <(Complex left, Complex right)
        {
            return left.Real < right.Real && right.Real < left.Real;
        }
        public static bool operator ==(Complex left,Complex right)
        {
            return left.Real==right.Real && right.Img==left.Img;
        }
        public static bool operator !=(Complex left,Complex right)
        {
            return left.Real != right.Real && right.Img != left.Img;
        }
        #endregion
        public static implicit operator double(Complex left) { return left.Real;}
        public static explicit operator string(Complex left) { return left.Real.ToString();}

    }
}