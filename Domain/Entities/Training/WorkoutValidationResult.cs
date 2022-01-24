namespace AthleticAlliance.Domain.Entities.Training
{
    public class WorkoutValidationResult
    {
        public bool isValid { get; set; }

        public WorkoutValidationResult(bool valid)
        {
            isValid = valid;
        }
    }
}
