using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TransUteco.Clases;
using Xamarin.Forms;

namespace TransUteco.ViewModel
{
    class clsLoginViewModel
    {
        public class LoginViewModel : BaseViewModel
        {
            public string EmailPH { get; set; } = clsConstantes.Email;
            public string ClavePH { get; set; } = clsConstantes.Clave;
            public string ClaveOlvidada { get; set; } = clsConstantes.ClaveOlvidada;
            public string BotonAcceder { get; set; } = clsConstantes.BotonAcceder;
            public string BotonRegistrarse { get; set; } = clsConstantes.BotonRegistrarse;
            public string SwichRecordar { get; set; } = clsConstantes.SwichRecordar;

            private string email;

            public string Email
            {
                get { return email; }
                set
                {
                    if (value != email)
                    {
                        SetProperty(ref email, value, "Email");
                    }

                }
            }
            private string clave;

            public string Clave
            {
                get { return clave; }
                set
                {
                    SetProperty(ref clave, value, "Clave");

                }
            }

            private void SetProperty(ref string email, string value, string v)
            {
                throw new NotImplementedException();
            }

            
        
        public ICommand OnLogin { get; set; }
        
            public LoginViewModel()
            {
                OnLogin = new Command(Login);
             }

            protected  void Login()
            {

                if (email != "admin" && clave != "123")
                {
                    Application.Current.MainPage.DisplayAlert("error", "credenciales errornesas", "Ok");
                    return;
                }
                Application.Current.MainPage.DisplayAlert("Bienvenido", "Hola"+email, "Ok");

            }


        }
    }
}
