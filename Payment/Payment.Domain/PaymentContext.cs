namespace Payment.Domain
{
    /// <summary>
    /// Clase Contexto que utiliza una estrategia de pago concreta para realizar pagos.
    /// </summary>
    public class PaymentContext
    {
        /// <summary>
        /// La clase Contexto tiene una referencia al objeto de estrategia.
        /// El Contexto no conoce la clase concreta de una estrategia.
        /// Debe trabajar con todas las estrategias a través de la interfaz IPaymentStrategy.
        /// </summary>
        private IPaymentStrategy PaymentStrategy;

        /// <summary>
        /// Método para establecer la estrategia de pago a utilizar en tiempo de ejecución.
        /// El Cliente puede cambiar la estrategia de pago llamando a este método.
        /// </summary>
        /// <param name="strategy">La estrategia de pago que se desea usar.</param>
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            PaymentStrategy = strategy;
        }

        /// <summary>
        /// El contexto delega el trabajo al objeto de estrategia en lugar de implementar
        /// múltiples versiones del algoritmo por su cuenta.
        /// </summary>
        /// <param name="amount">El monto a pagar.</param>
        /// <returns>Devuelve <c>true</c> si el pago fue exitoso.</returns>
        public bool Pay(double amount)
        {
            return PaymentStrategy.Pay(amount);
        }
    }
}
