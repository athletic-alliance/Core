namespace AthleticAlliance.Application.Common.Exceptions.WorkoutException
{
    public class RoundNotSetException : Exception
    {
        public RoundNotSetException()
            : base()
        {
        }

        public RoundNotSetException(string message)
            : base(message)
        {
        }
    }
}
