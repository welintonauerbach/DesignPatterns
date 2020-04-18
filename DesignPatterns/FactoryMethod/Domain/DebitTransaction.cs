using DesignPatterns.FactoryMethod.Domain.Base;
using DesignPatterns.FactoryMethod.Domain.ValueObj;

namespace DesignPatterns.FactoryMethod.Domain
{
    public sealed class DebitTransaction : TransactionBase
    {
        public string BankName { get; }

        public DebitTransaction(double amount, string bankName) : base(TransactionType.Debit, amount)
        {
            BankName = bankName;
        }
    }
}