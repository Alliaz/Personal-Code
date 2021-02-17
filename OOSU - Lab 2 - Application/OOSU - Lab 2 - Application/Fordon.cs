using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU___Lab_2___Application
{
   public class Fordon
    {
        public string fordonsNamn { get; set; }
        public string registereringsNummer { get; set; }
        public List<Anställd> Anställd { get; set; }
        public List<Maträtt> Maträtt { get; set; }
        
        

        public Fordon()
        {
            Anställd = new List<Anställd>();
            Maträtt = new List<Maträtt>();
        }
    }

        
}
