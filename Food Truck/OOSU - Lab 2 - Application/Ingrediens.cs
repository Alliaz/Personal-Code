using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU___Lab_2___Application
{
    public class Ingrediens
    {
        public string ingrediensNamn { get; set; }
        public List<Allergi> Allergi { get; set; }
        public string Recept { get; set; }

        public Ingrediens()
        {

            Allergi = new List<Allergi>();
        
        }
    }
}
