using System;

namespace ConsoleApp1
{
    class Program
    {
        /*
        enum Senaphore 
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }*/
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

            Console.Write("Введите возраст: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Ваше имя {name}, ваш возраст: {age}");

            Console.Write("Введите дату рождения: ");
            string birthDate = Console.ReadLine();
            Console.WriteLine($"Ваша дата рождения {birthDate}");


            Console.ReadKey();
        }
    }
}
