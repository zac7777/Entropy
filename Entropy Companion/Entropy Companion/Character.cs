using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Character : Creature
    {
        private string bio {  get; set; }

        private Item[] storage {  get; set; }
        private Item[] equipment { get; set; }
    }
}
