namespace DesignPatterns.ObserverDesign
{
    public interface ISubscriber
    {
        string Name { get; set; }

        void Update(ISubject subject);
    }
}