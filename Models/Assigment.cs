using System.ComponentModel.DataAnnotations;

namespace HIMSS_EHR_Challenge.Models
{
    public class Assigment
    {
        [Key]
        public int Id { get; set; }
        
        public Patient Patient { get; set; }

        public Provider Provider { get; set; }

        public Service Service { get; set; }

        public Player Player { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime AppointmentStart { get; set; }
    }
}
