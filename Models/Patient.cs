using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace HIMSS_EHR_Challenge.Models;

public class Patient
{
    [Key]
    public int Id { get; set; }

    [DataType(DataType.Text)]
    public string FirstName { get; set; }

    [DataType(DataType.Text)]
    public string LastName { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [DataType(DataType.Text), RegularExpression(@"\d{3}-\d{2}-\d{4}", ErrorMessage = "SSN must have the format: ###-##-####, where '#' represents a digit.")]
    public string SSN { get; set; }

    [Required]
    public Genders Gender { get; set; }
    public enum Genders { Male, Female, NonBinary};

    [DataType(DataType.PhoneNumber), RegularExpression(@"\d{10}", ErrorMessage = "Phone Number must have 10 digits.")]
    public Int64 PhoneNumber { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    public PatientStatus Status { get; set; }

    public enum PatientStatus { Seeded, Created};
}

public class GenderConverter : JsonConverter<Patient.Genders>
{
    public override Patient.Genders Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }

        string enumString = reader.GetString();

        if (enumString.Equals("Male", StringComparison.OrdinalIgnoreCase))
        {
            return Patient.Genders.Male;
        }
        else if (enumString.Equals("Female", StringComparison.OrdinalIgnoreCase))
        {
            return Patient.Genders.Female;
        }
        else
        {
            return Patient.Genders.NonBinary;
        }
    }

    public override void Write(Utf8JsonWriter writer, Patient.Genders value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}

public class StatusConverter : JsonConverter<Patient.PatientStatus>
{
    public override Patient.PatientStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }

        string enumString = reader.GetString();

        if (enumString.Equals("Seeded", StringComparison.OrdinalIgnoreCase))
        {
            return Patient.PatientStatus.Seeded;
        }
        else if (enumString.Equals("Created", StringComparison.OrdinalIgnoreCase))
        {
            return Patient.PatientStatus.Created;
        }
        else
        {
            throw new JsonException($"Invalid patient status value: {enumString}"); 
        }
    }

    public override void Write(Utf8JsonWriter writer, Patient.PatientStatus value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}