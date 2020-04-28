using System;
using System.Text.RegularExpressions;
using RepeatedWord.Classes;

namespace RepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test = "Test to check for repeated test words";

            Console.WriteLine(RepeatedWord(test), " - is the repeated word");
        }

        public static string RepeatedWord(string word)
        {
            string[] words = word.Split(' ');

            HashTable newTable = new HashTable();

            for(int i = 0; i < words.Length; i++)
            {
                string repeated = Regex.Replace(words[i].ToLower(), @"(\p{P})]", "");

                if (newTable.Contains(repeated))
                {
                    return newTable.Get(repeated).Value;
                }

                newTable.Add(repeated, repeated);
            }
            return "All unique words";
        }
    }
}
