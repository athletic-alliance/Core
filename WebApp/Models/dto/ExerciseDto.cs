using WebApp.Models.Enum;

namespace WebApp.Models.dto;

public class ExerciseDto
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public ExerciseType Type { get; set; }
}