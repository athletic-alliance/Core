using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Exercises.Queries.GetExercises
{
    public class ExerciseDto: IMapFrom<Exercise>
    { 
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Exercise, ExerciseDto>();
        }
    }
}
