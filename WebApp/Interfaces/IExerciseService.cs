using WebApp.Models.dto;

namespace WebApp.Interfaces;

public interface IExerciseService
{
    public Task<IEnumerable<ExerciseDto>> GetAll();
    public Task<ExerciseDto> Create(ExerciseDto exercise);
}