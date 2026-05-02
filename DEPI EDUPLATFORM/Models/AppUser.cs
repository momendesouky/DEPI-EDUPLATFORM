using Microsoft.AspNetCore.Identity;
namespace DEPI_EDUPLATFORM.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }

        public List<Enrollment> Enrollments { get; set; }
        public List<LessonProgress> LessonProgresses { get; set; }
        public List<QuizAttempt> QuizAttempts { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Certificate> Certificates { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
