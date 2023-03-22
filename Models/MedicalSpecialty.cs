using System.ComponentModel.DataAnnotations;

namespace HIMSS_EHR_Challenge.Models
{
    public class MedicalSpecialty
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }

        public List<Service> Services { get; set; }

        public List<Provider> Providers { get; set; }
    }
}
