using Microsoft.EntityFrameworkCore;
using HIMSS_EHR_Challenge.Data;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace HIMSS_EHR_Challenge.Models;

public static class SeedData
{
    public static async void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new PatientContex(
            serviceProvider.GetRequiredService<
            DbContextOptions<PatientContex>>()))
        {
            if (context == null || context.Patient == null)
            {
                throw new ArgumentNullException("Null PatientContext");
            }

            // Look for any patients.
            if (context.Patient.Any())
            {
                return; // DB has been seeded
            }
            
            List<Patient> patientsList = new List<Patient>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://my.api.mockaroo.com/flobo_ehr_patients.json?key=acccbc00"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    options.Converters.Add(new GendersConverter());
                    patientsList = JsonSerializer.Deserialize<List<Patient>>(apiResponse, options);
                }
            }
            
            context.Patient.AddRangeAsync(patientsList);
            context.SaveChangesAsync();
        }
    }
}