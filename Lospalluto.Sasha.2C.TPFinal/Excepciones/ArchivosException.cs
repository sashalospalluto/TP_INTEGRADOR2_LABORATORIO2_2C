namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException(Exception innerException) : base("ocurrio un error con el archivo", innerException)
        {

        }

        public ArchivosException() : base("ocurrio un error con el archivo")
        {

        }

        public ArchivosException(string message) : base(message)
        {

        }
    }
}