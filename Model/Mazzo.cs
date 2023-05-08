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
        public string TipoMazzo { get; set; }
        public Carta[] Carte { get; set; } = new Carta[20];


        public Mazzo(string percorsoMazzo)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(percorsoMazzo);
            XmlNode node = doc.DocumentElement.SelectSingleNode("/root/TipoMazzo");

            this.TipoMazzo = node.InnerText;

            string[] domande = new string[4];

            for (int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    domande[j] = doc.DocumentElement.SelectSingleNode("/root/Carte[" + (i + 1) + "]/Risposte[" + (j + 1) + "]").InnerText;
                }

                Carte[i] = new Carta(doc.DocumentElement.SelectSingleNode("/root/Carte[" + (i + 1) +"]/Titolo").InnerText,
                                     doc.DocumentElement.SelectSingleNode("/root/Carte[" + (i + 1) +"]/Quesito").InnerText,
                                     doc.DocumentElement.SelectSingleNode("/root/Carte[" + (i + 1) +"]/RispostaCorretta").InnerText,
                                     domande);
            }
        }
    }
}
