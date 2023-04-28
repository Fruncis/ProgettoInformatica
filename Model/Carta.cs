using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Model
{
    public class Carta
    {
        private string _titolo;
        public string Titolo { get; set; }
        private string _quesito;
        public string Quesito { get; set; }
        private string[] _risposte;
        public string[] Risposte { get; set; }
        private string _ripostaCorretta;
        public string RipostaCorretta { get; set; }


        public Carta(string titolo, string quesito, string rispostaCorretta, string[] risposte)
        {
            _titolo = titolo;
            _quesito = quesito;
            _ripostaCorretta = rispostaCorretta;
            _risposte = new string[4];
            for(int i=0; i<4; i++)
            {
                _risposte[i] = risposte[i]; 
            }
        }
    }
}
