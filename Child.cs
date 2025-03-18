using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Child : Parent
    {
        #region automatic properties
        public int Z {  get; set; }
        #endregion
        public Child()
        {
            //this.X = 0;  ///useless code as it already initialized in the parent class
            //this.Y = 0;
            this.Z = 0;
            Console.WriteLine("child default ctor");
        }
        public Child(int x,int y,int z) : base(x,y)
        {
            //this.X = x; //if i use base i won't need it
            //this.Y = y;
            this.Z = z;
            Console.WriteLine("child 2p ctor");
        }
        #region print
        public int SumXYZ()
        {
            return X + Y + Z;
        }

        #endregion

    }
}
