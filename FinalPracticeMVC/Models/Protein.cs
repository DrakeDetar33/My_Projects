using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPracticeMVC.Models
{
    public class Protein
    {
        public int ID { get; set; }
        public string Animal { get; set; }
        public string Name { get; set; }
        
        public int ServingSize { get; set; }
        public double ProteinTot { get; set; }
        public double FatTot { get; set; }
        public double Calories { get; set; }
    }
}
