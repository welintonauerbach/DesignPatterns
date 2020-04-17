using System;

namespace DesignPatterns.Observer
{
    public static class ObserverPattern
    {
        public static void Observer01()
        {
            // 
            var canal = new YoutubeChanel { Name = "Weto Auerbach" };

            var user1 = new Subscriber("Paulo");
            var user2 = new Subscriber("Maria");
            var user3 = new Subscriber("Pedro");
            var user4 = new Subscriber("Miguel");
            var user5 = new Subscriber("Clara");
            var user6 = new Subscriber("Welinton");

            canal.Subscribe(user1);
            canal.Subscribe(user2);
            canal.Subscribe(user3);
            canal.Subscribe(user4);
            canal.Subscribe(user5);
            canal.Subscribe(user6);

            // Notificação Manual
            canal.NotifySubjects();

            // Notificação implementada
            canal.ChangeName("TecniCAD");
        }
    }
}
