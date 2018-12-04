using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static List<Animal> animals = new List<Animal>();
        private static readonly Random getrandom = new Random();

        static void Main(string[] args)
        {


            animals.Add(new Cat("YEET"));
            animals.Add(new Dog("TOOT"));
            animals.Add(new Bird("YAAT"));
            animals.Add(new Cat("YUUT"));

            Console.WriteLine(@"Welcome u peasant...
            Pick an animal!
            Press a key on your keyboard! (esc. ends it all)");




            ConsoleKey ck = Console.ReadKey().Key;
            while (ck != ConsoleKey.Escape)
            {
                int n = getrandom.Next(0, animals.Count - 1);
                Console.WriteLine("\nYour animal is...");
                Console.WriteLine(animals[n].Show());
                Console.WriteLine("Press ESC to quit or any key to : \n");
                ck = Console.ReadKey().Key;

            }
        }
    }
}