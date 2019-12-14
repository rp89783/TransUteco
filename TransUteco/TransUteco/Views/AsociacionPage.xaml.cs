using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TransUteco.Clases;
using TransUteco.ViewModel;

namespace TransUteco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AsociacionPage : ContentPage
    {
        public AsociacionPage()
        {
            InitializeComponent();
            BindingContext = new clsAsociacionViewModel();
           
        }

       
    }
}