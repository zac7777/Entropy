using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Move
    {
        public Boolean isSpell {  get; set; }

        public int cost { get; set; }
        public int proficiencyRequirement { get; set; }

        public string name { get; set; }
        public string text { get; set; }
    }
}
