namespace DEPI_EDUPLATFORM.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }

        public int Rating { get; set; }
        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
