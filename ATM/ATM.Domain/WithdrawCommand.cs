namespace ATM.Domain
{
    /// <summary>
    /// Representa un comando para retirar una cantidad de una cuenta.
    /// </summary>
    public class WithdrawCommand : ICommand
    {
        private Account _account;
        private decimal _amount;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="WithdrawCommand"/>.
        /// </summary>
        /// <param name="account">La cuenta desde la cual se realizará el retiro.</param>
        /// <param name="amount">La cantidad que se desea retirar.</param>
        public WithdrawCommand(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        /// <summary>
        /// Ejecuta el comando de retiro en la cuenta especificada.
        /// </summary>
        public void Execute()
        {
            _account.Withdraw(_amount);
        }
    }
}
