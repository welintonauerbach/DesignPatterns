using System;
using DesignPatterns.FactoryMethod.Domain.ValueObj;
using DesignPatterns.FactoryMethod.Manager.Processors;
using DesignPatterns.FactoryMethod.Manager.Processors.Interfaces;

namespace DesignPatterns.FactoryMethod.Manager.Factory
{
    public static class TransactionProcessorFactory
    {
        public static ITransactionProcessor CreateTransactionProcessor(TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.CreditCard: return new CrediCardTransactionProcessor();
                case TransactionType.Debit: return new DebitTransactionProcessor();
                case TransactionType.PaymentSlip: return new PaymentSlipTransactionProcessor();

                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}