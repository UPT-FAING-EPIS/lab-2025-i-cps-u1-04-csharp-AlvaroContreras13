using System;

namespace ATM.Domain
{
    /// <summary>
    /// Representa una cuenta bancaria con balance y operaciones de depósito y retiro.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// El monto máximo permitido para un depósito.
        /// </summary>
        public const decimal MAX_INPUT_AMOUNT = 10000;

        /// <summary>
        /// Número de la cuenta bancaria.
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// El saldo actual de la cuenta bancaria.
        /// </summary>
        public decimal AccountBalance { get; set; }

        /// <summary>
        /// Realiza un retiro de una cantidad específica de la cuenta.
        /// </summary>
        /// <param name="amount">La cantidad a retirar.</param>
        /// <exception cref="ArgumentException">Lanzada si el monto es mayor que el saldo disponible en la cuenta.</exception>
        public void Withdraw(decimal amount)
        {
            if (amount > AccountBalance)
                throw new ArgumentException("The input amount is greater than balance.");
            AccountBalance -= amount;            
        }

        /// <summary>
        /// Realiza un depósito de una cantidad específica en la cuenta.
        /// </summary>
        /// <param name="amount">La cantidad a depositar.</param>
        /// <exception cref="ArgumentException">Lanzada si el monto excede el máximo permitido para un depósito.</exception>
        public void Deposit(decimal amount)
        {
            if (amount > MAX_INPUT_AMOUNT)
                throw new ArgumentException("The input amount is greater than maximum allowed.");
            AccountBalance += amount;            
        }
    }
}
