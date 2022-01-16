namespace AthleticAlliance.Application.Training.Exercises.Queries.GetExercises
{
    public  class ExercisesVm
    {
        public IList<ExerciseDto> Exercises { get; set;} = new List<ExerciseDto>();
    }
}
