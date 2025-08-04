using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Weapon : Item
    {
        public int level {  get; set; }
        public int weight { get; set; }

        public string[] properties {  get; set; }
        public string[] handEffects { get; set; }

        public Move[] moves { get; set; }
    }
}