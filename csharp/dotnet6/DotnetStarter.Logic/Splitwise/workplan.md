https://workat.tech/machine-coding/practice/splitwise-problem-0kp2yneec2q2

Data:
 - userid, name, email, mobile number - related data hints at encapsulating this as seperate class
 - owes and owed by info

Behavior:
 - spend money as PER transaction type and update the owes and owed by info - behavior per entity hints at subclasses
 - round off to 2 decimal places
 - given a user, shud be able to tell who he owes and who owes him
 - shud be able to tell who he owes and who owes him, for all users

 API:
 only 3 customer facing APIs
 - expense
 - show
 - show for a user

 Design:
 
 - User:
	- User(name, email, mobile number)
	- string id
	- string name
	- string email
    - string mobile number

 - Ledger:
    - Ledger()
    - map[user, list[(user, decimal)]] CollectFrom
    - map[user, list[(user, decimal)]] GiveTo
	- AddExpense(Transaction transaction):
    	- if(transaction.isValid()):
			- foreach(user in transaction.paidFor):
    			- CollectFrom[transaction.paidBy].Add((user, transaction.GetSplitAmountForUser(user)))
				- GiveTo[user].Add((transaction.paidBy, transaction.GetSplitAmountForUser(user)))
    - list[(user, user, decimal)] GetBalance(User user):
    	- balance = []
		- foreach(owe in CollectFrom[user]):
    		- balance.Add((owe.Item1, user, owe.Item2))
		- foreach(owedBy in GiveTo[user]):
    		- balance.Add((user, owedBy.Item1, owedBy.Item2))
		- return balance
    

 - Transaction:
	- Transaction(amount, paidBy, paidFor, type)
    - decimal amount
	- user paidBy
	- list[user] paidFor
	- TransactionType type
	- bool IsValid():
    	- type.IsValid(this)
    - decimal GetSplitAmountForUser(User user):
		- type.GetSplitAmountForUser(this, user)

 - ITransactionType
	- bool IsValid(Transaction transaction)
	- decimal GetSplitAmountForUser(Transaction transaction, User user)

 - EqualSplit : TransactionType
	- bool IsValid(Transaction transaction):
    	- return true
	- decimal GetSplitAmountForUser(Transaction transaction, User user):
    	// The amount should be rounded off to two decimal places. Say if User1 paid 100 and amount is split equally among 3 people. Assign 33.34 to first person and 33.33 to others.
		- return Math.Round(transaction.amount / transaction.paidFor.Count, 2)
 - PercentageSplit : TransactionType
	- PercentageSplit(list[(user, int)] percentages)
	- map[user, int] percentageOf
	- bool IsValid(Transaction transaction):
    	- sum = 0
		- foreach(user in percentageOf):
			- if percentageOf[user] < 0 or percentageOf[user] > 100:
				- return false
			- sum += percentageOf[user]
		- return sum == 100
 - ExactSplit : TransactionType
	- ExactSplit(list[(user, decimal)] exactAmounts)
	- map[user, decimal] exactAmountFor
	- bool IsValid(Transaction transaction):
		- sum = 0
		- foreach(user in exactAmountFor):
			- if exactAmountFor[user] < 0:
				- return false
			- sum += exactAmountFor[user]
		- return sum == transaction.amount


- Splitwise:
    - Splitwise(list[User], ledger)
    - map[string, User] users
	- Ledger ledger
	- void AddExpense(Transaction transaction):
    	- ledger.AddExpense(transaction)
	- void Show():
    	- noBalance = true
		- foreach(user in users):
    		- balance = ledger.GetBalance(user)
			- if balance is empty:
				- continue
			- noBalance = false
			- foreach(bal in balance):
				- print "{bal.Item1.name} owes {bal.Item2.name} {bal.Item3}"
		- if noBalance:
    		- print "No balances"

	- void Show(User user)
    	- balance = ledger.GetBalance(user)
		- if balance is empty:
    		- print "No balances"
		- foreach(bal in balance):
			- print "{bal.Item1.name} owes {bal.Item2.name} {bal.Item3}")
	