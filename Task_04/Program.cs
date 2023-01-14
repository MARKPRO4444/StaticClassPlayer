using System;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Тут пишем код

            string pass = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            if (pass == Town.name || num == Town.numPeople)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }

    static class Town
    {
        // Поля
        public static string name = "Райвел";
        public static int numPeople = 243;
    }
}