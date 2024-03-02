using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }
        private int  Balance { get; set; }
        private static int InitialAccountNumber = 1111111111;
        private List<Transaction> Transactions = new List<Transaction>();
        public void Deposit(int amount, DateTime date, string description)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Entered amount must be positive!");
                amount = 0;
                description = "Entered amount must be positive!";
                Transaction deposit = new Transaction(amount, date, description,OperationType.Fail, TransactionType.Deposit);
                Transactions.Add(deposit);
            }
            else
            {
                Console.WriteLine("The process is successfully accomplished!");
                Transaction deposit = new Transaction(amount, date, description, OperationType.Success, TransactionType.Deposit);
                Transactions.Add(deposit);
            }
        }

        public void Withdrawal(int amount, DateTime date, string description)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Entered amount must be positive!");
                amount = 0;
                description = "Entered amount must be positive!";
                Transaction deposit = new Transaction(amount, date, description, OperationType.Fail, TransactionType.Withdrawal);
                Transactions.Add(deposit);
            }
            if (this.BalanceValue() - amount < 0)
            {
                Console.WriteLine("Balance is not sufficient!");
                amount = 0;
                description = "Balance is not sufficient!";
                Transaction deposit = new Transaction(amount, date, description, OperationType.Fail, TransactionType.Withdrawal);
                Transactions.Add(deposit);
            }
            else
            {
                Console.WriteLine("The process is successfully accomplished!");
                var withdrawal = new Transaction(-amount, date, description, OperationType.Success, TransactionType.Withdrawal);
                Transactions.Add(withdrawal);
            }   
        }
        public BankAccount(string name, int initialBalance)
        {
            OwnerName = name;
            Balance = initialBalance;
            AccountNumber = InitialAccountNumber;
            InitialAccountNumber++;
            Deposit(initialBalance, DateTime.Now, "Initial balance");
        }
        public BankAccount()
        {
            OwnerName = null;
            Balance = 0;
            AccountNumber = 0;
        }
        public int BalanceValue()
        {
            int value = 0;
            foreach(var transaction in Transactions)
            {
                value += transaction.Amount;
            }
            return value;
        }
        public string TransactionsHistory()
        {
            var history = new StringBuilder();

            decimal balance = 0;
            history.AppendLine("Date\t\tAmount\tBalance\tDescription\tOperation type\tTransaction type");
            foreach (var item in Transactions)
            {
                balance += item.Amount;
                history.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Description}\t{item.OperationType}\t{item.TransactionType}");
            }

            return history.ToString();
        }
    }
}
