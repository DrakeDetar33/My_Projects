using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCRecipeBook.Models;

namespace MVCRecipeBook.Data
{
    public class MVCRecipeBookContext : DbContext
    {
        public MVCRecipeBookContext (DbContextOptions<MVCRecipeBookContext> options)
            : base(options)
        {
        }

        public DbSet<MVCRecipeBook.Models.RecipeBookModel> RecipeBookModel { get; set; }
    }
}
