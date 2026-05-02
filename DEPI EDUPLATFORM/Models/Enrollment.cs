namespace DEPI_EDUPLATFORM.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }

        public int Progress { get; set; }
        public DateTime EnrolledAt { get; set; }

        public int? LastLessonId { get; set; }
    }
}
