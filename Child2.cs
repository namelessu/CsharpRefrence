using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Child2 : Parent2
    {
        #region automatic properties
        public int Z { get; set; }
        #endregion
        public Child2()
        {
            this.Z = 0;
            Console.Write("child default ctor");
        }
        public Child2(int x, int y, int z):base(x,y)
        {
            this.Z = z;
            Console.WriteLine("child 3p ctor");
        }
        #region print
        public new int  Sum()
        {
            return base.Sum()+Z;
        }

        #endregion
    }
}
