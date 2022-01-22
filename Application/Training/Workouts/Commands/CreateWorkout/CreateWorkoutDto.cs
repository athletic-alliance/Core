namespace AthleticAlliance.Application.Training.Workouts.Commands.CreateWorkout
{
    public class CreateWorkoutDto
    {
        List<WorkoutRoundDto> Rounds { get; set; }  
    }

    public class WorkoutRoundDto
    {
        List<WorkoutRoundExerciseDto> Exercises { get; set; }   
    }

    public class WorkoutRoundExerciseDto
    {
        int ExerciseId { get; set; }

        WorkoutRoundExerciseDetailsDto Details { get; set; }
    }

    public class WorkoutRoundExerciseDetailsDto { 
    }
}
