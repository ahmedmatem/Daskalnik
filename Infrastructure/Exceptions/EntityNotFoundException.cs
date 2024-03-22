namespace Infrastructure.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        private const string defaultMessage = "Exception: Entity was not found.";

        public EntityNotFoundException(string? message = defaultMessage) : base(message) { }

        public EntityNotFoundException(
            string? message, 
            Exception? innerException) : base(message, innerException) { }
    }
}
