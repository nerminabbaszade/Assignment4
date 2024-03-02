using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Transaction
    {
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public OperationType OperationType { get; set; }
        public TransactionType TransactionType { get; set; }

        public Transaction(int amount, DateTime date, string description , OperationType Operation , TransactionType Transaction)
        {
            Amount = amount;
            Date = date;
            Description = description;
            OperationType=Operation; 
            TransactionType = Transaction;
        }
    }
}
