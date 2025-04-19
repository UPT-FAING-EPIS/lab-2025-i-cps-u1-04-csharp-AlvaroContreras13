namespace Payment.Domain
{
    /// <summary>
    /// Interfaz que define el contrato para las estrategias de pago.
    /// </summary>
    public interface IPaymentStrategy
    {
        /// <summary>
        /// Realiza un pago con el monto especificado.
        /// </summary>
        /// <param name="amount">El monto a pagar.</param>
        /// <returns>Devuelve <c>true</c> si el pago fue exitoso.</returns>
        bool Pay(double amount);
    }
}
