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
        public List<Carta> mazzoCorrente; //= new Mazzo("C:\\Users\\simone.bertolini\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml").Carte.ToList();

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

        /*public string RispostaAvversario(int difficolta)
        {
            List<string> risposte = CartaCorrente.Risposte.ToList();

            Random random = new Random();
            int risposta = random.Next(0, 3);

            if (risposta < 7 + difficolta)
            {
                return CartaCorrente.RipostaCorretta;
            }
            else
            {
                risposte.Remove(CartaCorrente.RipostaCorretta);
                risposta = random.Next(0, 2);
                return risposte[risposta];
            }
        }

        private void CambioCartaCorrente()
        {
            CartaCambiata?.Invoke();
        }*/

    }
}
