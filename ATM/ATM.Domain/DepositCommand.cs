namespace ATM.Domain
{
    /// <summary>
    /// Representa un comando para depositar una cantidad en una cuenta.
    /// </summary>
    public class DepositCommand : ICommand
    {
        /// <summary>
        /// La cuenta en la que se realizará el depósito.
        /// </summary>
        private Account _account;

        /// <summary>
        /// La cantidad que se va a depositar en la cuenta.
        /// </summary>
        private decimal _amount;

        /// <summary>
        /// Inicializa una nueva instancia del comando <see cref="DepositCommand"/> con la cuenta y la cantidad a depositar.
        /// </summary>
        /// <param name="account">La cuenta donde se realizará el depósito.</param>
        /// <param name="amount">La cantidad que se va a depositar.</param>
        public DepositCommand(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        /// <summary>
        /// Ejecuta el comando de depósito en la cuenta.
        /// </summary>
        public void Execute()
        {
            _account.Deposit(_amount);
        }
    }
}
