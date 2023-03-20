using System.ComponentModel.DataAnnotations;

namespace HIMSS_EHR_Challenge.Models;

public class Patient
{
    public int Id { get; set; }

    [DataType(DataType.Text)]
    public string FirstName { get; set; }

    [DataType(DataType.Text)]
    public string LastName { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [DataType(DataType.Text)]
    public int SSN { get; set; }

    [Required]
    public Genders Gender { get; set; }
    public enum Genders { Male, Female};

    [DataType(DataType.PhoneNumber)]
    public int PhoneNumber { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }


}

