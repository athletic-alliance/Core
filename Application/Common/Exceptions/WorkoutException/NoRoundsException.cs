namespace AthleticAlliance.Application.Common.Exceptions.WorkoutException
{
    public class NoRoundsException : Exception
    {
        public NoRoundsException()
            : base()
        {
        }

        public NoRoundsException(string message)
            : base(message)
        {
        }
    }
}
