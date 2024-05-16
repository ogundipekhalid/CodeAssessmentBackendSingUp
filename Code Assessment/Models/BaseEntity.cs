namespace Code_Assessment.Models
{
    public class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(0, 5);
        public bool IsDeleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
