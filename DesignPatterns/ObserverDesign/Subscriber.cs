using System;

namespace DesignPatterns.ObserverDesign
{
    /// <summary>
    /// Classe de assinantes Assinantes
    /// </summary>
    public class Subscriber : ISubscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void Update(ISubject subject)
        {
            Console.WriteLine($"Eu {Name}, recebi notificação de {subject.Name}");
        }
    }
}