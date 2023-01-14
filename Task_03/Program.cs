using System;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Тут пишем код

            Enemy.name = Console.ReadLine();

            Enemy.Print();

            Console.ReadLine();
        }
    }

    static class Enemy
    {
        // Поля
        public static string name = "Скелет";
        public static int health = 5;
        public static int level = 2;

        // Методы
        public static void Attack()
        {
            Console.WriteLine("Скелет атакует!");
        }
        public static void Print()
        {
            Console.WriteLine("Имя: " + name);
        }
    }
}