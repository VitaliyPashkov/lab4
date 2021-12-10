using System;

namespace Lab4
{
    class IndTask1
    {
        static void Main(string[] args)
        {
            //Шифр Цезаря 
            

            static string CaesarCipher(string message, int key)
            {
                string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                alfabet += alfabet.ToLower();
                string result = ""; 
                for (int i = 0; i < message.Length; i++)
                {
                    char symbol = message[i];
                    int index = alfabet.IndexOf(symbol);
                    if (index < 0)
                    {
                        //если символ не найден, то добавляем его в неизменном виде
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


            Console.WriteLine("Введите сообщение:");
            string msg = Console.ReadLine();
            Console.WriteLine("Введите ключ:");
            int key;
            while (!int.TryParse(Console.ReadLine(), out key))
            {
                Console.WriteLine("Ошибка ввода. Введите целочисленное значение:");
            }          
            Console.WriteLine($"Зашифрованное сообщение: {Code(msg, key)}");
            Console.WriteLine($"Расшифрованное сообщение: {DeCode(msg, key)}");



        }
    }
}
