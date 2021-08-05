using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lines =
                File.ReadAllLines(@"C:\Users\deadr\Desktop\CodelexC#Git\Collections\WordCount\lear.txt");

            Console.WriteLine("Lines = " + lines.Length);
            Console.WriteLine("Words = " + CalcWords(lines));
            Console.WriteLine("Chars = " + CalcChars(lines));
            Console.ReadKey();
        }

        public static int CalcWords(string[] wordArr)
        {
            var wordList = new List<string>();
            foreach (var line in wordArr)
            {
                var splitLines = line.Split(' ').ToList();
                wordList.AddRange(splitLines);
            }

            for (var i = 0; i < wordList.Count; i++)
            {
                if (wordList[i] == " " || wordList[i] == "")
                {
                    wordList.Remove(wordList[i]);
                }
            }

            return wordList.Count;
        }

        public static int CalcChars(string[] stringArr)
        {
            int charCount = 0;

            foreach (var line in stringArr)
            {
                charCount += line.Length;
            }

            return charCount;
            
        }
    }
}
