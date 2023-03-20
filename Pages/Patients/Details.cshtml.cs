using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HIMSS_EHR_Challenge.Data;
using HIMSS_EHR_Challenge.Models;

namespace HIMSS_EHR_Challenge.Pages.Patients
{
    public class DetailsModel : PageModel
    {
        private readonly HIMSS_EHR_Challenge.Data.PatientContex _context;

        public DetailsModel(HIMSS_EHR_Challenge.Data.PatientContex context)
        {
            _context = context;
        }

      public Patient Patient { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Patient == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient.FirstOrDefaultAsync(m => m.Id == id);
            if (patient == null)
            {
                return NotFound();
            }
            else 
            {
                Patient = patient;
            }
            return Page();
        }
    }
}
