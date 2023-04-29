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


        public Carta(string titolo, string quesito, string rispostaCorretta, string risposta1, string risposta2, string risposta3, string risposta4)
        {
            this.Titolo = titolo;
            this.Quesito = quesito;
            this.RipostaCorretta = rispostaCorretta;
            this.Risposte = new string[4];
            this.Risposte[0] = risposta1;
            this.Risposte[1] = risposta2;
            this.Risposte[2] = risposta3;
            this.Risposte[3] = risposta4;
        }

    }
}
