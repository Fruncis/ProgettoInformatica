using ProgettoInformatica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ProgettoInformatica.Commands
{
    public class VolumePopUpCommand : CommandBase
    {
        private bool isVolumePressed;
        public VolumePopUpCommand(bool _isVolumePressed)
        {
            isVolumePressed = _isVolumePressed;
        }
        public override void Execute(object? parameter)
        {
            System.Diagnostics.Debug.WriteLine("per: " + isVolumePressed);
            if (parameter is Button button)
            {
                if(isVolumePressed)
                {
                    isVolumePressed = false;
                }
                else
                {
                    isVolumePressed = true;
                }
            }
            System.Diagnostics.Debug.WriteLine("post: " + isVolumePressed);
        }
    }
}
