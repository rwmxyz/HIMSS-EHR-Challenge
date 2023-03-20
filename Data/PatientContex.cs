using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HIMSS_EHR_Challenge.Models;

namespace HIMSS_EHR_Challenge.Data
{
    public class PatientContex : DbContext
    {
        public PatientContex (DbContextOptions<PatientContex> options)
            : base(options)
        {
        }

        public DbSet<HIMSS_EHR_Challenge.Models.Patient> Patient { get; set; } = default!;
    }
}
