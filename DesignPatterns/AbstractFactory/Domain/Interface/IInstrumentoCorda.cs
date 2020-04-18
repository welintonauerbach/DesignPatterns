using System.Collections.Generic;
using DesignPatterns.AbstractFactory.Domain.Entities;

namespace DesignPatterns.AbstractFactory.Domain.Interface
{
    public interface IInstrumentoCorda
    {
        IList<Nota> ListarNotas();

        short ObterQuantidadeCordas();
    }
}