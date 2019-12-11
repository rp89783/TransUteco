using System;
using System.Collections.Generic;
using System.Text;
using TransUteco.Clases;

namespace TransUteco.ViewModel
{
  public  class clsDetailPrincipalViewModel
    {
        public  List<Clases.clsDetailPrincipal> Consultarlistas ()
        
        { var listas = new List<clsDetailPrincipal>();
            
            listas.Add(new Clases.clsDetailPrincipal()
            {   Imagen = "TP.png",
                Asociacion= "ASOEBA",
                Ruta= "BATERO-PERALEJOS-COTUI" 
            });
            listas.Add(new Clases.clsDetailPrincipal()
            {
                Imagen = "Registrarse.png",
                Asociacion = "ASOEBA",
                Ruta = "BATERO-PERALEJOS-COTUI"
            });
            listas.Add(new Clases.clsDetailPrincipal()
            {
                Imagen = "Registrarse.png",
                Asociacion = "ASOEBA",
                Ruta = "BATERO-PERALEJOS-COTUI"
            });
            listas.Add(new Clases.clsDetailPrincipal()
            {
                Imagen = "Registrarse.png",
                Asociacion = "ASOEBA",
                Ruta = "BATERO-PERALEJOS-COTUI"
            });
            return listas;
        }




        //public class ListaAsociaciones
        //{
        //    public string Imagen { get; set; }
        //    public string Asociacion { get; set; }
        //    public string Ruta { get; set; }


        //    public ListaAsociaciones(string imagen, string asociacion, string ruta)
        //    {
        //        Imagen = imagen;
        //        Asociacion = asociacion;
        //        Ruta = ruta;
        //    }
        //}

        
    }
    
}
