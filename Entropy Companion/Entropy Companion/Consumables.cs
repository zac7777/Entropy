using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Consumables
    {
        private int level { get; set; }
        private int weight { get; set; }

        private Bonus[] bonuses { get; set; }

        private Move[] moves { get; set; }
    }
}
