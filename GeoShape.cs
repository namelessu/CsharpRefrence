using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal abstract class GeoShape
    {
        #region Automatic Properties
        private protected double Dim1 {  get; set; }
        private protected double Dim2 { get; set; }
        #endregion
        #region Ctor
        public GeoShape()
        {
            this.Dim1 = 0;
            this.Dim2 = 0;
        }
        #endregion
        public GeoShape(double Dim1, double Dim2)
        {
            this.Dim1 = Dim1;
            this.Dim2 = Dim2;
            
        }
        public double CArea()
        {
            return 11; //for static binding it gets this value
        }
        //public virtual double CAreaV2()
        //{
        //    return Dim1 * Dim2;
        //}
        public abstract double CAreaV2();
    }
}
