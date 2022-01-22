namespace AthleticAlliance.Application.Training.Workouts.Commands.CreateWorkout
{
    public class WorkoutExerciseDetailsDto
    {
        public int Weight { get; set; }
        public int Distance { get; set; }
        public int Repetitions { get; set; }

        public WorkoutExerciseDetailsDto(int weight, int distance, int repetitions)
        {
            Weight = weight; 
            Distance = distance; 
            Repetitions = repetitions;
        }
    }
}
