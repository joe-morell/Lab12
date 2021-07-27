 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount()
        {
            Balance = 1000;
        }

         public BankAccount(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Balance: {0}", Balance);
        }

        public virtual void Withdraw(double amount)
        {
            if (Balance > amount)
                Balance -= amount;
            else
                Console.WriteLine("Error; Balance under amount entered.");
            
            Console.WriteLine("Current Balance: $" + Balance);
        }
        public abstract void CalculateInterest();
    }