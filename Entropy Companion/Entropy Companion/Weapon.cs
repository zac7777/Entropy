using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Weapon
    {
        private int level;
        private int weight;
        
        private string name;
        private string description;

        private Move[] moves;
        private string[] properties;

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
