using System.Collections.Generic;
using DesignPatterns.AbstractFactory.Domain.Entities;
using DesignPatterns.AbstractFactory.Domain.Interface;
using DesignPatterns.AbstractFactory.Domain.ValueObj;

namespace DesignPatterns.AbstractFactory.Domain.Base
{
    public abstract class InstrumentoCordaBase : IInstrumentoCorda
    {
        public InstrumentoType InstrumentoType { get; set; }
        public string Modelo { get; set; }
        private short NumeroCordas { get; set; }

        protected InstrumentoCordaBase(string modelo, InstrumentoType instrumentoType, short numeroCordas)
        {
            InstrumentoType = instrumentoType;
            NumeroCordas = numeroCordas;
            Modelo = modelo;
        }

        public abstract IList<Nota> ListarNotas();

        public short ObterQuantidadeCordas() => NumeroCordas;
    }
}