namespace AthleticAlliance.Application.Validators;

public class PlanValidationResult
{
    private bool IsValid { get; set; }

    public PlanValidationResult(bool valid)
    {
        IsValid = valid;
    }
}