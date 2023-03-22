using System.ComponentModel.DataAnnotations;

namespace HIMSS_EHR_Challenge.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }

        public List<Assigment> Assigments { get; set; }
    }
}
