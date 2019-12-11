﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TransUteco.ViewModel;
using System.Collections.ObjectModel;

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
            
        }

       
        private async void btnAsoeba_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AsociacionPage());
        }
    }
}