namespace Payment.Domain
{
    /// <summary>
    /// Clase que procesa los pagos utilizando diferentes estrategias de pago.
    /// </summary>
    public class PaymentService
    {
        /// <summary>
        /// Procesa el pago seleccionando la estrategia de pago adecuada según el tipo de pago seleccionado.
        /// </summary>
        /// <param name="SelectedPaymentType">El tipo de pago seleccionado, que puede ser un valor de la enumeración <see cref="PaymentType"/>.</param>
        /// <param name="Amount">El monto a pagar.</param>
        /// <returns>Devuelve <c>true</c> si el pago fue procesado correctamente, de lo contrario lanza una excepción.</returns>
        /// <exception cref="ArgumentException">Se lanza si el tipo de pago seleccionado no es válido.</exception>
        public bool ProcessPayment(int SelectedPaymentType, double Amount)
        {
            // Crear una instancia de la clase PaymentContext
            PaymentContext context = new PaymentContext();
            
            // Establecer la estrategia de pago según el tipo seleccionado
            if (SelectedPaymentType == (int)PaymentType.CreditCard)
            {
                context.SetPaymentStrategy(new CreditCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.DebitCard)
            {
                context.SetPaymentStrategy(new DebitCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.Cash)
            {
                context.SetPaymentStrategy(new CashPaymentStrategy());
            }
            else
            {
                throw new ArgumentException("You Select an Invalid Payment Option");
            }

            // Llamar al método Pay para procesar el pago
            return context.Pay(Amount);
        }
    }

    /// <summary>
    /// Enumeración que define los tipos de pago disponibles.
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        /// Tipo de pago con tarjeta de crédito (valor 1).
        /// </summary>
        CreditCard = 1,

        /// <summary>
        /// Tipo de pago con tarjeta de débito (valor 2).
        /// </summary>
        DebitCard = 2,

        /// <summary>
        /// Tipo de pago en efectivo (valor 3).
        /// </summary>
        Cash = 3,
    }
}
