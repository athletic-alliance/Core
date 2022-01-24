namespace AthleticAlliance.Application.Common.Exceptions.WorkoutException
{
    public class DuplicateRoundException : Exception
    {
        public DuplicateRoundException()
            : base()
        {
        }

        public DuplicateRoundException(string message)
            : base(message)
        {
        }
    }
}
