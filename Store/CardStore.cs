using ProgettoInformatica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Store
{
    public class CardStore
    {
        public event Action CurrentCardChanged;
        private Carta _currentCarta;

        public Carta CurrentCarta { get { return _currentCarta; } set { _currentCarta = value;  OnCurrentCardChanged(); } }

        private void OnCurrentCardChanged()
        {
            CurrentCardChanged?.Invoke();
        }
    }
}
