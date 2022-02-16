using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout
{
    public class ViewWorkoutExerciseDetailsDto : IMapFrom<WorkoutExerciseDetails>
    {
        public int Id { get; set; }

        public int? Repetitions { get; set; }

        public int? Weight { get; set; }

        public int? Distance { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<WorkoutExerciseDetails, ViewWorkoutExerciseDetailsDto>();
        }
    }
}
