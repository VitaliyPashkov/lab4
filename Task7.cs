using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab4
{
    class Task7
    {
        static void Main(string[] args)
        {
            string[] TrackArray = new string[10];

            List<string> TimeArray = new List<string>();

            List<int> SecsArray = new List<int>();


            TrackArray[0] = "1. Gentle Giant � Free Hand[6:15]";
            TrackArray[1] = "2. Supertramp � Child Of Vision [07:27]";
            TrackArray[2] = "3. Camel � Lawrence [10:46]";
            TrackArray[3] = "4. Yes � Don�t Kill The Whale [3:55]";
            TrackArray[4] = "5. 10CC � Notell Hotel [04:58]";
            TrackArray[5] = "6. Nektar � King Of Twilight [4:16]";
            TrackArray[6] = "7. The Flower Kings � Monsters & Men [21:19]";
            TrackArray[7] = "8. Focus � Le Clochard [1:59]";
            TrackArray[8] = "9. Pendragon � Fallen Dream And Angel [5:23]";
            TrackArray[9] = "10. Kaipa � Remains Of The Day (08:02)";


            Regex regex = new Regex(@"([0-5]{0,1}\d)\:([0-5]{1}\d)");

            foreach (string track in TrackArray)
            {
                MatchCollection matches = regex.Matches(track);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                        TimeArray.Add(match.Value);
                }
            }

            foreach (string time in TimeArray)
            {
                string[] TemporaryTrackTime = time.Split(":");
                int mins = int.Parse(TemporaryTrackTime[0]);
                int secs = int.Parse(TemporaryTrackTime[1]);

                SecsArray.Add(mins * 60 + secs);
            }


            static string SumTime(List<int> SecsArray)
            {
                int SecsSum = 0;
                string SumTime = "";
                for (int i = 0; i < SecsArray.Count; i++)
                {
                    SecsSum += SecsArray[i];
                }
                if (SecsSum / 60 >= 60)
                {
                    SumTime += ((int)SecsSum / 3600).ToString();
                    SumTime += ':';
                }
                SumTime += ((int)SecsSum / 60 % 60).ToString();
                SumTime += ':';
                SumTime += ((int)SecsSum % 60).ToString();

                Console.WriteLine(SumTime);
                return SumTime;
            }


            static int[] MinDifference(List<int> SecsArray)
            {
                int[] MinDifference = new int[2];
                int[] SortedSecsArray = SecsArray.OrderBy(x => x).ToArray();
                int MinDiff = SortedSecsArray[1] - SortedSecsArray[0];
                int[] TmpIndex = { 0, 1 };
                for (int i = 2; i < SecsArray.Count; i++)
                {
                    if (SortedSecsArray[i] - SortedSecsArray[i - 1] > MinDiff)
                    {
                        TmpIndex[0] = i - 1;
                        TmpIndex[1] = i;
                    }
                }

                for (int i = 0; i < SecsArray.Count; i++)
                {
                    if (SecsArray[i] == SecsArray[TmpIndex[0]])
                    {
                        MinDifference[0] = i;
                    }
                    if (SecsArray[i] == SecsArray[TmpIndex[1]])
                    {
                        MinDifference[1] = i;
                    }
                }

                return MinDifference;

            }

            Console.WriteLine("����� �������� ����� �� ������� �����:");
            SumTime(SecsArray);
            Console.WriteLine("����� �������� �� ������� �����:");
            Console.WriteLine(TrackArray[SecsArray.IndexOf(SecsArray.Min())]);
            Console.WriteLine("����� ������� �� ������� �����:");
            Console.WriteLine(TrackArray[SecsArray.IndexOf(SecsArray.Max())]);
            Console.WriteLine("���� ����� � ����������� �������� �� ������� ��������:");
            Console.WriteLine(TrackArray[MinDifference(SecsArray)[0]]+'\n'+ TrackArray[MinDifference(SecsArray)[1]]);


        }
    }
}
