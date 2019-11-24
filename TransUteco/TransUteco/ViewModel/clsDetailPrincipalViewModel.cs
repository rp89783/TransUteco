using System;
using System.Collections.Generic;
using System.Text;

namespace TransUteco.ViewModel
{
  public  class clsDetailPrincipalViewModel
    {
        public static List<ListaAsociaciones> listas=new List<ListaAsociaciones>() ;
        
        void CargarLista()
        {

            listas.Add(new ListaAsociaciones("Registrar.png", "ASOEBA", "BATERO-PERALEJOS-COTUI"));
        
        }
       public  class ListaAsociaciones
        {
            public string Imagen { get; set; }
            public string Asociacion { get; set; }
            public string Ruta { get; set; }


            public ListaAsociaciones(string imagen, string asociacion, string ruta)
            {
                Imagen = imagen;
                Asociacion = asociacion;
                Ruta = ruta;
            }
        }


    }
    
}
