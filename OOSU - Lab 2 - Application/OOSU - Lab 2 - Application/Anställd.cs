using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU___Lab_2___Application
{
    public class Anställd
    {
        public int anställdNummer { get; set; }
        public string AnställdNamn { get; set; }
        public int kontaktNummer { get; set; }
        public List<Förare> Förare { get; set; }
        public List<ÖvrigAnställd> ÖvrigAnställd {get; set; }
        public string Fordon { get; set; }
        

            public Anställd()
        {
            Förare = new List<Förare>();
            ÖvrigAnställd = new List<ÖvrigAnställd>();
        }

    }
}
