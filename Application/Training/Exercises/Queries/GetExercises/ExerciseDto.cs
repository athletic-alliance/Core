using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Domain.Entities.Training;
using AthleticAlliance.Domain.Enums;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Exercises.Queries.GetExercises
{
    public class ExerciseDto: IMapFrom<Exercise>
    { 
        public int Id { get; set; }
        public string? Name { get; set; }

        public ExerciseType Type { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Exercise, ExerciseDto>();
        }
    }
}
