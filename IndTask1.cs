using System;

namespace Lab4
{
    class IndTask1
    {
        static void Main(string[] args)
        {
            //���� ������ 
            

            static string CaesarCipher(string message, int key)
            {
                string alfabet = "�����Ũ��������������������������";
                alfabet += alfabet.ToLower();
                string result = ""; 
                for (int i = 0; i < message.Length; i++)
                {
                    char symbol = message[i];
                    int index = alfabet.IndexOf(symbol);
                    if (index < 0)
                    {
                        //���� ������ �� ������, �� ��������� ��� � ���������� ����
                        result += symbol.ToString();
                    }
                    else
                    {
                        int codeIndex = (alfabet.Length + index + key) % alfabet.Length;
                        result += alfabet[codeIndex];
                    }
                }

                return result;
            }

            static string Code(string message, int key)
            {
                return CaesarCipher(message, key);
            }
            static string DeCode(string message, int key)
            {
                return CaesarCipher(message, -key);
            }


            Console.WriteLine("������� ���������:");
            string msg = Console.ReadLine();
            Console.WriteLine("������� ����:");
            int key;
            while (!int.TryParse(Console.ReadLine(), out key))
            {
                Console.WriteLine("������ �����. ������� ������������� ��������:");
            }          
            Console.WriteLine($"������������� ���������: {Code(msg, key)}");
            Console.WriteLine($"�������������� ���������: {DeCode(msg, key)}");



        }
    }
}
