using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Point2d
    {
        protected int x;
        protected int y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public Point2d()
        {
            x = y = 0;
        }
        public Point2d(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

        #region Override Equality
        // To Check values instead Identity [HashCode]
        public override bool Equals(/*caller*/object? obj)
        {
            //// Not Effective Code        V01
            //Point2d right = (Point2d)obj; /// Worst Case of Casting 
            //return this.x == right.x && this.y == right.y;

            /////    Not effective     V02 //solved the null value system exception but not the Point3d cast or if it takes a string which give system exception
            //if (obj != null)
            //{
            //    Point2d right = (Point2d)obj; /// Worst Case of Casting 
            //    return this.x == right.x && this.y == right.y;
            //}
            //else
            //{
            //    return false;
            //}


            //////V03 //solved 2 problems one to go
            //is,as
            //is => check obj is null return true,return false if not
            //is => check obj is Point2d return true,if not return false
            //if(obj is Point2d)
            //{
            //    //as => will cast if obj is Point2d
            //    Point2d right = obj as Point2d;
            //    return this.x == right.x && this.y == right.y;
            //}
            //return false;

            #region Effective Code to handle all Cases 
            Point2d right = obj as Point2d;

            if (right == null) { return false; }

            if (object.ReferenceEquals(this, right) == true) { return true; }

            if (this.GetType() != right.GetType()) { return false;}

            return this.x == right.x && this.y == right.y;
            #endregion
        }
        #endregion
    }

    //////////////////////////////////
    class Point3d : Point2d
    {
        int z;

        public int Z { get { return z; } set { z = value; } }

        public Point3d()
        {
            z = 0;
        }
        public Point3d(int _x, int _y, int _z) : base(_x, _y)
        {
            z = _z;
        }

        public override string ToString()
        {
            return $"({x},{y},{z})";
        }

    }

}
