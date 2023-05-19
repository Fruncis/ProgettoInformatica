using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Model
{
    public class GestioneGioco// : INotifyPropertyChanged
    {
        Mazzo mazzo;
        public List<Carta> mazzoCorrente { get; set; } //= new Mazzo("C:\\Users\\simone.bertolini\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml").Carte.ToList();
        public int MaxEsperienza { get; set; } = 100;

        //public event Action CartaCambiata;
        //public event PropertyChangedEventHandler? PropertyChanged;


        /*public Carta CartaCorrente { get { return _cartaCorrente; } set { _cartaCorrente = value; CambioCartaCorrente(); } }*/
        public GestioneGioco(Mazzo mazzo)
        {
            this.mazzo = mazzo;
            mazzoCorrente = mazzo.Carte.ToList();
        }
        public GestioneGioco(List<Carta> mazzoCorrente)
        {
            this.mazzoCorrente = mazzoCorrente;
        }

        public Carta? PescaCarta()
        {
            if (mazzoCorrente.Count > 0)
            {
                Random random = new Random();
                int carta = random.Next(0, mazzoCorrente.Count);

                Carta tmp = mazzoCorrente[carta];
                System.Diagnostics.Debug.WriteLine(tmp.RipostaCorretta);
                mazzoCorrente.RemoveAt(carta);

                return tmp;
            }
            else
                return null;

        }

        public void ConvertPuntiEsperienzaGettoni(int punti)
        {
            Giocatore.Gettoni += punti * 3;
            Giocatore.Esperienza += punti * 2;
        }

        public string RispostaAvversario(int difficolta, Carta cartaCorrente)
        {
            List<string> risposte = cartaCorrente.Risposte.ToList();

            Random random = new Random();
            int risposta = random.Next(0, 3);

            if (risposta < 7 + difficolta)
            {
                return cartaCorrente.RipostaCorretta;
            }
            else
            {
                risposte.Remove(cartaCorrente.RipostaCorretta);
                risposta = random.Next(0, 2);
                return risposte[risposta];
            }
        }

        /*private void CambioCartaCorrente()
        {
            CartaCambiata?.Invoke();
        }*/

    }
}
