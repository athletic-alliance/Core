using AthleticAlliance.Application.Training.Workouts.Commands.CreateWorkout;
using System.Collections.Generic;
using FluentAssertions;
using System;
using AthleticAlliance.Application.Common.Exceptions.WorkoutException;
using AthleticAlliance.Application.Validators;
using Xunit;

namespace Test
{
    public class WorkoutValidatorTest
    {
        [Fact(DisplayName = "A workout with no exercises should throw an NoExerciseException")]
        public void Validate_NoExercisesGiven_ShouldThrowNoExerciseException()
        {
            WorkoutRoundValidator validator = new WorkoutRoundValidator();

            Action act = () => validator.Validate(new List<WorkoutExerciseDto>());

            act.Should().Throw<NoExerciseException>().WithMessage("The workout must at least contain one round with one exercise");
        }

        [Fact(DisplayName = "A workout with an exercises with round = 0 should throw an RoundNotSetException")]
        public void Validate_ExerciseHasRound0_ShouldThrowRoundNotSetException()
        {
            WorkoutRoundValidator validator = new WorkoutRoundValidator();

            var exercise = new WorkoutExerciseDto();
            exercise.Round = 0;

            Action act = () => validator.Validate(new List<WorkoutExerciseDto>() { exercise });

            act.Should().Throw<RoundNotSetException>().WithMessage("The value of round attribute muste greater than 0 on each exercise");
        }

        [Fact(DisplayName = "A workout with a valid list of exercises should not throw an exception")]
        public void Validate_SetupCorrect_ShouldNotThrowAnException()
        {
            WorkoutRoundValidator validator = new WorkoutRoundValidator();

            var exercise = new WorkoutExerciseDto();
            exercise.Round = 1;

            Action act = () => validator.Validate(new List<WorkoutExerciseDto>() { exercise });

            act.Should().NotThrow();
        }
    }
}