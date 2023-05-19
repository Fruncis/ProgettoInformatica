using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Model
{
    public class Giocatore
    {
        public static int Livello { get; set; } = 1;
        public static int Esperienza { get; set; } = 0;
        public static List<Mazzo> MazziPosseduti { get; set; }
        public static int Gettoni { get; set; } = 0;
    

    }
}
