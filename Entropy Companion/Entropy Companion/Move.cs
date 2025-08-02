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

        private string name;
        private string text;

        public Move(int Cost, string Name, string Text) 
        {
            cost = Cost;
            name = Name;
            text = Text;
        }

        public void setCost(int Cost)
        {
            this.cost = Cost;
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
