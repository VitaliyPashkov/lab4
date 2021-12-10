using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace Lab4
{
    class Task2
    {
        static void Main(string[] args)
        {
            // –ешение с помощью массива
            static string ArraySolution(string InputText)
            {
                
                char[] TextArray = InputText.ToCharArray();
                char[] BannedSymbols = { '-', ' ', ',', 'Ц', };

                string NewString = "";
                int counter = 1;
                bool isNotBanned = false;

                for (int i = 0; i < TextArray.Length; i++)
                {
                    foreach (char element in BannedSymbols)
                    {
                        if (element == TextArray[i])
                            isNotBanned = true;
                    }
                    if (isNotBanned)
                    {
                        if (i >= 1)
                        {
                            foreach (char element in BannedSymbols)
                            {
                                if (element == TextArray[i - 1])
                                {
                                    isNotBanned = false;
                                }
                            }
                            if (isNotBanned)
                            {
                                NewString += $"({counter}){TextArray[i]}";
                                counter++;
                            }
                            else
                                NewString += TextArray[i];
                        }
                        else
                            NewString += TextArray[i];
                    }
                    else
                        NewString += TextArray[i];

                    if (i == TextArray.Length - 1)
                    {
                        if (i >= 1)
                        {
                            foreach (char element in BannedSymbols)
                            {
                                if (element == TextArray[i - 1])
                                {
                                    isNotBanned = false;
                                }
                            }
                            if (!isNotBanned)
                            {
                                NewString += $"({counter}).";
                                counter++;
                            }
                        }
                    }

                }
                NewString += '.';
                return NewString;
            }

            // –ешение с помощью методов строк
            static string StringSolution(string InputText)
            {
                int counter = 1;
                char[] BannedSymbols = {'-', ' ', ',', 'Ц'};
                string NewString = "";
                for (int i = 0; i < InputText.Length; i++)
                {

                    if ((BannedSymbols.Contains(InputText[i]) || i == InputText.Length - 1) 
                        && !BannedSymbols.Contains(InputText[i - 1]))
                    {
                        if (i != InputText.Length - 1)
                            NewString += $"({counter}){InputText[i]}";
                        else
                            NewString += $"{InputText[i]}({counter})";
                        counter++;
                    }
                    else
                        NewString += InputText[i];
                   
                }

                NewString += '.';
                Console.WriteLine(NewString);
                return NewString;
            }
            StringSolution("ƒонецк Ц прекрасный город");

        } 
    }
}


