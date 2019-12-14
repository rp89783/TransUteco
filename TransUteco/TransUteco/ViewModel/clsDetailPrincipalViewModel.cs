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
            {   Imagen = "B1.png",
                Asociacion= "ASOEBA",
                Ruta= "BATERO-PERALEJOS-COTUI",
                Decripcion= "Creada con el fin de que los estudiantes tengan un transporte mas seguro." 
            });
            listas.Add(new Clases.clsDetailPrincipal()
            {
                Imagen = "B2.png",
                Asociacion = "ASOESA",
                Ruta = "BATERO-PERALEJOS-COTUI",
                Decripcion = "Sin descripcion"
            });
            listas.Add(new Clases.clsDetailPrincipal()
            {
                Imagen = "B3.png",
                Asociacion = "ASEUCU",
                Ruta = "CEVICOS-PERALEJOS-COTUI",
                Decripcion="Esta fue la primera asociacion de la zona de cevicos, pensando el el vienestar de la juventud"
            });
            listas.Add(new Clases.clsDetailPrincipal()
            {
                Imagen = "B4.png",
                Asociacion = "ASOEPI",
                Ruta = "BATERO-PERALEJOS-COTUI",
                Decripcion = "Sin descripcion"
            });
            listas.Add(new Clases.clsDetailPrincipal()
            {
                Imagen = "B5.png",
                Asociacion = "ASOEMA",
                Ruta = "BATERO-PERALEJOS-COTUI",
                Decripcion = "Sin descripcion"
            });
            listas.Add(new Clases.clsDetailPrincipal()
            {
                Imagen = "B5.png",
                Asociacion = "ASOEMA",
                Ruta = "BATERO-PERALEJOS-LA CUEVA-COTUI",
                Decripcion="Con traba y esfuerzo por los jovenes estudiantes"
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
