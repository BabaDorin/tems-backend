namespace Domain.Exceptions
{
    public class ExistingTypeException : Exception
    {
        public ExistingTypeException(string message)
            : base(message)
        {

        }
    }
}
