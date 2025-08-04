using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Ammunition : Item
    {
        private string damage {  get; set; }

        private int accuracy { get; set; }
        private int critical { get; set; }
    }
}
