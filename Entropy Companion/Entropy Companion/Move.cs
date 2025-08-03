using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Move
    {
        private int cost { get; set; }
        private int proficiencyRequirement { get; set; }

        private string name { get; set; }
        private string text { get; set; }

        public Move(int Cost, int ProficiencyRequirement, string Name, string Text) 
        {
            cost = Cost;
            proficiencyRequirement = ProficiencyRequirement;
            name = Name;
            text = Text;
        }
    }
}
