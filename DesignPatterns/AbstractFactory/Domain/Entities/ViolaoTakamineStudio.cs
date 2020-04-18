using DesignPatterns.AbstractFactory.Domain.Entities.Base;

namespace DesignPatterns.AbstractFactory.Domain.Entities
{
    public sealed class ViolaoTakamineStudio : Violao
    {
        public ViolaoTakamineStudio() : base("TakamineStudio", 6)
        {
        }
    }
}
