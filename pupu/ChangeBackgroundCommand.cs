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
using System.Windows.Annotations;
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
            Color backgroundColor;
            const int animationTime = 7;
            /*SolidColorBrush foregroundColor = new SolidColorBrush(Color.FromRgb(255, 127, 80));
            Duration animationDuration = new Duration(TimeSpan.FromSeconds(2));
            ColorAnimation backgroundAnimation = new ColorAnimation(Colors.Green, Colors.Transparent, animationDuration);
            ColorAnimation foregroundAnimation = new ColorAnimation(Colors.White, foregroundColor.Color, animationDuration);*/
            if (!button.Content.ToString().Equals(CartaCorrente.cartaCorrente.RipostaCorretta))
            {
                backgroundColor = Color.FromRgb(255, 0, 0);
                _gameWindowViewModel.Punti += 1;
                _gameWindowViewModel.timer.Stop();
                _gameWindowViewModel.timer.Start();
                //button.Background.BeginAnimation(SolidColorBrush.ColorProperty, backgroundAnimation);
                /*button.Background = Brushes.Transparent;*/
            }
            else
            {
                backgroundColor = Color.FromRgb(0, 255, 0);
                //button.Background.BeginAnimation(SolidColorBrush.ColorProperty, backgroundAnimation);

                /*button.Background = Brushes.Transparent;*/



            }
            //button.Foreground = Brushes.White;
            _gameWindowViewModel.isAnswered = true;
            AnswerAnimation(backgroundColor, button, animationTime);
            _gameWindowViewModel.DelayedCodeExecution(animationTime);
            /*TimeSpan ts = new TimeSpan(0, 0, 5);
            Thread.Sleep(ts);*/

        }


        private void AnswerAnimation(Color bordercolor, Button button, int animationTime)
        {
            SolidColorBrush brush = new SolidColorBrush();
            const int borderThickness = 5;

            ColorAnimationUsingKeyFrames answerAnimation1 = new ColorAnimationUsingKeyFrames();
            answerAnimation1.Duration = TimeSpan.FromSeconds(animationTime);

            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.LightGray,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1)))
                );
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.Transparent,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.5)))
                );
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.LightGray,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2)))
                );
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.Transparent,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2.5)))
                );
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.LightGray,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(3)))
                );
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.Transparent,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(3.5)))
                );
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.LightGray,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(4)))
                );
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.Transparent,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(4.5)))
                );
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.LightGray,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5)))
                );
            /*answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.Transparent,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5.5)))
                );*/
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    bordercolor,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5.5)))
                );
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    bordercolor,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(6.75)))
                );
            answerAnimation1.KeyFrames.Add(
                new LinearColorKeyFrame(
                    Colors.Transparent,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(7)))
                );

            brush.BeginAnimation(SolidColorBrush.ColorProperty, answerAnimation1);



            ControlTemplate buttonTemplate = button.Template;
            Border border = (Border)buttonTemplate.FindName("ButtonBorder", button);

            border.BorderThickness = new Thickness(borderThickness);
            border.BorderBrush = brush;
            

        }
        

        public bool CanExecute(object parameter)
        {
            return _gameWindowViewModel.isAnswered;
        }


        public override void Execute(object parameter)
        {
            
            if (parameter is Button button && !CanExecute(parameter))
            {
                checkResponse(button);
                
            }
        }
    }
}
