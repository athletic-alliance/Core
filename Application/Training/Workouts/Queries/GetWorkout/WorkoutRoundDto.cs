namespace AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout;

public class WorkoutRoundDto
{
    public int Index { get; set; }
    public ICollection<WorkoutRoundExerciseDto> Exercises { get; set; }
}