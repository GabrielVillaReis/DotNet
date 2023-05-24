namespace exercicios14.Entities.Exceptions
{
    internal class WithdrawException : ApplicationException
    {
        public WithdrawException(string message) : base(message) { }
    }
}
