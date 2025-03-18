using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class SubChild3 : Child3
    {
        #region properties
        private protected int a { set; get; }
        #endregion
        #region ctor
        public SubChild3()
        {
            a = 0;
            Console.WriteLine("SubChild3 default ctor");
        }
        public SubChild3(int x, int y, int z, int a) : base(x, y, z)
        {
            this.a = a;
            Console.WriteLine("SubChild3 4p ctor");
        }
        #endregion

        public new void Show()
        {
            Console.WriteLine("I'm SubChild");
        }

        public override void ShowV2()
        {
            Console.WriteLine("I'm SubChild");
        }
    }
}
