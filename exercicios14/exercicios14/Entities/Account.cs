using exercicios14.Entities.Exceptions;
namespace exercicios14.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit) 
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double deposit)
        {
            Balance += deposit;
        }
        public void Withdraw(double withdraw)
        {
            if(withdraw > Balance)
            {
                throw new WithdrawException("Not enough balance");
            }
            if(withdraw > WithdrawLimit)
            {
                throw new WithdrawException("The amount exceeds withdraw limit");
            }
            Balance -= withdraw;
        }
    }
}
