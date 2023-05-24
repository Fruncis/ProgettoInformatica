using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace ProgettoInformatica.Model
{
    public class Mazzo
    {
        const int numCarte = 10;
        const int numRisposte = 4;
        public string TipoMazzo { get; set; }

        public string Livello { get; set; }
        public Carta[] Carte { get; set; } = new Carta[numCarte];


        public Mazzo(string percorsoMazzo)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(percorsoMazzo);
            
            this.TipoMazzo = doc.DocumentElement.SelectSingleNode("/Carte/TipoMazzo").InnerText;

            Livello = doc.DocumentElement.SelectSingleNode("/Carte/Livello").InnerText;

            string[] risposte = new string[4];

            for (int i = 0; i < numCarte; i++)
            {
                for(int j = 0; j < numRisposte; j++)
                {
                    System.Diagnostics.Debug.WriteLine(i);
                    risposte[j] = doc.DocumentElement.SelectSingleNode("/Carte/Carta[" + (i + 1) + "]/Risposte[" + (j + 1) + "]").InnerText;
                    //System.Diagnostics.Debug.WriteLine(domande[j]);
                }

                Carte[i] = new Carta(doc.DocumentElement.SelectSingleNode("/Carte/Carta[" + (i + 1) +"]/Titolo").InnerText,
                                     doc.DocumentElement.SelectSingleNode("/Carte/Carta[" + (i + 1) +"]/Quesito").InnerText,
                                     doc.DocumentElement.SelectSingleNode("/Carte/Carta[" + (i + 1) +"]/RispostaCorretta").InnerText,
                                     risposte);
            }
        }
    }
}
