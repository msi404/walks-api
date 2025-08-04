namespace Test.Models.DTO
{
    public class WalkDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public double LengthInKilometer { get; set; }
        public string? WalkImageUrl { get; set; }
        public required DifficultyDto Difficulty { get; set; }
        public required RegionDto Region { get; set; }
    }
}