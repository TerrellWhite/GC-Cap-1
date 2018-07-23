using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Cap_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool going = false;
            do
            {

                string translation = "";
                Console.WriteLine("Write a line to translate");
                string input = Console.ReadLine();
                string[] tempTrans = input.Split(' ');
                Console.WriteLine(input.Substring(1, 1));
                for (int i = 0; i < tempTrans.Length; i++)
                {
                    translation += Piggy(tempTrans[i]);

                }
                Console.WriteLine(translation);
                Console.WriteLine("Would you like to go again(y/n)");
                string go = Console.ReadLine();
                if (go.ToLower() == "y")
                {
                    going = true;
                }
            } while (going);
        }
        static string Piggy(string input)
        {
            string word;
            string firstLetter = input.Substring(0, 1);
            if (firstLetter.ToLower() == "e" || firstLetter.ToLower() == "a" || firstLetter.ToLower() == "i" || firstLetter.ToLower() == "o" || firstLetter.ToLower() == "u")
            {
                word = input + "way" + " ";

                return word;
            }
            else if (input.Substring(1, 1).ToLower() != "e" && input.Substring(1, 1).ToLower() != "a" && input.Substring(1, 1).ToLower() != "i" && input.Substring(1, 1).ToLower() != "o" && input.Substring(1, 1).ToLower() != "u")
            {
                firstLetter = input.Substring(0, 2);
                word = input.Substring(2) + firstLetter + "aye" + " ";

                return word;
            }

            word = input.Substring(1) + firstLetter + "aye" + " ";

            return word;
        }
    }
}
