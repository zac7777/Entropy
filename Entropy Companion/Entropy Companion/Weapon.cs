using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Weapon
    {
        public int level { get; set; }
        public int weight { get; set; }

        public string name { get; set; }
        public string description { get; set; }

        public Move[] moves { get; set; }
        public string[] properties { get; set; }

        public Weapon()
        {
            this.level = 0;
            this.weight = 0;
            this.name = string.Empty;
            this.description = string.Empty;
            this.moves = new Move[0];
            this.properties = new string[0];
        }

        public Weapon(int Level, int Weight, string Name, string Description, string[] Properties) 
        {
            level = Level;
            weight = Weight;
            name = Name;
            description = Description;
            moves = new Move[0];
            properties = Properties;
        }
    }
}
