using FluentValidation;

namespace AthleticAlliance.Application.Training.Exercises.Commands.CreateExercise
{
    public class CreateExerciseCommandValidator : AbstractValidator<CreateExerciseCommand>
    {
        public CreateExerciseCommandValidator()
        {
            RuleFor(e => e.Name)
            .MaximumLength(200)
            .NotEmpty();
        }
    }
}
