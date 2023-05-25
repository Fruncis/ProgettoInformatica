using ProgettoInformatica.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace ProgettoInformatica.Model
{
    public class GestioneGioco
    {
        //private readonly Mazzo mazzo = new Mazzo("C:\\Users\\Simone\\Downloads\\ProgettoInformatica-main\\Data\\mazzo-geografia.xml");
        //private readonly Mazzo mazzo = new Mazzo("C:\\Users\\francesco\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml");
        public List<Mazzo> mazzi = new List<Mazzo>();


        public List<Carta> mazzoCorrente { get; set; } //= new Mazzo("C:\\Users\\simone.bertolini\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml").Carte.ToList();
        


        private Giocatore Giocatore;
        //public event Action CartaCambiata;
        //public event PropertyChangedEventHandler? PropertyChanged;

        private static int index = 0;
        /*public Carta CartaCorrente { get { return _cartaCorrente; } set { _cartaCorrente = value; CambioCartaCorrente(); } }*/
        public GestioneGioco( Giocatore giocatore)
        {
            mazzi.Add(new Mazzo(Resources.mazzo_geografia));
            mazzi.Add(new Mazzo(Resources.mazzo_scienze));
            mazzi.Add(new Mazzo(Resources.mazzo_cinema));
            mazzi.Add(new Mazzo(Resources.mazzo_storia));
            mazzi.Add(new Mazzo(Resources.mazzo_sport));
            /*mazzi.Add(new Mazzo(Resources.mazzo_cucina));
            mazzi.Add(new Mazzo(Resources.mazzo_musica));
            mazzi.Add(new Mazzo(Resources.mazzo_religione));
            mazzi.Add(new Mazzo(Resources.mazzo_tecnologia));
            mazzi.Add(new Mazzo(Resources.mazzo_arte));*/
            //System.Diagnostics.Debug.WriteLine(Directory.GetCurrentDirectory() + "\\Data\\mazzo-geografia.xml");
            Giocatore = giocatore;
            Giocatore.PropertyChanged += OnGiocatoreChanged;
            mazzoCorrente = mazzi[index].Carte.ToList();
        }

        public void OnGiocatoreChanged(object source, EventArgs args)
        {
            Giocatore = (Giocatore)source;
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
                System.Diagnostics.Debug.WriteLine(carta);
                Carta tmp = mazzoCorrente[carta];
                System.Diagnostics.Debug.WriteLine(tmp.RipostaCorretta);
                mazzoCorrente.RemoveAt(carta);

                return tmp;
            }
            else
            {
                return null;
            }
                

        }


        public void ConvertPuntiEsperienzaGettoni(int punti)//Aggiustare la proporzione dei gettoni e dell'esperienza
        {
            Giocatore.Gettoni += (int)Math.Round(punti * 1.5);
            Giocatore.Esperienza += (int)Math.Round(punti * 1.2);
        }

        public void SaliDiLivello()
        {
            switch(Giocatore.Esperienza) { 
                case < 100:
                    Giocatore.Livello = 1;
                    break;
                case < 250:
                    Giocatore.Livello = 2;
                    Giocatore.MaxEsperienza = 250;
                    break;
                case < 500:
                    Giocatore.Livello = 3;
                    Giocatore.MaxEsperienza = 500;
                    break;
                case < 800:
                    Giocatore.Livello = 4;
                    Giocatore.MaxEsperienza = 800;
                    break;
                case < 1100:
                    Giocatore.Livello = 5;
                    Giocatore.MaxEsperienza = 1100;
                    break;
                case < 1600:
                    Giocatore.Livello = 6;
                    Giocatore.MaxEsperienza = 1600;
                    break;
                case < 2200:
                    Giocatore.Livello = 7;
                    Giocatore.MaxEsperienza = 2200;
                    break;
                case < 3100:
                    Giocatore.Livello = 8;
                    Giocatore.MaxEsperienza = 3100;
                    break;
                case < 4200:
                    Giocatore.Livello = 9;
                    Giocatore.MaxEsperienza = 4200;
                    break;
                case < 5500:
                    Giocatore.Livello = 10;
                    break;
                default: break;
            }
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


    }
}
