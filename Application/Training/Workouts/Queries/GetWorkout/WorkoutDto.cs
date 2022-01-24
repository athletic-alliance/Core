﻿using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetWorkouts
{
    public class WorkoutDto : IMapFrom<Workout>
    {
        public string? Name { get; set; }

        public ICollection<GetWorkoutExerciseDto>? Exercises {get;set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Workout, WorkoutDto>();
        }
    }
}