using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout
{
    public class WorkoutExerciseDto
    {
        public int Id { get; set; }

        public int ExerciseId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<WorkoutExercise, WorkoutExerciseDto>();
        }
    }
}
