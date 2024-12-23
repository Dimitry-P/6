using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    //•	Задача 6: Напишите программу, которая проверяет, является ли введенная строка палиндромом.
    internal class Program
    {
        static List<char> list; 
        
        public static string word;
        static void Main(string[] args)
        {
            list = new List<char>();
            Console.WriteLine("Введите слово:");
            word = Console.ReadLine();
            
            for (int i = word.Length-1; i >= 0; i--)
            {
                char perem = word[i];
               
                list.Add(perem);
                
            }
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] != word[i])
                {
                    Console.WriteLine("Вы ввели НЕ палиндром");
                    return;
                }
            }
            Console.WriteLine("ЭТО палиндром");

            Console.ReadKey();
        }
    }
}
