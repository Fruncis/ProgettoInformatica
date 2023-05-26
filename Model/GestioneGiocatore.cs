using ProgettoInformatica.Properties;
using ProgettoInformatica.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProgettoInformatica.Model
{
    public class GestioneGiocatore
    {
        private Giocatore Giocatore;

        private XmlDocument doc = new XmlDocument();
        public GestioneGiocatore(Giocatore giocatore)
        {
            Giocatore = giocatore;
            Giocatore.PropertyChanged += OnGiocatoreChanged;
        }
        public void OnGiocatoreChanged(object source, EventArgs args)
        {
            Giocatore = (Giocatore)source;
        }
        public void Salva()
        {
            string formattazione = "<root>" +
                "<giocatore>" +
                "<livello>" + Giocatore.Livello + "</livello>" +
                "<esperienza>" + Giocatore.Esperienza + "</esperienza>" +
                "<mazzi-posseduti>";

            for (int i = 0; i < Giocatore.MazziPosseduti.Count; i++)
            {
                formattazione += "<mazzo>" + Giocatore.MazziPosseduti[i].TipoMazzo + "</mazzo>";
            }

            formattazione += "</mazzi-posseduti>" +
                "<gettoni>" + Giocatore.Gettoni + "</gettoni>" +
                "</giocatore>" +
                "</root>";

            File.WriteAllText("./Model/saves.xml", formattazione);
            System.Diagnostics.Debug.WriteLine("ww");
        }

        public void CaricaSalvataggio()
        {
            

            int giocatore = 1;
            doc.Load("./Model/saves.xml");

            this.Giocatore.Livello = int.Parse(doc.DocumentElement.SelectSingleNode("/root/giocatore[" + giocatore + "]/livello").InnerText);
            this.Giocatore.Esperienza = int.Parse(doc.DocumentElement.SelectSingleNode("/root/giocatore[" + giocatore + "]/esperienza").InnerText);
            
            for (int i = 1; i < doc.SelectNodes("/root/giocatore[" + giocatore + "]/mazzi-posseduti/mazzo").Count; i++)
            {
                this.Giocatore.MazziPosseduti.Add(new Mazzo(TypeToPath(doc.DocumentElement.SelectSingleNode("/root/giocatore[" + giocatore + "]/mazzi-posseduti/mazzo[" + i + "]").InnerText)));
            }

            this.Giocatore.Gettoni = int.Parse(doc.DocumentElement.SelectSingleNode("/root/giocatore[" + giocatore + "]/gettoni").InnerText);
        }
        
        public bool isXMLEmpty()
        {
            doc.Load("./Model/saves.xml");
            if (doc.GetElementById("root") == null || doc.GetElementById("root").HasChildNodes)
            {
                // The XML file is empty
                return true;
            }
            return false;
        }

        private string TypeToPath(string tipoMazzo)
        {
            string path;
            
            switch(tipoMazzo)
            {
                case "Geografia":
                    path = "mazzo-geografia.xml";
                    break;
                case "Scienze":
                    path = "mazzo-scienze.xml";
                    break;
                case "Storia":
                    path = "mazzo-storia.xml";
                    break;
                case "Sport":
                    path = "mazzo-sport.xml";
                    break;
                case "Cinema":
                    path = "mazzo-cinema.xml";
                    break;
                default:
                    path = null;
                    break;
            }
            
            return path;
        }



    }
}