using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Ammunition : Item
    {
        public string damage {  get; set; }

        public int accuracy { get; set; }
        public int critical { get; set; }
    }
}
