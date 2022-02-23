namespace AthleticAlliance.Application.Common.Exceptions.Plan;

public class WorkoutOnSameDayException : Exception
{
    public WorkoutOnSameDayException()
        : base()
    {
    }

    public WorkoutOnSameDayException(string message)
        : base(message)
    {
    }
}