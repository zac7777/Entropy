using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Move
    {
        private int cost;
        private int proficiencyRequirement;

        private string name;
        private string text;

        public Move(int Cost, int ProficiencyRequirement, string Name, string Text) 
        {
            cost = Cost;
            proficiencyRequirement = ProficiencyRequirement;
            name = Name;
            text = Text;
        }

        public void setCost(int Cost)
        {
            this.cost = Cost;
        }

        public void setProficiencyRequirement(int ProficiencyRequirement)
        {
            this.proficiencyRequirement = ProficiencyRequirement;
        }

        public void setName(string Name)
        {
            this.name = Name;
        }

        public void setText(string Text)
        { 
            this.text = Text;
        }

        public int getCost()
        {
            return this.cost;
        }

        public int getProficiencyRequirement()
        {
            return this.proficiencyRequirement;
        }

        public string getName()
        {
            return this.name;
        }

        public string getText()
        {
            return this.text;
        }
    }
}
