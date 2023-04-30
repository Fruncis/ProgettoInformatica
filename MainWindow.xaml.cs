using ProgettoInformatica.Model;
using System.Windows;

namespace ProgettoInformatica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Mazzo primoMazzo = new Mazzo("./Data/mazzo-geografia.xml");
        }

    }
}
