﻿using System.Collections.Generic;
using DesignPatterns.AbstractFactory.Domain.Base;
using DesignPatterns.AbstractFactory.Domain.ValueObj;

namespace DesignPatterns.AbstractFactory.Domain.Entities.Base
{
    public abstract class Guitarra : InstrumentoCordaBase
    {
        protected Guitarra(string modelo, short numeroCordas) : base(modelo, InstrumentoType.Guitarra, numeroCordas)
        {
        }

        public override IList<Nota> ListarNotas() => new List<Nota>
        {
            new Nota("Mi", 329.63M),
            new Nota("Lá", 440.00M),
            new Nota("Ré", 293.66M),
            new Nota("Sol", 391.99M),
            new Nota("Si", 493.88M),
            new Nota("Mi", 329.63M),
            new Nota("Dó", 261.63M)
        };
    }
}