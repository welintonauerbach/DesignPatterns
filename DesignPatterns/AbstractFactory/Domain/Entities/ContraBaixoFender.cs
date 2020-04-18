using DesignPatterns.AbstractFactory.Domain.Entities.Base;

namespace DesignPatterns.AbstractFactory.Domain.Entities
{
    public sealed class ContraBaixoFender : ContraBaixo
    {
        public ContraBaixoFender() : base("Fender", 4)
        {
        }
    }
}
