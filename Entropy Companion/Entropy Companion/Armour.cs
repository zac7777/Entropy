using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Armour : Item
    {
        private int level { get; set; }
        private int weight { get; set; }
        private int dodge { get; set; }

        private string[] properties { get; set; }

        private Bonus[] bonuses { get; set; }

        private Move[] moves { get; set; }

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
        private int[] DTs { get; set; } = new int[12];
    }
}
