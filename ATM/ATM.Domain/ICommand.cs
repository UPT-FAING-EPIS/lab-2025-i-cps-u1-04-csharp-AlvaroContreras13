namespace ATM.Domain
{
    /// <summary>
    /// Interfaz que define un comando que puede ser ejecutado.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        void Execute();
    }
}
