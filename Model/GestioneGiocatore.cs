using ProgettoInformatica.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProgettoInformatica.Model
{
    class GestioneGiocatore
    {
        /*public GestioneGiocatore(int livello, int esperienza, List<Mazzo> mazziPosseduti, int gettoni)
        {
            Giocatore.Livello = livello;
            Giocatore.Esperienza = esperienza;
            Giocatore.MazziPosseduti = mazziPosseduti;
            Giocatore.Gettoni = gettoni;
        }*/

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

            File.WriteAllText("saves.xml", formattazione);
        }

        public void CaricaSalvataggio(int giocatore)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("saves.xml");
            

            Giocatore.Livello = int.Parse(doc.DocumentElement.SelectSingleNode("/root/giocatore[" + giocatore + "]/livello").InnerText);
            Giocatore.Esperienza = int.Parse(doc.DocumentElement.SelectSingleNode("/root/giocatore[" + giocatore + "]/esperienza").InnerText);
            // da fare: inserimento mazzi posseduti
            Giocatore.Gettoni = int.Parse(doc.DocumentElement.SelectSingleNode("/root/giocatore[" + giocatore + "]/gettoni").InnerText);
        }



    }
}
