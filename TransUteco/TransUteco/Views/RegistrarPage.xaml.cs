using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransUteco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarPage : ContentPage
    {
        public RegistrarPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }

        private void txtnombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtnombre.Text != "")
            {
                lblNombre.Text = txtnombre.Placeholder;
            }
            else
                lblNombre.Text = "";
        }

        private void txtNombreUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNombreUsuario.Text != "")
            {
                lblNombreUser.Text = txtNombreUsuario.Placeholder;
            }
            else
                lblNombreUser.Text = "";
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtEmail.Text != "")
            {
                lblEmail.Text = txtEmail.Placeholder;
            }
            else
                lblEmail.Text = "";
        }

        private void txtContrasena_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtContrasena.Text != "")
            {
                lblContrasena.Text = txtContrasena.Placeholder;
            }
            else
                lblContrasena.Text = "";
        }

        private void txtConfirmarcontrasena_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtConfirmarcontrasena.Text != "")
            {
                lblConfirmarContrasena.Text = txtConfirmarcontrasena.Placeholder;
            }
            else
                lblConfirmarContrasena.Text = "";
        }
    }
}