using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TransUteco.Clases;
using System.ComponentModel;

namespace TransUteco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        //public  string Nombreusurio { get; set; } = clsConstantes.Nombreusurio;
        //public  string Clave { get; set; } = clsConstantes.Clave;
        public string ClaveOlvidada { get; set; } = clsConstantes.ClaveOlvidada;
        public string BotonAcceder { get; set; } = clsConstantes.BotonAcceder;
        public string BotonRegistrarse { get; set; } = clsConstantes.BotonRegistrarse;
        public LoginPage()
        {

            InitializeComponent();
            BindingContext = this;
          //  BindingContext = new LoginViewModel();
        }
        public class LoginViewModel : INotifyPropertyChanged
        {
            private string _Email;

            public string Email
            {
                get { return _Email; }
                set
                {
                    if (_Email != value)
                    {
                        _Email = value;
                        PropertyChanged(this, new PropertyChangedEventArgs("Email"));
                    }
                }
            }
            private string _Clave;

            public string Clave
            {
                get { return _Clave; }
                set
                {
                    if (value != _Clave)
                    {
                        _Clave = value;
                        PropertyChanged(this, new PropertyChangedEventArgs("Clave"));
                    }
                }
            }


            public event PropertyChangedEventHandler PropertyChanged;
        }
        private void btnRegistar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegistrarPage();

        }

        private void btnAcceder_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}