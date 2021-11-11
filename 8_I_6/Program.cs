using System;

namespace _8_I_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторку s: ");
            string s = Console.ReadLine();
                if (s[0] != s[s.Length-1])
                {
                    Console.WriteLine("Строка не является палиндромом");
                }
                else {
                    Console.WriteLine("Строка является палиндромом");
                }
        }
    }
}
