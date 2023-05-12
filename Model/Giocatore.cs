using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Model
{
    class Giocatore
    {
        public int Livello { get; set; }
        public int Esperienza { get; set; }
        public List<Mazzo> MazziPosseduti { get; set; }
        public int Gettoni { get; set; }


        public void Salva(int livello, int esperienza, List<Mazzo> mazziPosseduti, int gettoni)
        {
            string formattazione = "<giocatore>" +
                "<livello>" + livello + "</livello>" +
                "<esperienza>" + esperienza + "</esperienza>" +
                "<mazzi-posseduti>";

            for (int i = 0; i < mazziPosseduti.Count; i++)
            {
                formattazione += "<mazzo>" + mazziPosseduti[i].TipoMazzo + "</mazzo>";
            }

            formattazione += "<mazzi-posseduti>" +
                "<gettoni>" + gettoni + "</gettoni>" +
                "</giocatore>";



            
        }
    }
}
