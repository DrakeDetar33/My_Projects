using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalPracticeMVC.Models
{
    public class ProteinAnimalViewModel
    {
        public List<Protein> Proteins { get; set; }
        public SelectList Animal {get;set;}
        public string ProteinAnimal {get;set;}
        public string SearchString { get; set; }
    }
}
