namespace Payment.Domain
{
    /// <summary>
    /// Implementa una estrategia de pago mediante tarjeta de débito.
    /// </summary>
    public class DebitCardPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Realiza el pago utilizando una tarjeta de débito.
        /// </summary>
        /// <param name="amount">El monto a pagar.</param>
        /// <returns>Devuelve <c>true</c> si el pago fue exitoso.</returns>
        public bool Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Debit Card");
            return true;
        }
    }
}
