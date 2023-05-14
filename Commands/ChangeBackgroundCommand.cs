using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
using ProgettoInformatica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
            SolidColorBrush backgroundColor;
            /*SolidColorBrush foregroundColor = new SolidColorBrush(Color.FromRgb(255, 127, 80));
            Duration animationDuration = new Duration(TimeSpan.FromSeconds(2));
            ColorAnimation backgroundAnimation = new ColorAnimation(Colors.Green, Colors.Transparent, animationDuration);
            ColorAnimation foregroundAnimation = new ColorAnimation(Colors.White, foregroundColor.Color, animationDuration);*/
            if (!button.Content.ToString().Equals(CartaCorrente.cartaCorrente.RipostaCorretta))
            {
                backgroundColor = new SolidColorBrush(Color.FromRgb(255, 0, 0)); 
                //button.Background.BeginAnimation(SolidColorBrush.ColorProperty, backgroundAnimation);
                /*button.Background = Brushes.Transparent;*/
            }
            else
            {
                backgroundColor = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                //button.Background.BeginAnimation(SolidColorBrush.ColorProperty, backgroundAnimation);

                /*button.Background = Brushes.Transparent;*/



            }
            //button.Foreground = Brushes.White;
            _gameWindowViewModel.isAnswered = true;
            //AnswerAnimation(backgroundColor, button);
            /*TimeSpan ts = new TimeSpan(0, 0, 5);
            Thread.Sleep(ts);*/
            CartaCorrente.cartaCorrente = _gameWindowViewModel.GestioneGioco.PescaCarta();
            _gameWindowViewModel.QuesitoCorrente = CartaCorrente.cartaCorrente.Quesito;
            _gameWindowViewModel.RisposteCorrenti = CartaCorrente.cartaCorrente.Risposte;
            


            _gameWindowViewModel.isAnswered = false;
        }


        /*private void AnswerAnimation(SolidColorBrush bordercolor, Button button)
        {
            SolidColorBrush brush = new SolidColorBrush();


            ColorAnimation answerAnimation1 = new ColorAnimation();
            answerAnimation1.Duration = new Duration(TimeSpan.FromSeconds(6));
            answerAnimation1.From = Colors.Transparent;
            answerAnimation1.To = Colors.LightGray;
            answerAnimation1.AutoReverse = true;
            answerAnimation1.RepeatBehavior = RepeatBehavior.Forever;

            // Set the animations on the border's BorderBrush property
            brush.BeginAnimation(SolidColorBrush.ColorProperty, answerAnimation1);

            // Set the border's BorderBrush property to the animated brush
            button.BorderThickness = new Thickness(10);
            button.BorderBrush = brush;

        }*/

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
