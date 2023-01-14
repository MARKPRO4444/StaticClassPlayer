using System;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ваш код
            string name = Console.ReadLine();
            string n = "12345";
            SpaceShip.Activate(n);
            SpaceShip.OpenDoor();
            SpaceShip.SetName(name);
            Console.WriteLine("Новое имя корабля: " + name);

            Console.ReadLine();

        }
    }

    static class SpaceShip
    {
        static bool activated = false;

        static string name = "F-2020";

        public static void Activate(string pass)
        {
            if (pass == "12345")
            {
                activated = true;
            }
        }

        public static void OpenDoor()
        {
            if (activated)
            {
                Console.WriteLine("Дверь открыта");
            }
            else
            {
                Console.WriteLine("Вы не можете открыть дверь. Активируйте корабль");
            }
        }

        public static void SetName(string userName)
        {
            if (activated)
            {
                name = userName;
            }
        }

        public static string GetName()
        {
            if (activated)
            {
                return name;
            }
            return "";
        }
    }
}