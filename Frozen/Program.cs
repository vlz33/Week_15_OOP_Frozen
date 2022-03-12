using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Christmas
        {
            string who;
            string what;


            public Christmas(string _who, string _what)
            {
                who = _who;
                what = _what;

            }
            public string Who
            {
                get { return who; }
            }
            public string What
            {
                get { return what; }
            }


        }
        static void Main(string[] args)
        {
            List<Christmas> myChristmas = new List<Christmas>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Christmas newChristmas = new Christmas(tempArray[0], tempArray[1]);
                myChristmas.Add(newChristmas);
            }
            foreach (Christmas wishFromList in myChristmas)
            {
                Console.WriteLine($"{wishFromList.Who} wants {wishFromList.What} for Christmas.");
            }
        }
        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from Array {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Ville\Desktop\KOOL\Programmeerimine\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }

    }


}
