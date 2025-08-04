using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Consumable
    {
        public int level { get; set; }
        public int weight { get; set; }

        public Bonus[] bonuses { get; set; }

        public Move[] moves { get; set; }
    }
}
