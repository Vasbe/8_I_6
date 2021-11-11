using System;

namespace _8_I_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторку s: ");
            string s = Console.ReadLine();
            int index = 0;
            for (int i = 0;i < s.Length; i++) {
                if (s.Substring(i, 1) != " ") {
                    index++;
                }
            }
            Console.WriteLine("Всего букв в строке: " + index);
        }
    }
}
