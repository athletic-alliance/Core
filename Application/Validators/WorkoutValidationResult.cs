namespace AthleticAlliance.Application.Validators
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
