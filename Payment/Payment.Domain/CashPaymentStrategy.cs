namespace Payment.Domain
{
    /// <summary>
    /// Implementa una estrategia de pago en efectivo.
    /// </summary>
    public class CashPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Realiza el pago utilizando efectivo.
        /// </summary>
        /// <param name="amount">El monto a pagar.</param>
        /// <returns>Devuelve <c>true</c> si el pago fue exitoso.</returns>
        public bool Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " By Cash");
            return true;
        }
    }
}
