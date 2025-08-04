using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace Entropy_Companion
{
    internal class Core
    {
        static void Main(string[] args)
        {
            Core core = new Core();

            Console.WriteLine("Program start.");
            string[] properties = { "Contact", "Manageable", "Martial", "Common" };
            Weapon shortSword = new Weapon(2, 1, "Short Sword", "The blade most young squires start their careers with, easy to learn with room for mastery", properties);
            FileStream newJson = File.Create(shortSword.name + ".Json");
            core.WriteToJson<Weapon>("C:\\Users\\zzz\\Documents\\GitHub\\Entropy\\Entropy Companion\\ShortSword.Json", shortSword, false);
            //Weapon swordCopy = core.ReadFromJson<Weapon>("C:\\Users\\zzz\\Documents\\GitHub\\Entropy\\Entropy Companion\\ShortSword.Json");
            //Console.WriteLine(swordCopy.level + swordCopy.weight);
            Console.WriteLine("Program end.");
        }

        private void WriteToJson<T>(string filePath, T obj, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWrite = JsonConvert.SerializeObject(obj);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        private T ReadFromJson<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
