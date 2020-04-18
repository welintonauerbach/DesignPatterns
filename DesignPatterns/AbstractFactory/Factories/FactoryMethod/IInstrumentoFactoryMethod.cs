using System;
using DesignPatterns.AbstractFactory.Domain.Base;

namespace DesignPatterns.AbstractFactory.Factories.FactoryMethod
{
    public interface IInstrumentoFactoryMethod
    {
        InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType);
    }
}
