using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.Training
{
    public class Exercise : BaseEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }
}
