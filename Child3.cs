using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Child3:Parent3
    {
        private protected int z { set; get; }
        #region ctor
        public Child3()
        {
            Console.WriteLine("child3 default ctor");
        }
        public Child3(int x,int y,int z) : base(x, y)
        {
            this.z = z;
            Console.WriteLine("child3 2p ctor");
        }
        #endregion
        #region show
        public new void Show()
        {

            Console.WriteLine("im  a child");
        }
        public override void ShowV2() //override is just a safety factor
        {

            Console.WriteLine("im  a child");
        }
        #endregion
    }
}
