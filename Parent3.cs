using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Parent3
    {
        #region properties
        private protected int X
        {
            get; set;
        }
        private protected int Y
        { 
            get; set; 
        }
        #endregion
        #region ctor
        public Parent3()
        {
            X = 0;
            Y = 0;
            Console.WriteLine("parent3 default ctor");
        }
        public Parent3(int x,int y)
        {
            this.X=x;
            this.Y=y;
            Console.WriteLine("parent3 2p ctor");
        }
        #endregion
        //case of static binding/early binding when overriding methods
        public void Show()
        {

            Console.WriteLine("im  a parent");
        }
        //case of dynamic binding
        public virtual void ShowV2()
        {

            Console.WriteLine("im  a parent");
        }
    }
}
