namespace NZWalksAPI.Models.Domains
{
    public class Walks
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Double LengthInKm { get; set; }
        public string? WalksImageUrl { get; set; }

        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }

        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}
