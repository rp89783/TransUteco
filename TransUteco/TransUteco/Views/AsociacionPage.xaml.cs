using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TransUteco.Clases;

namespace TransUteco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AsociacionPage : ContentPage
    {
        public AsociacionPage()
        {
            InitializeComponent();

            Cargar();
        }

        private async void Cargar()
        {
            try
            {
                clsRutasManager manager = new clsRutasManager();
                var res = await manager.getRuta();

                if (res != null)
                {
                    listRutas.ItemsSource = res; 
                }
            }
            catch (Exception)
            {

                throw;
            }
        
        }
    }
}