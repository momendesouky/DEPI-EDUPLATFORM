namespace DEPI_EDUPLATFORM.Models
{
    public class Section
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string Title { get; set; }
        public int OrderIndex { get; set; }

        public List<Lesson> Lessons { get; set; }
    }
}
