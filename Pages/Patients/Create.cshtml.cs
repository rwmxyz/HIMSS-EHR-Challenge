using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HIMSS_EHR_Challenge.Data;
using HIMSS_EHR_Challenge.Models;

namespace HIMSS_EHR_Challenge.Pages_Patients
{
    public class CreateModel : PageModel
    {
        private readonly HIMSS_EHR_Challenge.Data.PatientContex _context;

        public CreateModel(HIMSS_EHR_Challenge.Data.PatientContex context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Patient Patient { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Patient == null || Patient == null)
            {
                return Page();
            }

            _context.Patient.Add(Patient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
