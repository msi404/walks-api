namespace Test.Models.DTO
{
    public class AddWalkRequestDto
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public double LengthInKilometer { get; set; }
        public string? WalkImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }
    }
}