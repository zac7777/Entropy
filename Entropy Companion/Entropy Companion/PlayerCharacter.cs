using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class PlayerCharacter : Character
    {
        public string playerName {  get; set; }
        public string heroClass { get; set; }
        public string species { get; set; }

        public int level { get; set; }
        public int currentHP { get; set; }
        public int currentEP { get; set; }
    }
}
