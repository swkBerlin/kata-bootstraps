using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace SplitWiseApplication.Tests
{
    public class SplitWiseTests
    {
        public class AddExpenseShould
        {
            [Fact]
            public void AddExpenseAsExpected()
            {
                var ledger = new Ledger();
                var paidByUser = new User("User1");
                var user2 = new User("User2");
                var splitWise = new SplitWise(ledger, new List<User> { paidByUser, user2 });
                const decimal amount = 100;

                var paidForUsers = new List<User>();

                paidForUsers.Add(user2);
                var transaction = new Expense(amount, paidByUser, paidForUsers);
                splitWise.AddExpense(transaction);
                using StringWriter sw = new();
                Console.SetOut(sw);
                splitWise.Show();
                var expected = $"{user2} owes {paidByUser}: {amount}";
                Assert.Equal(expected, sw.ToString().Trim());
            }
        }
    }
}