using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Parent
    { 
       #region data_fields
       private int x;
       private int y;

        #endregion

        #region automatic properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion
        #region manual properties
        //public int X
        //{
        //    get { return x; }
        //    set { x = value; }
        //}
        //public int Y
        //{
        //    get { return y;}
        //    set { y = value; }
        //}
        #endregion
        #region setters & getters

        //public void SetX(int x)
        //{
        //    this.x = x;

        //}
        //public void SetY(int y)
        //{
        //    this.y = y;
        //}
        //public int GetX()
        //{
        //    return x;

        //}
        //public int GetY()
        //{
        //    return y;
        //}
        #endregion
        #region ctor
        public Parent()
        {
            this.X = 0;
            this.Y = 0;
            Console.WriteLine("parent default ctor");
        }
        public Parent(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Console.WriteLine("parent 2p ctor");
        }
        #endregion
    }
}
