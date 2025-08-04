using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Creature
    {
        public string name {  get; set; }
        public int Power { get; set; }
        public int Endurance { get; set; }
        public int Memory { get; set; }
        public int Reasoning { get; set; }
        public int Connection {  get; set; }

        public Move[] moveList { get; set; }
        public Bonus[] bonuses { get; set; }
    }
}
