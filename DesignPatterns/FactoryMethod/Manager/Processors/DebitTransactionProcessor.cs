using DesignPatterns.FactoryMethod.Domain;
using DesignPatterns.FactoryMethod.Domain.Base;
using DesignPatterns.FactoryMethod.Manager.Processors.Base;
using DesignPatterns.FactoryMethod.Manager.Processors.Interfaces;

namespace DesignPatterns.FactoryMethod.Manager.Processors
{
    public class DebitTransactionProcessor : ProcessorBase<DebitTransaction>, ITransactionProcessor
    {
        public TransactionInfo Authorize(TransactionBase transaction)
        {
            var debitTransaction = ValidateTransactionType(transaction);

            return ProcessAuthorization(debitTransaction);
        }

        private static TransactionInfo ProcessAuthorization(DebitTransaction debitTransaction)
        {
            debitTransaction.SetStatusInProgress();

            BusinessSimulation(ref debitTransaction);

            return new TransactionInfo(debitTransaction.TransactionKey,
                debitTransaction.CreateDate, debitTransaction.Amount,
                debitTransaction.TransactionStatusType);
        }

        /// <summary>
        /// Código de simulação de autorização, apenas para fins didádicos
        /// </summary>
        /// <param name="debitTransaction">transação de débito</param>
        private static void BusinessSimulation(ref DebitTransaction debitTransaction)
        {
            // Autoriza se o valor estiver entre 1 e 5.000 reais

            if (debitTransaction.Amount >= 1
                && debitTransaction.Amount <= 5000)
            {
                debitTransaction.SetStatusAuthorized();

                return;
            }

            debitTransaction.SetStatusUnauthorized();
        }
    }
}