using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class PlayerCharacter : Character
    {
        private string playerName {  get; set; }
        private string heroClass { get; set; }
        private string species { get; set; }
        
        private int level { get; set; }
        private int currentHP { get; set; }
        private int currentEP { get; set; }
    }
}
