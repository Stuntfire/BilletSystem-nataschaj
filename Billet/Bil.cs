using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billet
{
    public class Bil
    {
        /// <summary>
        /// Du må se at få lavet resten af opgaven :-)
        /// </summary>
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public int Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }


        

    }
}
