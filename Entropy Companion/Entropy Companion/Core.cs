using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace Entropy_Companion
{
    internal class Core
    {
        string folderPath = "C:\\Users\\zzz\\Documents\\GitHub\\Entropy\\Entropy Companion\\EntityJsons";
        static void Main(string[] args)
        {
            Core core = new Core();

            Console.WriteLine("Program start.");

            Boolean end = false;

            while (!end)
            {
                Console.WriteLine(
                                    "What would you like to do? \n" +
                                    "1: Save a new non-player character or creature \n" +
                                    "2: Save a new player character \n" +
                                    "3: Read out a character sheet \n" +
                                    "4: Save a new item \n" +
                                    "5: Read a saved entry \n" +
                                    "6: Delete a saved entry \n" +
                                    "7: End program");
                switch (Console.ReadLine())
                {
                    case "1":
                        NonPlayerCharacter newCreature = new NonPlayerCharacter();
                        Console.WriteLine("What is the name of this creature?");
                        newCreature.name = Console.ReadLine();
                        newCreature.attributes = core.takeAttributes();
                        Console.WriteLine("What is the maximum HP of this creature?");
                        newCreature.HP = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is the maximum EP of this creature?");
                        newCreature.EP = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is the AP of this creature?");
                        newCreature.AP = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is the dodge bonus of this creature?");
                        newCreature.dodge = int.Parse(Console.ReadLine());
                        newCreature.DTs = core.takeDTs();

                        Boolean doneAdding = false;
                        while(!doneAdding)
                        {
                            Console.WriteLine("Do you want to add a move? Y/N");
                            string input = Console.ReadLine();
                            if (input == "Y")
                            {
                                Move[] temp = newCreature.moveList;
                                temp.Append(core.takeMove());
                                newCreature.moveList = temp;
                            }
                            else
                            {
                                doneAdding = true;
                            }
                        }

                        doneAdding = false;
                        while (!doneAdding)
                        {
                            Console.WriteLine("Do you want to add a bonus? Y/N");
                            string input = Console.ReadLine();
                            if (input == "Y")
                            {
                                Bonus[] temp = newCreature.bonuses;
                                temp.Append(core.takeBonus());
                                newCreature.bonuses = temp;
                            }
                            else
                            {
                                doneAdding = true;
                            }
                        }

                        doneAdding = false;
                        while (!doneAdding)
                        {
                            Console.WriteLine("Do you want to add an item to their storage? Y/N");
                            string input = Console.ReadLine();
                            if (input == "Y")
                            {
                                Item[] temp = newCreature.storage;
                                temp.Append(core.findItem());
                                newCreature.storage = temp;
                            }
                            else
                            {
                                doneAdding = true;
                            }
                        }
                        File.Create(core.folderPath + "\\Character\\" + newCreature.name + ".Json");
                        core.WriteToJson<NonPlayerCharacter>(core.folderPath + "\\Character\\" + newCreature.name + ".Json", newCreature);
                        break;
                    case "7":
                        end = true;
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

        private int[] takeAttributes()
        {
            Console.WriteLine("What attributes does your creature have?\n" +
                                "Format as Pow,End,Mem,Rea,Ins,Con");
            string[] input = Console.ReadLine().Split(',');
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = int.Parse(input[i]);
            }
            return output;
        }

        private int[] takeDTs()
        {
            Console.WriteLine("What damage thresholds does your creature have?\n" +
                                "Format as Sla,Blu,Pie,Suf,Hea,Col,Sho,Ele,Men,Tox,Rot,Rad");
            string[] input = Console.ReadLine().Split(',');
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = int.Parse(input[i]);
            }
            return output;
        }

        private Move takeMove()
        {
            Move move = new Move();
            Console.WriteLine("What is this move called?");
            move.name = Console.ReadLine();
            Console.WriteLine("Is this move a spell? Y/N");
            if (Console.ReadLine() == "Y")
            {
                move.isSpell = true;
            }
            else
            {
                move.isSpell = false;
            }
            Console.WriteLine("What is the AP cost of this move?");
            move.cost = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the proficiency requirement of this move? (must be greater than 2, if less, there will be no requirement)");
            move.proficiencyRequirement = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the effect of this move?");
            move.text = Console.ReadLine();
            return move;
        }

        private Bonus takeBonus()
        {
            Bonus bonus = new Bonus();
            Console.WriteLine("What is the name of this bonus?");
            bonus.name = Console.ReadLine();
            Console.WriteLine("What is the effect of this bonus?");
            bonus.effect = Console.ReadLine();
            return bonus;
        }

        private Item findItem()
        {
            Console.WriteLine("What type of item is it?");
            string itemType = Console.ReadLine();
            Console.WriteLine("What is the name of this item?");
            string itemName = Console.ReadLine();
            return ReadFromJson<Item>(folderPath + "\\Item\\" + itemType + "\\" + itemName + ".Json");
        }
    }
}
