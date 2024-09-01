using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitWiseApplication
{
    public class SplitWise
    {
        private readonly Ledger _ledger;
        private readonly Dictionary<string, User> _users;

        public SplitWise(Ledger ledger, List<User> users)
        {
            this._ledger = ledger;
            this._users = new Dictionary<string, User>();
            foreach (var user in users)
            {
                this._users.Add(user.ToString(), user);
            }

        }
        public void AddExpense(Expense expense)
        {
            this._ledger.AddExpense(expense);
        }
        public void Show()
        {
            var noBalance = true;
            var shownBalance = new HashSet<(User, User)>();
            foreach (var userId in this._users.Keys)
            {
                var user = this._users[userId];
                var balances = this._ledger.GetBalance(user);
                foreach (var balance in balances.Where(balance => balance.Item3 > 0))
                {
                    noBalance = false;
                    if(shownBalance.Contains((balance.Item1, balance.Item2)) || shownBalance.Contains((balance.Item2, balance.Item1)))
                    {
                        continue;
                    }
                    shownBalance.Add((balance.Item1, balance.Item2));
                    Console.WriteLine($"{balance.Item1} owes {balance.Item2}: {balance.Item3}");
                }
            }
            if (noBalance)
            {
                Console.WriteLine("No balances");
            }
        }
    }
    public class Ledger
    {
        private readonly Dictionary<User, List<(User, decimal)>> _collectFrom;
        private readonly Dictionary<User, List<(User, decimal)>> _giveTo;

        public Ledger()
        {
            this._collectFrom = new Dictionary<User, List<(User, decimal)>>();
            this._giveTo= new Dictionary<User, List<(User, decimal)>>();
        }

        public void AddExpense(Expense expense)
        {
            if (!expense.IsValid()) return;
            var expensePaidByUser = expense.PaidByUser;
            foreach (var user in expense.PaidForUsers)
            {
                if (user == expensePaidByUser)
                {
                    continue;
                }

                if (!this._collectFrom.ContainsKey(expensePaidByUser))
                {
                    this._collectFrom.Add(expensePaidByUser, new List<(User, decimal)>());
                }

                if(!this._giveTo.ContainsKey(user))
                {
                    this._giveTo.Add(user, new List<(User, decimal)>());
                }

                this._collectFrom[expensePaidByUser].Add((user, expense.Amount / expense.PaidForUsers.Count));
                this._giveTo[user].Add((expensePaidByUser, expense.Amount / expense.PaidForUsers.Count));
            }
        }

        public List<(User, User, decimal)> GetBalance(User user)
        {
            var balance = new List<(User, User, decimal)>();
            if (this._giveTo.ContainsKey(user))
            {
                foreach (var (user1, amount) in this._giveTo[user])
                {
                    balance.Add((user, user1, amount));
                }
            }
            if (this._collectFrom.ContainsKey(user))
            {
                foreach (var (user1, amount) in this._collectFrom[user])
                {
                    balance.Add((user1, user, amount));
                }
            }
            return balance;
        }
    }
    public class Expense
    {
        public decimal Amount { get; }
        public User PaidByUser { get; }
        private readonly List<User> _paidForUsers;
        public IReadOnlyList<User> PaidForUsers => this._paidForUsers.AsReadOnly();

        public Expense(decimal amount, User paidByUser, List<User> paidForUsers)
        {
            this.Amount = amount;
            this.PaidByUser = paidByUser;
            this._paidForUsers = paidForUsers;
        }

        public bool IsValid()
        {
            return true;
        }
    }
    public class User
    {
        private readonly string _name;

        public User(string name)
        {
            this._name = name;
        }
        public override string ToString()
        {
            return this._name;
        }
    }
}
