using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Model
{
    public class ClasseTemporanea
    {
        Mazzo Mazzo { get; set; }
        public static List<Carta> MazzoCorrente = new Mazzo("C:\\Users\\simone.bertolini\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml").Carte.ToList();

        public ClasseTemporanea()
        {
        }

        public Carta PescaCarta()
        {
            Random random = new Random();
            int carta = random.Next(0, MazzoCorrente.Count);

            MazzoCorrente.RemoveAt(carta);

            return MazzoCorrente[carta];

        }

        public string RispostaAvversario(int carta, int difficolta)
        {
            Random random = new Random();
            int risposta = random.Next(0, 3);

            List<string> risposte = this.Mazzo.Carte[carta].Risposte.ToList();



            if (carta < 6 + difficolta)
            {
                return this.Mazzo.Carte[carta].RipostaCorretta;
            }
            else
            {
                risposte.Remove(this.Mazzo.Carte[carta].RipostaCorretta);
                risposta = random.Next(0, 2);
                return risposte[risposta];
            }
        }
    }
}
