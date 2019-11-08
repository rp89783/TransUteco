using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            masterPage.listView.ItemSelected += ListView_ItemSelected;
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var itemType = e.SelectedItem as Clases.MasterPageItem;
            if (itemType != null)
            {
                var page = (Page)Activator.CreateInstance(itemType.TargetType);
                Detail = new NavigationPage(page);
                masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }

        public async void IrADetalle(object sender, EventArgs events)
        {
            await Navigation.PushAsync(new Views.DetailPrincipalPage());
        }
    }
}
