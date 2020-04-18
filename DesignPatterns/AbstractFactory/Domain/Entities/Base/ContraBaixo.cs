using System.Collections.Generic;
using DesignPatterns.AbstractFactory.Domain.Base;
using DesignPatterns.AbstractFactory.Domain.ValueObj;

namespace DesignPatterns.AbstractFactory.Domain.Entities.Base
{
    public abstract class ContraBaixo : InstrumentoCordaBase
    {
        protected ContraBaixo(string modelo, short numeroCordas) : base(modelo, InstrumentoType.ContraBaixo, numeroCordas)
        {
        }

        public override IList<Nota> ListarNotas() => new List<Nota>
        {
            new Nota("Mi", 30.86M),
            new Nota("Lá", 55.00M),
            new Nota("Ré", 73.40M),
            new Nota("Sol", 98.00M)
        };
    }
}