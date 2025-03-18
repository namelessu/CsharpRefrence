using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class ImmutablePointV01
    {
        public int X { get; }
        public int Y { get; }

        public ImmutablePointV01(int _x, int _y) { X = _x; Y = _y; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}
