using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransUteco.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransUteco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
            ObservableCollection<Clases.MasterPageItem.Menu> listas = new ObservableCollection<Clases.MasterPageItem.Menu>(new clsMasterPageViewModel().ConsultarMenu());
            Menu.ItemsSource = listas;
            BindingContext = new clsMasterPageViewModel.MasterPageViewModel();
        }

        private void btnCerrarSesion_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }
    }
}