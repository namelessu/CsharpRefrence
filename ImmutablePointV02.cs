using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class ImmutablePointV02
    {
        // init : to initiate object with specific values for first time ONLY with declaration
        public int X { get; init; }
        public int Y { get; init; }

        public ImmutablePointV02()
        {
            X = 0;
            Y = 0;
        }

        public ImmutablePointV02(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
    }
}
