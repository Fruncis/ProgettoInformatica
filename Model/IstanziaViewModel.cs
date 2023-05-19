using ProgettoInformatica.Store;
using ProgettoInformatica.ViewModels;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Model
{
    public class IstanziaViewModel<T> where T : ViewModelBase
    {
        
        
        //private static IDictionary<string, T> viewModelInstance = new Dictionary<string, T>();

        public static T CurrentWindowViewModel { get; set; }
        public static T gameWindowViewModel { get; set; }
        public static T shopWindowViewModel { get; set; }

        public static T menuWindowViewModel { get; set; }

        public static T Istanzia(NavigationStore navigationStore)
        {
            

            if(typeof(T).Name.Equals("GameWindowViewModel") && gameWindowViewModel != null)
            {
                return gameWindowViewModel;
            }
            else if(typeof(T).Name.Equals("ShopWindowViewModel") && shopWindowViewModel != null) 
            {
                return shopWindowViewModel;
            }
            else if (typeof(T).Name.Equals("MenuWindowViewModel") && menuWindowViewModel != null)
            {
                return menuWindowViewModel;
            }


            System.Diagnostics.Debug.WriteLine("cippiciappi");
            CurrentWindowViewModel = (T)Activator.CreateInstance(typeof(T), new object[] { navigationStore });

            if (typeof(T).Name.Equals("GameWindowViewModel") && gameWindowViewModel == null)
            {
                gameWindowViewModel = CurrentWindowViewModel;
            }
            else if (typeof(T).Name.Equals("ShopWindowViewModel") && shopWindowViewModel == null)
            {
                shopWindowViewModel = CurrentWindowViewModel;
            }
            else if (typeof(T).Name.Equals("MenuWindowViewModel") && menuWindowViewModel == null)
            {
                menuWindowViewModel = CurrentWindowViewModel;
            }
            //viewModelInstance["MenuWindowViewModel"] = true;

            return CurrentWindowViewModel;


        }
       /* private readonly NavigationStore _navigationStore;

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        private static Lazy<T> _istanziaViewModel;

        public static T IstanzaViewModel;
        public static IstanziaViewModel<T> Istanza { get; } = new IstanziaViewModel<T>(_navigationStore);

        private IstanziaViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            _istanziaViewModel = new Lazy<T>(() => (T)Activator.CreateInstance(typeof(T), new object[] { navigationStore }));
            IstanzaViewModel = _istanziaViewModel.Value;
            //Istanza = new IstanziaViewModel<T>(navigationStore);
            //IstanzaGameViewModel.navigationStore = navigationStore;
        }


        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }*/


    }
}
