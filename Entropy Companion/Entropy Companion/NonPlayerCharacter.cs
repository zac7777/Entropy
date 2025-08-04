using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class NonPlayerCharacter : Creature
    {
        public int EP {  get; set; }
        public int HP { get; set; }
        public int AP { get; set; }
        public int dodge { get; set; }


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

        public Item[] storage { get; set; } = new Item[0];
        public Item[] equipment { get; set; } = new Item[0];
    }
}
