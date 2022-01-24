namespace AthleticAlliance.Application.Common.Exceptions.WorkoutException
{
    public class NoExerciseException : Exception
    {
        public NoExerciseException()
            : base()
        {
        }

        public NoExerciseException(string message)
            : base(message)
        {
        }
    }
}
