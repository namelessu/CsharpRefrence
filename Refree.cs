using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    // Subscriber Model
    public class Referee
    {
        public string Name { get; set; }

        public Referee()
        {
            Name = "Ali";
        }
        public Referee(string _name)
        {
            Name = _name;
        }

        // Call Back Function 
        public void Observe()
        {
            Console.WriteLine($"Referee {Name} is Observing .....");
        }
    }
}
