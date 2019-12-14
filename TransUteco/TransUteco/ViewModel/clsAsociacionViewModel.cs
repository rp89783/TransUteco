using System;
using System.Collections.Generic;
using System.Text;

namespace TransUteco.ViewModel
{
  public  class clsAsociacionViewModel
    {
        clsAsociacion a = new clsAsociacion();
        public string Asociacion { get; set; } ="Asociacion  " + clsAsociacion.Asociacion;
        public string Descripcion { get; set; }= clsAsociacion.Decripcion;
        public string Imagen { get; set; } = clsAsociacion.Imagen;


    }
}
