using ProgettoInformatica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProgettoInformatica.Commands
{
    public class BuyDeck : CommandBase
    {
        private ShopWindowViewModel _shopWindowViewModel;

        public BuyDeck(ShopWindowViewModel shopWindowViewModel)
        {
            _shopWindowViewModel = shopWindowViewModel;
        }

        public override void Execute(object? parameter)
        {
            if (parameter is Button button)
            {


            }
        }
    }
}
