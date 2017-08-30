using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billet
{
    public class MC
    {
        public string Nummerplade { get; set; }
        public DateTime dato { get; set; }

        public int Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }


    }
}
