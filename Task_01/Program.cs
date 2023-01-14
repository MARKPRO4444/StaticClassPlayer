using System;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Тут будет ваш сценарий

            Robot.Start();

            String name = Robot.GetName();
            Console.WriteLine(name);

            Console.WriteLine(Robot.GetBrand());

        }
    }

    static class Robot
    {
        public static void Start()
        {
            Console.WriteLine("Робот включился");
        }

        public static void Ahead()
        {
            Console.WriteLine("Робот делает шаг вперед");
        }

        public static void Down()
        {
            Console.WriteLine("Раз!");   // Робот присел
        }

        public static void Up()
        {
            Console.WriteLine("Два!");   // Робот встал
        }

        public static void AskName()
        {
            Console.WriteLine("Привет! Я - робот. Как тебя зовут?");
        }

        public static void Welcome(string name)
        {
            Console.WriteLine("Привет, " + name + "!");
        }

        public static void TurnRight()
        {
            Console.WriteLine("Робот повернулся направо");
        }

        public static void TurnLeft()
        {
            Console.WriteLine("Робот повернулся налево");
        }

        public static string GetName()
        {
            return "Алекс-2020";
        }

        public static int GetBrand()
        {
            return 7632;
        }
    }
}

