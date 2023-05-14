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
            
            for (int i = 1; i < doc.SelectNodes("/root/giocatore[" + giocatore + "]/mazzi-posseduti/mazzo").Count; i++)
            {
                Giocatore.MazziPosseduti.Add(new Mazzo(TypeToPath(doc.DocumentElement.SelectSingleNode("/root/giocatore[" + giocatore + "]/mazzi-posseduti/mazzo[" + i + "]").InnerText)));
            }

            Giocatore.Gettoni = int.Parse(doc.DocumentElement.SelectSingleNode("/root/giocatore[" + giocatore + "]/gettoni").InnerText);
        }
        
        private string TypeToPath(string tipoMazzo)
        {
            string path;
            
            switch(tipoMazzo)
            {
                case "Geografia":
                    path = "mazzo-geografia.xml";
                    break;
                case "Storia":
                    path = "mazzo-storia.xml";
                    break;
                default:
                    path = null;
                    break;
            }
            
            return path;
        }



    }
}