namespace DEPI_EDUPLATFORM.Models
{
    public class QuizAttempt
    {
        public int Id { get; set; }

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }

        public int Score { get; set; }
        public DateTime TakenAt { get; set; }
    }
}
