﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TransUteco.Clases;
using System.ComponentModel;
using static TransUteco.ViewModel.clsLoginViewModel;

namespace TransUteco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        
        public LoginPage()
        {

            InitializeComponent();
           
          BindingContext = new LoginViewModel();
        }
       
        private void btnRegistar_Clicked(object sender, EventArgs e)
        {
           // Application.Current.MainPage = new RegistrarPage();

        }

        private void btnAcceder_Clicked(object sender, EventArgs e)
        {
         //   Application.Current.MainPage = new MainPage();
        }
    }
}