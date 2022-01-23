namespace AthleticAlliance.Application.Training.Workouts.Commands.CreateWorkout
{
    public class WorkoutExerciseDto
    {
        public int ExerciseId { get; set; }
        public int Round { get; set; }
        public int Order { get; set; }
        public WorkoutExerciseDetailsDto Details { get; set; }  
    }
}
