namespace ATM.Domain
{
    /// <summary>
    /// Representa el sistema de cajero automático que ejecuta comandos sobre una cuenta.
    /// </summary>
    public class ATM
    {
        /// <summary>
        /// El comando que se ejecutará en el cajero automático.
        /// </summary>
        private ICommand _command;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ATM"/> con un comando específico.
        /// </summary>
        /// <param name="command">El comando que el cajero automático ejecutará.</param>
        public ATM(ICommand command)
        {
            _command = command;
        }

        /// <summary>
        /// Ejecuta el comando asociado al cajero automático.
        /// </summary>
        public void Action()
        {
            _command.Execute();
        }
    }
}
