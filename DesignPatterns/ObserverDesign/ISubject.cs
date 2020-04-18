namespace DesignPatterns.ObserverDesign
{
    public interface ISubject
    {
        string Name { get; set; }

        void Subscribe(ISubscriber subscriber);
        void UnSubscribe(ISubscriber subscriber);
        void NotifySubjects();

        void ChangeName(string name);
    }
}