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
    public string? Genre { get; set; }
}