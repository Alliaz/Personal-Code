using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU___Lab_2___Application
{
    public class Maträtt
    {
        public List<Recept> Recept{ get; set; }
        public string maträttNamn { get; set; }
        public float pris { get; set; }
        public string maträttBeskrivning { get; set; }
        public string Fordon { get; set; }

        public Maträtt()
        {
            Recept = new List<Recept>();
        }
    }
}
