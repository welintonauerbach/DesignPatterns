using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// Classe de Sujeito que será observado
    /// </summary>
    public class YoutubeChanel : ISubject
    {
        private readonly List<ISubscriber> _subjects;

        public string Name { get; set; }
        
        public YoutubeChanel()
        {
            _subjects = new List<ISubscriber>();
            Name = "Youtube Chanel";
        }

        public void Subscribe(ISubscriber subscriber)
        {
            if (subscriber!= null)
                _subjects.Add(subscriber);
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            if (subscriber != null)
                _subjects.Remove(subscriber);
        }

        public void NotifySubjects()
        {
            _subjects.ForEach(x => x.Update(this));
        }

        public void ChangeName(string name)
        {
            Name = name;
            this.NotifySubjects();
        }
    }
}