using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Character : Creature
    {
        public string bio {  get; set; }

        public Item[] storage {  get; set; }
        public Item[] equipment { get; set; }
    }
}
