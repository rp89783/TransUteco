using System;
using System.Collections.Generic;
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
        }
    }
}
