namespace BS01.Domain.Exceptions
{
    public sealed class DuplicateRecordForTitleException : DuplicateException
    {
        public DuplicateRecordForTitleException(string tilte)
            : base($"The title with the name {tilte} is available in the database")
        {
        }
    }

}
