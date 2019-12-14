using System;
using System.Collections.Generic;
using System.Text;

namespace TransUteco.Clases
{
  public  class MasterPageItem
    {
        public class DatosUsuario
        {

            private static string iconUser;
            private static string nombre;

            public static string IconUser { get => iconUser; set => iconUser = value; }
            public static string Nombre { get => nombre; set => nombre = value; }
        }



        public class Menu
        {
            #region Menu
            public string Title { get; set; }
            public string Icon { get; set; }
            public Type PageName { get; set; }
            #endregion
        }


    }

}
