using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalPracticeMVC.Models;

namespace FinalPracticeMVC.Data
{
   public class FinalPracticeMVCContext: DbContext
    {
        public FinalPracticeMVCContext(DbContextOptions<FinalPracticeMVCContext> options)
            : base(options) 
        { 
        }
    public DbSet<Protein> Protein { get; set; }
}
}
