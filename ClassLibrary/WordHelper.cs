using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibrary
{
    public class WordHelper
    {
        private static readonly Dictionary<int, string> _words = new Dictionary<int, string>();

        public static void Startup(string filePath)
        {
            try
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    while (!file.EndOfStream)
                    {
                        var line = file.ReadLine();

                        if (file.EndOfStream)
                        {
                            break;
                        }

                        var splitLine = line.Split("	");

                        _words.Add(Convert.ToInt32(splitLine[0]), splitLine[1]);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error reading the file: ");
                Console.WriteLine(e.Message);
            }
        }

        public static string GetWord(int concatenatedRoll)
        {
            return _words[concatenatedRoll];
        }
    }
}
