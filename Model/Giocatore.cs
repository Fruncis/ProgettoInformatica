using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Model
{
    public class Giocatore : ObservableObject
    {


        private int _livello;
        public int Livello
        {
            get
            {
                return _livello;
            }
            set
            {
                if(_livello != value)
                {
                    _livello = value;
                    OnPropertyChanged();
                }
                
            }
        }

        private int _esperienza;
        public int Esperienza
        {
            get
            {
                return _esperienza;
            }
            set
            {
                if (_esperienza != value)
                {
                    _esperienza = value;
                    OnPropertyChanged();
                }

            }
        }

        private int _gettoni;
        public int Gettoni
        {
            get
            {
                return _gettoni;
            }
            set
            {
                if (_gettoni != value)
                {
                    _gettoni = value;
                    OnPropertyChanged();
                }

            }
        }

        private List<Mazzo> _mazziPosseduti;
        public List<Mazzo> MazziPosseduti
        {
            get
            {
                return _mazziPosseduti;
            }
            set
            {
                if (_mazziPosseduti != value)
                {
                    _mazziPosseduti = value;
                   
                }
                OnPropertyChanged();
            }
        }

        public Giocatore()
        {
            Livello = 1;
            Esperienza = 0;
            Gettoni = 0;
        }

        
    }
}
