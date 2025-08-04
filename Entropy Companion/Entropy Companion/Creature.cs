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

        // 0: Power
        // 1: Endurance
        // 2: Memory
        // 3: Reasoning
        // 4: Insight
        // 5: Connection
        public int[] attributes { get; set; } = { 0, 0, 0, 0, 0, 0};

        public Move[] moveList { get; set; } = new Move[0];
        public Bonus[] bonuses { get; set; } = new Bonus[0];
    }
}
