using static System.Collections.Specialized.BitVector32;

namespace DEPI_EDUPLATFORM.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string InstructorId { get; set; }

        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<Section> Sections { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Certificate> Certificates { get; set; }
    }
}
