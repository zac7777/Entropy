using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Entropy_Companion
{
    internal class Core
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program start.");
            Weapon shortSword = new Weapon(2, 1, "Short Sword", "The blade most young squires start their careers with, easy to learn with room for mastery", null);
        }
    }
}
