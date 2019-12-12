using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TransUteco.Clases;

namespace TransUteco.ViewModel
{
    class clsMasterPageViewModel
    {
        public class MasterPageViewModel 
        {
                public  string Nombre { get; set; } = MasterPageItem.DatosUsuario.Nombre;


            private string iconUser;

            public string IconUser
            {
                get { return iconUser; }
                set { iconUser = value; }
            }

           
           








            //public List<MasterPageItem.Menu> Item()

            //{
            //    var list = new List<MasterPageItem.Menu>();

            //    list.Add(new MasterPageItem.Menu()
            //    {
            //        Icon = "B1.png",
            //        Title = "ASOEBA",

            //    });
            //}
            //< ListView.ItemsSource>
            //                <x:Array Type = "{x:Type local:MasterPageItem}" >
            //                    < local:MasterPageItem Title = "Transportes" Icon="ic_launcher.png" TargetType="{x:Type Views:DetailPrincipalPage}" />
            //                    <local:MasterPageItem Title = "Ajustes"  Icon="icon.png" TargetType="{x:Type Views:AjustesPage}" />
            //                    <local:MasterPageItem Title = "Ayuda" Icon="icon.png" TargetType="{x:Type Views:AyudaPage}" />
            //                    <!--<local:MasterPageItem Title = "Cerrar Sesion" Icon="icon.png" TargetType="{x:Type Views:LoginPage}" />-->
            //                </x:Array>
            //            </ListView.ItemsSource>
        }

        public List<MasterPageItem.Menu> ConsultarMenu()

        {
            var Menu = new List<MasterPageItem.Menu>();

            Menu.Add(new MasterPageItem.Menu
            {
                Icon = "",
                Title = "Home",
                PageName = "Views.DetailPrincipalPage"
            }
                );
            Menu.Add(new MasterPageItem.Menu
            {
                Icon = "Inicio.png",
                Title = "Home",
                PageName = "Views.DetailPrincipalPage"
            }
                );
            Menu.Add(new MasterPageItem.Menu
            {
                Icon = "Asoc.png",
                Title = "Transporte",
                PageName = "Views.DetailPrincipalPage"
            }
                );
            Menu.Add(new MasterPageItem.Menu
            {
                Icon = "Config.png",
                Title = "Configuracion",
                PageName = "Views.DetailPrincipalPage"
            }
                );
            Menu.Add(new MasterPageItem.Menu
            {
                Icon = "Ayuda.png",
                Title = "Ayuda",
                PageName = "Views.DetailPrincipalPage"
            }
                );
            return Menu;

        }
    }
}
