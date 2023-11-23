namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Excepcion para manejo de archivos que recibe un dato de tipo exception y devuelve un mensaje y una excepcion
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException(Exception innerException) : base("ocurrio un error con el archivo", innerException)
        {

        }

        /// <summary>
        /// Excepcion para manejo de archivos que devuelve un mensaje
        /// </summary>
        public ArchivosException() : base("ocurrio un error con el archivo")
        {

        }

        /// <summary>
        /// Excepcion para manejo de archivos que recibe  y devuelve un mensaje
        /// </summary>
        /// <param name="message"></param>
        public ArchivosException(string message) : base(message)
        {

        }
    }
}