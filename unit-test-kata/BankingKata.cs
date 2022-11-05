using System;
using System.Collections.Generic;
namespace UnitTestKata
{
    public class BankingKata
    {
        public BankingKata()
        {

            transactions = new List<Transaction>();
            transactions.Add(new Transaction(DateTime.Now, '+', 0, 0));
        }

        private List<Transaction> transactions;
        private class Transaction
        {
            private readonly DateTime date;
            private readonly char type;
            private readonly int amount;
            private readonly int balance;

            public Transaction (DateTime date, char type, int amount, int balance)
            {
                this.date = date;
                this.type = type;
                this.amount = amount;
                this.balance = balance;
            }

            public DateTime Date {  get { return this.date;  } }
            public char Type { get { return this.type; } }
            public int Amount { get { return this.amount; } }
            public int Balance { get { return this.balance; } }

        }


        public String printStatement()
        {
            string statement;

            statement = "DATE       AMOUNT     BALANCE\n" +
                        "========== ========== ==========\n";

            foreach (var tran in transactions)
            {
                statement += $"{tran.Date} {tran.Type}{tran.Amount.ToString().PadRight(10)} {tran.Balance.ToString().PadRight(10)}\n";
            }

            return statement;
        }

        public void deposit (int amount)
        {
            int newBalance = getCurrentBalance() + amount;
            transactions.Add(new Transaction(DateTime.Now, '+', amount, newBalance));
        }

        public void withdraw(int amount)
        {
            int newBalance = getCurrentBalance() - amount;
            transactions.Add(new Transaction(DateTime.Now, '-', amount, newBalance));
        }

        private int getCurrentBalance()
        {
            return transactions[^1].Balance;
        }
    }

    
}

