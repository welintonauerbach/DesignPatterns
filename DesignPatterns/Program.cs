using System;
using DesignPatterns.Observer;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton;


namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Pattern Observer");
            ObserverPattern.Observer01();
            Console.WriteLine("\n\n-----------------");

            Console.WriteLine("Pattern Singleton");
            SingletonPattern.Singleton01();
            Console.WriteLine("\n\n-----------------");

            Console.WriteLine("Pattern Prototype");
            PrototypePattern.CreateCars();
            Console.WriteLine("\n\n-----------------");

            Console.ReadKey();

        }
    }
}
