using System;
using System.Text.RegularExpressions;
namespace Lab4
{
    class Task5
    {
        static void Main(string[] args)
        {
            static void Func1()
            {
                Console.WriteLine("¬ведите несколько слов:");
                string Text = Console.ReadLine();
                string CorrectWords = "";
                string[] words = Text.Split(' ');

                foreach (string word in words)
                {
                    if (char.IsUpper(word[0]) &&
                        char.IsDigit(word[^1]) &&
                        char.IsDigit(word[^2]))
                    {
                        CorrectWords += word + " ";
                    }
                }
                Console.WriteLine(CorrectWords.Trim());
            }

            static void Func2()
            {
                Console.WriteLine("¬ведите несколько слов:");
                string Text = Console.ReadLine();
                string[] CorrectWords = Regex.Split(Text.Trim(), "\\b[A-Z]{1}[a-zA-Z]*\\d{2}");

                foreach (string word in CorrectWords)
                {
                    Console.WriteLine(word);
                }
            }
            Func2();
            


        }
    }
}
