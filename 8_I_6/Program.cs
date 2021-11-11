//Определить является ли строка палиндромом
using System;

namespace _8_I_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторку s: ");
            string s = Console.ReadLine();
                s = s.ToLower(); 
                int i = 0;
            int a = 0;
                int j = s.Length - 1;
            while (i != j) 
            {
                if (s[i++] != s[j--])
                {
                    a = 1;
                }
                else {
                    a = 0;
                }
            }
            if (a == 1) Console.WriteLine("Строка не является палиндромом");
            if (a == 0) Console.WriteLine("Строка является палиндромом"); 
        }
    }
}
