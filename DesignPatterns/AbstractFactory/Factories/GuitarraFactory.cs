using System;
using DesignPatterns.AbstractFactory.Domain.Base;
using DesignPatterns.AbstractFactory.Domain.Entities;
using DesignPatterns.AbstractFactory.Domain.ValueObj;
using DesignPatterns.AbstractFactory.Factories.FactoryMethod;

namespace DesignPatterns.AbstractFactory.Factories
{
    public sealed class GuitarraFactory : IInstrumentoFactoryMethod
    {
        public InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType)
        {
            var guitarraType = (GuitarraType) instrumentoFactoryType;

            switch (guitarraType)
            {
                case GuitarraType.IbanezGRG250:
                {
                    return new GuitarraIbanezGRG250();
                }

                case GuitarraType.JacksonJ22:
                {
                    return new GuitarraJacksonJ22();
                }

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}