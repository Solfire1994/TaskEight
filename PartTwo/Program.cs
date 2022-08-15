using System;
using System.Collections.Generic;

namespace PartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            Print(GetKeysAndValues(phoneBook));  
            System.Threading.Thread.Sleep(5000);
            if (!SearchOwner(phoneBook)) Console.WriteLine("Данный номер в справочнике отсутствует");
        }

        static Dictionary<string, string> GetKeysAndValues(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Сколько человек вы хотите внести в телефонную книгу?");
            byte count = byte.Parse(Console.ReadLine());
            string key;
            string value;
            for (int i = 0; i < count; i++)
            {
                Console.Clear();
                Console.WriteLine("Введите фамилию и имя человека");
                value = Console.ReadLine();
                do
                {
                    Console.WriteLine("Ведите номер телефона, либо не вводите ничего если у данного человека больше нет номеров");
                    key = Console.ReadLine();
                    phoneBook.Add(key, value);
                } while (key != string.Empty);
                phoneBook.Remove("");
            }
            return phoneBook;
        }

        static void Print(Dictionary<string, string> phoneBook)
        {
            foreach (KeyValuePair<string, string> p in phoneBook) Console.WriteLine($"{p}");
        }

        static bool SearchOwner(Dictionary<string, string> phoneBook)
        {
            Console.Clear();
            Console.WriteLine("Введите номер телефона, собственника которого вы хотите найти");
            string key = Console.ReadLine();
            bool exists = phoneBook.TryGetValue(key, out string value);
            Console.WriteLine(value);
            return exists;
        }
    }
}
