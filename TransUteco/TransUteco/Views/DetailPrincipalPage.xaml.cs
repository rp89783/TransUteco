using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TransUteco.ViewModel;
using System.Collections.ObjectModel;
using TransUteco.Clases;

namespace TransUteco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPrincipalPage : ContentPage
    {
       
        public DetailPrincipalPage()
        {
            InitializeComponent();

            ObservableCollection<Clases.clsDetailPrincipal> listas = new ObservableCollection<Clases.clsDetailPrincipal>(new clsDetailPrincipalViewModel().Consultarlistas());
            Lista.ItemsSource = listas;

            //BindingContext = new clsDetailPrincipalViewModel();
       //Menu.ItemSelected += ListView_ItemSelected;
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        
        }

       
        private async void btnAsoeba_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AsociacionPage());
        }

        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
                var item = (clsDetailPrincipal)e.SelectedItem;
                
                clsAsociacion a = new clsAsociacion();
            a.Asociacion1 = item.Asociacion;
            a.Decripcion1 = item.Decripcion;
            a.Imagen1 = item.Imagen;
            await Navigation.PushAsync(new AsociacionPage());
            // Application.Current.MainPage = new AsociacionPage();


        }
    }
}