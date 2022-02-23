using System;

namespace ConsoleApp4
{
    class Program
    {
        static string Reverse(string args)
        {
            char[] letters = args.ToCharArray();//переписываю слово в массив символов
            char temp;
            for (int i = 0; i < (letters.Length/2); i++)//разворчиваю с обеих сторон через еще один чар
            {
                temp = letters[i];
                letters[i] = letters[letters.Length - i - 1];
                letters[letters.Length - i - 1] = temp;
            }
            return args = new string(letters); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше слово");
            string word = Console.ReadLine();
            Console.WriteLine("Перевернутое слово");
            Console.WriteLine(Reverse(word));
            Console.Read();
        }
    }
}
