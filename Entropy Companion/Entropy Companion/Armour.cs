using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Armour : Item
    {
        public int level { get; set; }
        public int weight { get; set; }
        public int dodge { get; set; }

        public string[] properties { get; set; }

        public Bonus[] bonuses { get; set; }

        public Move[] moves { get; set; }

        // 0: Slash
        // 1: Bludg
        // 2: Pierc
        // 3: Suff
        // 4: Heat
        // 5: Cold
        // 6: Shock
        // 7: Electric
        // 8: Mental
        // 9: Toxic
        // 10: Rot
        // 11: Radiation
        public int[] DTs { get; set; } = new int[12];
    }
}
