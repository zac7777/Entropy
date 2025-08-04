using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy_Companion
{
    internal class Weapon : Item
    {
        private int level {  get; set; }
        private int weight { get; set; }
        
        private string[] properties {  get; set; }
        private string[] handEffects { get; set; }

        private Move[] moves { get; set; }
    }
}