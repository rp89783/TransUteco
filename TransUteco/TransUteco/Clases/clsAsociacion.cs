using System;
using System.Collections.Generic;
using System.Text;
using TransUteco.Clases;

namespace TransUteco.ViewModel
{
   public class clsAsociacion 
    {
        public static int idAsociacion ;
        public static string Asociacion;
        public static string Decripcion;
        public static string Imagen;

        public clsAsociacion(int idAsociacion, string asociacion, string decripcion, string imagen)
        {
            this.IdAsociacion = idAsociacion;
            Asociacion1 = asociacion;
            Decripcion1 = decripcion;
            Imagen1 = imagen;
        }
        public clsAsociacion()
        {
            this.IdAsociacion = idAsociacion;
            Asociacion1 = Asociacion;
            Decripcion1 = Decripcion;
            Imagen1 = Imagen;
        }

       
        public  int IdAsociacion { get => idAsociacion; set => idAsociacion = value; }
        public string Asociacion1 { get => Asociacion; set => Asociacion = value; }
        public string Decripcion1 { get => Decripcion; set => Decripcion = value; }
        public  string Imagen1 { get => Imagen; set => Imagen = value; }
    }
}
