using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Model
{
    public class Carta
    {
        public string Titolo { get; set; }
        public string Quesito { get; set; }
        public string[] Risposte { get; set; }
        public string RipostaCorretta { get; set; }


        public Carta(string titolo, string quesito, string rispostaCorretta, string[] risposte)
        {
            Titolo = titolo;
            Quesito = quesito;
            RipostaCorretta = rispostaCorretta;
            Risposte = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Risposte[i] = risposte[i];
            }
            
        }

    }
}
