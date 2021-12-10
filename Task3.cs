using System;
using System.Linq;

namespace Lab4
{
    class Task3
    {
        static void Main(string[] args)
        {

            // –ешение с помощью массива
            static string ArraySolution(string InputText)
            {
                Console.WriteLine("¬ведите несколько слов через пробел:");
                char[] WordsArray = Console.ReadLine().ToCharArray();

                int Counter = 0;
                string LengthCounter = "";
                string SpaceIndex = "";

                for (int i = 0; i < WordsArray.Length; i++)
                {

                    if (WordsArray[i] != ' ')
                        Counter++;
                    else
                    {
                        SpaceIndex += i;
                        LengthCounter += i;
                        Counter = 0;
                    }

                    if (i == WordsArray.Length - 1)
                    {
                        SpaceIndex += i;
                        LengthCounter += i;
                    }
                }
                char[] WordsLength = LengthCounter.ToCharArray();
                char[] SpaceIndexArray = SpaceIndex.ToCharArray();
                return SpaceIndex;
            }

            // –ешение с помощью методов строк
            static string StringSolution(string InputText)
            {
                Console.WriteLine("¬ведите несколько слов через пробел:");
                string NewString = string.Join(" ", InputText.Split(' ').Reverse());

                return NewString;       
            }
        }
    }
}
