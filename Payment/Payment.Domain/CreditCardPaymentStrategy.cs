namespace Payment.Domain
{
    /// <summary>
    /// Implementa una estrategia de pago mediante tarjeta de crédito.
    /// </summary>
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Realiza el pago utilizando una tarjeta de crédito.
        /// </summary>
        /// <param name="amount">El monto a pagar.</param>
        /// <returns>Devuelve <c>true</c> si el pago fue exitoso.</returns>
        public bool Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Credit Card");
            return true;
        }
    }
}
