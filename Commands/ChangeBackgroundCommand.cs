using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
using ProgettoInformatica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ProgettoInformatica.Commands
{
    class ChangeBackgroundCommand : CommandBase
    {

        private  GameWindowViewModel _gameWindowViewModel;
        public ChangeBackgroundCommand(GameWindowViewModel gameWindowViewModel)
        {
            _gameWindowViewModel = gameWindowViewModel;
        }


        private void checkResponse(Button button)
        {
            System.Diagnostics.Debug.WriteLine("1");
            if (!button.Content.ToString().Equals(CartaCorrente.cartaCorrente.RipostaCorretta))
            {
                System.Diagnostics.Debug.WriteLine("2");
                button.Background = Brushes.Red;
                /*button.Background = Brushes.Transparent;*/
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("3");
                button.Background = Brushes.Green;
                
                
                /*button.Background = Brushes.Transparent;*/
                


            }
            button.Foreground = Brushes.White;
            CartaCorrente.cartaCorrente = _gameWindowViewModel.GestioneGioco.PescaCarta();
            _gameWindowViewModel.QuesitoCorrente = CartaCorrente.cartaCorrente.Quesito;
            _gameWindowViewModel.RisposteCorrenti = CartaCorrente.cartaCorrente.Risposte;
            button.Foreground = new SolidColorBrush(Color.FromRgb(255, 127, 80));
            button.Background = Brushes.Transparent;
            /*_gameWindowViewModel.isAnswered = true; 
            //_gameWindowViewModel.isAnswered = false;*/
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }


        public override void Execute(object parameter)
        {
            if (parameter is Button button)
            {
                checkResponse(button);
            }
        }
    }
}
