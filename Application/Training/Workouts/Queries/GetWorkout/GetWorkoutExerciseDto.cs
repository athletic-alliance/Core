using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Application.Training.Exercises.Queries.GetExercises;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout
{
    public class GetWorkoutExerciseDto : IMapFrom<WorkoutExercise>
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public int Round { get; set; }
        public int Order { get; set; }
        public ExerciseDto Exercise { get; set; }
        public ViewWorkoutExerciseDetailsDto Details { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<WorkoutExercise, GetWorkoutExerciseDto>();
        }
    }
}
