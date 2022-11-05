using System;
using UnitTestKata;

namespace UnitTestKataTests
{
    public class UnitTestsBankingKata
    {
        BankingKata account = new BankingKata();

        public UnitTestsBankingKata()
        {
        }

        private string getFinalBalance(string statement)
        {
            // last value of last line of statement should be current balance
            char[] separators = { ' ', '\t', '\n' };
            string[] statementTokens = statement.Split(separators, System.StringSplitOptions.RemoveEmptyEntries); // split on white space

            return statementTokens[statementTokens.Length - 1];
        }

        private string getLastTransactionAmount(string statement)
        {
            // next to last value of last line of statement should be last transaction amount
            char[] separators = { ' ', '\t', '\n' };     
            string[] statementTokens = statement.Split(separators, System.StringSplitOptions.RemoveEmptyEntries); // split on white space

            return statementTokens[statementTokens.Length - 2];
        }

        [Fact]
        public void Banking_PrintStatement_NewAccount()
        {
            string statement = account.printStatement();

            Assert.Equal("0", getFinalBalance(statement));
        }

        [Fact]
        public void Banking_Deposit500Dollars()
        {
            account.deposit(500);

            string statement = account.printStatement();

            Console.WriteLine(statement);
            //Assert.Equal("+500", getLastTransactionAmount(statement));
            Assert.Equal("500", getFinalBalance(statement));
        }

        [Fact]
        public void Banking_Withdraw100Dollars()
        {
            account.withdraw(100);

            string statement = account.printStatement();

            Assert.Equal("-100", getLastTransactionAmount(statement));
            Assert.Equal("-100", getFinalBalance(statement));
        }

        [Fact]
        public void Banking_MultipleDepositsAndWithdrawals()
        {

            account.deposit(500);
            account.withdraw(100);

            string statement = account.printStatement();

            Assert.Equal("-100", getLastTransactionAmount(statement));
            Assert.Equal("400", getFinalBalance(statement));
        }

    }
}

