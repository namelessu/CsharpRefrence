using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    public struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Location()
        {
            X = Y = Z = 0;
        }

        public Location(int x, int y, int z)
        {
            this.X=x;
            this.Y = y;
            this.Z=z;
        }

        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }
        public static bool operator ==(Location lhs, Location rhs)
        {
            return lhs.X == rhs.X && lhs.Y == rhs.Y && lhs.Z == rhs.Z;
        }

        public static bool operator !=(Location lhs, Location rhs)
        {
            return !(lhs == rhs);
        }
    }
}
