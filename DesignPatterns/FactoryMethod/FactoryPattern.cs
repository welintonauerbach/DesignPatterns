using System;
using DesignPatterns.FactoryMethod.Domain;
using DesignPatterns.FactoryMethod.Domain.ValueObj;
using DesignPatterns.FactoryMethod.Manager.Factory;

namespace DesignPatterns.FactoryMethod
{
    /*
     *  Factory Method
     *
     *  Define uma interface de criação de objeto, mas deixa a sua subclasse decidir qual classe deve ser instânciada
     *  É considerado um "Construtor virtual"
     */

    public static class FactoryPattern
    {
        public static void FactoryPattern01()
        {
            #region CreditCard Transaction
            
            var creditCardTransactionProcessor =
                TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.CreditCard);

            var creditCardTransaction = new CreditCardTransaction(
                1000, "Joe Satriani", "222", "1111222233334444");
            
            var creditCardTransactionInfo = creditCardTransactionProcessor.Authorize(creditCardTransaction);

            Console.WriteLine($"{creditCardTransactionInfo.Amount} | {creditCardTransactionInfo.CreateDate:g} | " +
                              $"{creditCardTransactionInfo.TransactionKey} | {creditCardTransactionInfo.TransactionStatusType}");

            #endregion

            #region Debit Transaction

            var debitTransactionProcessor =
                TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.Debit);

            var debitTransaction = new DebitTransaction(1300, "Banco Itaú");

            var debitTransactionInfo = debitTransactionProcessor.Authorize(debitTransaction);

            Console.WriteLine($"{debitTransactionInfo.Amount} | {debitTransactionInfo.CreateDate:g} | " +
                              $"{debitTransactionInfo.TransactionKey} | {debitTransactionInfo.TransactionStatusType}");

            #endregion
        }
    }
}