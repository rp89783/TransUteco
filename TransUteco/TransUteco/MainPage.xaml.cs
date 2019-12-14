using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransUteco.Clases;
using TransUteco.ViewModel;
using TransUteco.Views;
using Xamarin.Forms;

namespace TransUteco
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            ObservableCollection<Clases.MasterPageItem.Menu> listas = new ObservableCollection<Clases.MasterPageItem.Menu>(new clsMasterPageViewModel().ConsultarMenu());
            Menu.ItemsSource = listas;
            BindingContext = new clsMasterPageViewModel.MasterPageViewModel();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.DetailPrincipalPage)));

        }
        //    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    //var itemType = e.SelectedItem as Clases.MasterPageItem.Menu;
        //    //if (itemType != null)
        //    //{
        //    //    var page = (Page)Activator.CreateInstance(itemType.PageName);
        //    //    Detail = new NavigationPage(page);
        //    //    //masterPage.listView.SelectedItem = null;
        //    //    IsPresented = false;
        //    //}


        //    var item = (MasterPageItem.Menu)e.SelectedItem;
        //    Type page = item.PageName;

        //    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
        //    IsPresented = false;
        //}
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem.Menu)e.SelectedItem;
            Type page = item.PageName;
            clsAsociacion a = new clsAsociacion();
            a.Asociacion1 = item.Title;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
        public async void IrADetalle(object sender, EventArgs events)
        {
            await Navigation.PushAsync(new Views.DetailPrincipalPage());
        }
    }
}
