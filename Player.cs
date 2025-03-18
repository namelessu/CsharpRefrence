using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    // Subscriber Model
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }

        public Player()
        {
            Name = "Ahmed";
            Team = "A";
        }

        public Player(string _name, string _team)
        {
            Name = _name;
            Team = _team;
        }

        // CallBack Function 
        public void Run()
        {
            Console.WriteLine($"Player {Name} from Team {Team} is Running ....");
        }
    }
}
