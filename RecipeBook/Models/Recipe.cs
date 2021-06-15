using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public int Calories { get; set; }
        public double Protien { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }

    }

    public class RecipeDBContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
    }
}
