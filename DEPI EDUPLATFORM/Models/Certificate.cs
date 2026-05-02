namespace DEPI_EDUPLATFORM.Models
{
    public class Certificate
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }

        public string CertificateCode { get; set; }
        public string QrCodePath { get; set; }

        public DateTime IssuedAt { get; set; }
    }
}
