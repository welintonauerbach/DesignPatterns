﻿using System;
using DesignPatterns.FactoryMethod.Domain.ValueObj;

namespace DesignPatterns.FactoryMethod.Domain
{
    public class TransactionInfo
    {
        public Guid TransactionKey { get; }
        public DateTime CreateDate { get; }
        public double Amount { get; }
        public TransactionStatusType TransactionStatusType { get; }

        public TransactionInfo(Guid transactionKey, DateTime date, double amount, TransactionStatusType transactionStatusType)
        {
            TransactionKey = transactionKey;
            CreateDate = date;
            Amount = amount;
            TransactionStatusType = transactionStatusType;
        }
    }
}