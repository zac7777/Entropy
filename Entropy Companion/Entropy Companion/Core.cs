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

            Boolean end = true;

            while (end)
            {
                Console.WriteLine(  
                                    "What would you like to do? \n" +
                                    "1: Save a new creature \n" +
                                    "2: Save a new character \n" +
                                    "3: Save a new player character \n" +
                                    "4: Read out a character sheet \n" +
                                    "5: Save a new item \n" +
                                    "6: Read a saved entry \n" +
                                    "7: Delete a saved entry \n" +
                                    "8: End program");
                switch (Console.ReadLine())
                {
                    case "1":
                        break;
                    case "8":
                        end = false;
                        break;
                    default:
                        break;
                }
            }

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
