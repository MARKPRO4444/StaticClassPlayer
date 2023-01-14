using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player.name = "Mark_44";
            Player.age = "12";
            Player.level = "1";
            Player.height = "165";

            //Player.SayName();
            Player.PrintInfo();

            Player.GetPass();

            int summ = Player.AddNumbers(44, 44);

            Console.WriteLine(summ);

            Console.ReadLine();
        }
    }

    static class Player
    {
        //fields - поля, переменные
        public static string name;
        public static string age;
        public static string level;
        public static string height;
        //methods - методы, действия

        public static void SayName()
        {
            Console.WriteLine(name);
        }
        public static void SayAge()
        {
            Console.WriteLine(age);
        }
        public static void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Level: " + level);
        }
        public static  int GetPass()
        {
            return 4444;
        }
        public static  int AddNumbers(int a, int b)
        {
            int res = a + b;

            return res;
        }
    }
}
