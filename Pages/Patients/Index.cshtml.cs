using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HIMSS_EHR_Challenge.Data;
using HIMSS_EHR_Challenge.Models;

namespace HIMSS_EHR_Challenge.Pages_Patients
{
    public class IndexModel : PageModel
    {
        private readonly HIMSS_EHR_Challenge.Data.PatientContex _context;

        public IndexModel(HIMSS_EHR_Challenge.Data.PatientContex context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Patient != null)
            {
                Patient = await _context.Patient.ToListAsync();
            }
        }
    }
}
