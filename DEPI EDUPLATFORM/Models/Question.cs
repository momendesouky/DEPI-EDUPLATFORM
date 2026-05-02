namespace DEPI_EDUPLATFORM.Models
{
    public class Question
    {
        public int Id { get; set; }

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

        public string Text { get; set; }
        public string Type { get; set; }

        public List<Answer> Answers { get; set; }
    }
}
