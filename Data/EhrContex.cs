using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HIMSS_EHR_Challenge.Models;

namespace HIMSS_EHR_Challenge.Data
{
    public class EhrContex : DbContext
    {
        public EhrContex (DbContextOptions<EhrContex> options)
            : base(options)
        {
        }

        public DbSet<HIMSS_EHR_Challenge.Models.Patient> Patient { get; set; } = default!;
        public DbSet<HIMSS_EHR_Challenge.Models.Assigment> Assigment { get; set; } = default!;
    }
}
