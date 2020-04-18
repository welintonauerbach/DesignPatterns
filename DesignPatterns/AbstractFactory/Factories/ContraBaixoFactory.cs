using System;
using DesignPatterns.AbstractFactory.Domain.Base;
using DesignPatterns.AbstractFactory.Domain.Entities;
using DesignPatterns.AbstractFactory.Domain.ValueObj;
using DesignPatterns.AbstractFactory.Factories.FactoryMethod;

namespace DesignPatterns.AbstractFactory.Factories
{
    public sealed class ContraBaixoFactory : IInstrumentoFactoryMethod
    {
        public InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType)
        {
            var contraBaixoType = (ContraBaixoType)instrumentoFactoryType;

            switch (contraBaixoType)
            {
                case ContraBaixoType.Fender:
                {
                    return new ContraBaixoFender();
                }

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}