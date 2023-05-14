using ProgettoInformatica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Store
{
    public static class Giocatore
    {
        public static int Livello { get; set; }
        public static int Esperienza { get; set; }
        public static List<Mazzo>? MazziPosseduti { get; set; }
        public static int Gettoni { get; set; }
    }
}
