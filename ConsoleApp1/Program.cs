using System;

namespace ConsoleApp1
{
    class Program
    {   
        enum DayOfWeek 
        {
            Monday = 1,
            Tuesday,
            Wendsday, 
            Thursday,
            Friday, 
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
             string MyName = "Ilya";
             byte MyAge = 18;
             bool Pet = true;
             int Size = 45;

             Console.WriteLine("My name is " + MyName);
             Console.WriteLine("I'm " + MyAge);
             Console.WriteLine("Do I have a pet? " + Pet);
             Console.WriteLine("My shoe size " + Size);
             Console.WriteLine("\t Привет,\n мир!");

             double result = 5 % 6;

             Console.WriteLine(result);

            Console.WriteLine("------------------------------");


           Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            //пример явного преобразования с возможной потерей данных
            Console.Write("Введите возраст: ");
            int age = (byte) int.Parse(Console.ReadLine());
            Console.WriteLine($"Ваше имя {name}, ваш возраст: {age}");

            Console.Write("Введите дату рождения: ");
            string birthDate = Console.ReadLine();
            Console.WriteLine($"Ваша дата рождения {birthDate}");

            Console.Write("Ваш любимый день недели?");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine($"Ваш любимый день это {day}");


            Console.ReadKey();
        }
    }
}
