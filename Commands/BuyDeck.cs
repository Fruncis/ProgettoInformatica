using ProgettoInformatica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProgettoInformatica.Commands
{
    
    class BuyDeck : CommandBase
    {
        private ShopWindowViewModel _shopWindowViewModel;

        //private Dictionary<string, int> deckDict = new Dictionary<string, int>(); 

        public BuyDeck(ShopWindowViewModel shopWindowViewModel)
        {
            
            _shopWindowViewModel = shopWindowViewModel;
        }
        public override void Execute(object? parameter)
        {

            if (parameter is Button button )
            {
                System.Diagnostics.Debug.WriteLine(button.Name + "sfa");

            }
        }
    }
}
