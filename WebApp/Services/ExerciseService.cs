using WebApp.Interfaces;
using WebApp.Models.dto;

namespace WebApp.Services;

public class ExerciseService : IExerciseService
{
    private readonly IHttpService _httpService;

    public ExerciseService(IHttpService httpService)
    {
        _httpService = httpService;
    }

    public async Task<IEnumerable<ExerciseDto>> GetAll()
    {
        return await _httpService.Get<IEnumerable<ExerciseDto>>("https://localhost:3001/exercise");
    }

    public async Task<ExerciseDto> Create(ExerciseDto exercise)
    {
        return await _httpService.Post<ExerciseDto>("https://localhost:3001/exercise", exercise);
    }
}