using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.BuilderDesign;
using DesignPatterns.FactoryMethod;
using DesignPatterns.ObserverDesign;
using DesignPatterns.PrototypeDesign;
using DesignPatterns.SingletonDesign;

namespace DesignPatterns
{
    internal static class Program
    {
        /// <summary>
        /// Método Principal Main para Console
        /// </summary>
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

            Console.WriteLine("Build Design Pattern");
            BuilderDesignPattern.BuilderDesign01();
            Console.WriteLine("\n\n-----------------");

            Console.WriteLine("Factory Pattern");
            FactoryPattern.FactoryPattern01();
            Console.WriteLine("\n\n-----------------");

            Console.WriteLine("Abstract Factory Pattern");
            AbstractFactoryPattern.AbstractFactory01();
            Console.WriteLine("\n\n-----------------");

            Console.ReadKey();
        }
    }
}
