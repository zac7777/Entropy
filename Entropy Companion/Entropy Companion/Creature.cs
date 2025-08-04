using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Creature
    {
        private string name {  get; set; }
        private int Power { get; set; }
        private int Endurance { get; set; }
        private int Memory { get; set; }
        private int Reasoning { get; set; }
        private int Connection {  get; set; }

        private Move[] moveList { get; set; }
        private Bonus[] bonuses { get; set; }
    }
}
