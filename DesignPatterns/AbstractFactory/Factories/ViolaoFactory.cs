using System;
using DesignPatterns.AbstractFactory.Domain.Base;
using DesignPatterns.AbstractFactory.Domain.Entities;
using DesignPatterns.AbstractFactory.Domain.ValueObj;
using DesignPatterns.AbstractFactory.Factories.FactoryMethod;

namespace DesignPatterns.AbstractFactory.Factories
{
    public sealed class ViolaoFactory : IInstrumentoFactoryMethod
    {
        public InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType)
        {
            var violaoType = (ViolaoType)instrumentoFactoryType;

            switch (violaoType)
            {
                case ViolaoType.Takamine1ER4:
                {
                    return new ViolaoTakamine1ER4();
                }

                case ViolaoType.TakamineStudio:
                {
                    return new ViolaoTakamineStudio();
                }

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}