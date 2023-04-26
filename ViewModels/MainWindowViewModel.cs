using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProgettoInformatica.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public RelayCommand ClickCommandEvent { get; set; }

        public MainWindowViewModel()
        {
            ClickCommandEvent = new RelayCommand(ClickExecute);
            
        }

        public void ClickExecute(object param)
        {
            System.Diagnostics.Debug.WriteLine($"Clicked: Cacca");
        }

        public string _name = "cracrapu";
        public string Name 
        { 
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
            } 
        }
    }
}
