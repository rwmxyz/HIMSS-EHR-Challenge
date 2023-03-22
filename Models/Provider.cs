using System.ComponentModel.DataAnnotations;

namespace HIMSS_EHR_Challenge.Models
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        public string LastName { get; set; }

        public MedicalSpecialty MedicalSpecialty { get; set; }
    }
}
