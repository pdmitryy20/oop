using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string ReplaceChars(string input, int position)
        {
            char[] charArray = input.ToCharArray();

            for (int i = position; i < charArray.Length; i++)
            {
                if (charArray[i] == '0')
                {
                    charArray[i] = '1';
                }
                else if (charArray[i] == '1')
                {
                    charArray[i] = '0';
                }
            }
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            string input = "010101010101";
            int postion = 2;
            string result = ReplaceChars(input, postion);
            Console.WriteLine("Результат: " + result);
        }
    }
}
