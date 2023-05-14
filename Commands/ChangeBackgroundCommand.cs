using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
using ProgettoInformatica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

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
            /*SolidColorBrush foregroundColor = new SolidColorBrush(Color.FromRgb(255, 127, 80));
            Duration animationDuration = new Duration(TimeSpan.FromSeconds(2));
            ColorAnimation backgroundAnimation = new ColorAnimation(Colors.Green, Colors.Transparent, animationDuration);
            ColorAnimation foregroundAnimation = new ColorAnimation(Colors.White, foregroundColor.Color, animationDuration);*/
            if (!button.Content.ToString().Equals(CartaCorrente.cartaCorrente.RipostaCorretta))
            {
                button.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0)); 
                //button.Background.BeginAnimation(SolidColorBrush.ColorProperty, backgroundAnimation);
                /*button.Background = Brushes.Transparent;*/
            }
            else
            {
                button.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                //button.Background.BeginAnimation(SolidColorBrush.ColorProperty, backgroundAnimation);

                /*button.Background = Brushes.Transparent;*/



            }
            //button.Foreground = Brushes.White;
            CartaCorrente.cartaCorrente = _gameWindowViewModel.GestioneGioco.PescaCarta();
            _gameWindowViewModel.QuesitoCorrente = CartaCorrente.cartaCorrente.Quesito;
            _gameWindowViewModel.RisposteCorrenti = CartaCorrente.cartaCorrente.Risposte;
            

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
