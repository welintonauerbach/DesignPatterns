using DesignPatterns.FactoryMethod.Domain;
using DesignPatterns.FactoryMethod.Domain.Base;

namespace DesignPatterns.FactoryMethod.Manager.Processors.Interfaces
{
    public interface ITransactionProcessor
    {
        TransactionInfo Authorize(TransactionBase transaction);
    }
}