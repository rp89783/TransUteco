using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TransUteco.Clases;
using TransUteco.Services;
using TransUteco.Views;
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
            
            //String a= NSUserDefaults.StandardUserDefaults.StringForKey("txtNombreUsuario");
         

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




            public ICommand OnLogin { get; set; }
            public ICommand OnRegistar { get; set; }
            WebServices webService;

            public LoginViewModel()
            {
                OnLogin = new Command(async () => await Login());
                OnRegistar = new Command(Registar);
                webService = new WebServices();

            }

            private async Task Login()
            {
                if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Clave))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Campos necesario", "Ok");
                    return;
                }

                //var response = await webService.Login(new LoginRequest()
                //{
                //    email = Email,
                //    password = clave
                //});

                //if (response == null)
                //{
                //    await Application.Current.MainPage.DisplayAlert("Error", "Ocurrio un error durante el login", "Ok");
                //    return;
                //}

                //if(Email=="a" && Clave=="1")
                //{

                //}

                MasterPageItem.DatosUsuario.Nombre = Email;


                //NSUserDefaults.StandardUserDefaults.SetString(Email, "txtNombreUsuario");
                //var a = NSUserDefaults.StandardUserDefaults.StringForKey("txtNombreUsuario");


                //await Application.Current.MainPage
                //.Navigation
                //.PushModalAsync(new NavigationPage(new MainPage()));
                
                Application.Current.MainPage = new MainPage();


                    

                    //Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(new MainPage()));
                


            }

            private void Registar()
            {
                
                 

                        Application.Current.MainPage = new RegistrarPage();


                 


            }
        }
    }
}
