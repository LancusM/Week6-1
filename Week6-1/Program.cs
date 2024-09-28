using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week6_1
{
    internal class Program
    {
        //CountWords, all the early stuff is standard
        public static void CountWords(string fileName)
        {
            //File.ReadAllText makes sense
            string userText = File.ReadAllText(fileName);

            /* https://stackoverflow.com/questions/8518275/how-to-indicate-whitespaces-while-reading-from-a-txt-file
             * Helped a lot, because I didn't know how to have the program understand the words occurring.
             * What this does is creates an array of the characters, and "separates" them into "sections" based on the exxistence of a space separating them, regardless of anything else, and the 
             * StringSplitOptions.RemoveEmptyEntries makes it so that multiple spaces in a row don't count as their own words. */
            string[] strings = userText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //rest is easy, finding the amount of "sections" in the array
            int wordTotal = strings.Length;
            //displays total
            Console.WriteLine("Total word count = " + wordTotal);

        }
        static void Main(string[] args)
        {
            //User input > ReadLine > File Write > calls method > ReadLine. EZ
            Console.WriteLine("Enter some text: ");
            string userInput = Console.ReadLine();

            File.WriteAllText("userFile.txt", userInput);

            CountWords("userFile.txt");


            Console.ReadLine();

        }
    }
}
