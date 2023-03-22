using System.ComponentModel.DataAnnotations;

namespace HIMSS_EHR_Challenge.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.Duration)]
        public TimeSpan Duration { get; set; }

        public MedicalSpecialty MedicalSpecialty { get; set; }
    }
}
