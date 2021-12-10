using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab4
{
    class Task4
    {
        static void Main(string[] args)
        {
            // ������� � ������� ������� �����
            static void StringSolution(string[] StringArray)
            {
                foreach (string line in StringArray)
                {
                   if (Regex.IsMatch(line, @"\.com(\,|\.|\s|$)", RegexOptions.IgnoreCase))
                    {
                        Console.WriteLine(line);
                    }
                }
            }


            // ������� � ������� ������� �����
            static void ArraySolution(string[] StringArray)
            {
                char[] separators = { ' ', '.', ',' };
                foreach (string line in StringArray)
                {
                    string LowerLine = line.ToLower();
                    for (int i = 0; i < line.Length - 3; i++)
                    {              
                        if (LowerLine[i] == '.' && 
                            LowerLine[i + 1] == 'c' && 
                            LowerLine[i + 2] == 'o' &&
                            LowerLine[i + 3] == 'm')
                        {
                            if (i + 4 != line.Length)
                            {
                                if (separators.Contains(LowerLine[i + 4]))
                                    Console.WriteLine(line);
                            }
                            else
                                Console.WriteLine(line);
                        }
                    }
                }
            }

            //������� ���������� ������������ ���-�� ��������
            static int SpaceCounter(string[] StringArray)
            {
                List<int> SpaceList = new List<int>();
                foreach (string line in StringArray)
                {
                    int SpaceCounter = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ' ')
                            SpaceCounter++;
                    }
                    SpaceList.Add(SpaceCounter);
                }

                return SpaceList.IndexOf(SpaceList.Min()) + 1;
            }

            string[] StringArray = new string[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"������� {i + 1}-� ������:");
                StringArray[i] = Console.ReadLine();
            }
            ArraySolution(StringArray);
        }
    }
}
