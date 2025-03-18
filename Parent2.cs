using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Parent2
    {
        #region automatic properties
        public int X { get; set; }
        private protected int Y { get; set; }
        #endregion
        #region ctor
        public Parent2()
        {
            this.X = 0;
            this.Y = 0;
            Console.WriteLine("parent default ctor");
        }
        public Parent2(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Console.WriteLine("parent 2p ctor");
        }
        public int Sum()
        {
            return this.X + this.Y;
        }
        #endregion
    }
}
