using System;
using System.Collections.Generic;
using System.Text;

namespace TransUteco.ViewModel
{
   public class clsAsociacion
    {
        private int idAsociacion ;
        private string Asociacion;
        private string Decripcion;

        public clsAsociacion(int idAsociacion, string asociacion, string decripcion)
        {
            this.IdAsociacion = idAsociacion;
            Asociacion1 = asociacion;
            Decripcion1 = decripcion;
        }
        public clsAsociacion()
        {
            this.IdAsociacion = 0;
            Asociacion1 = null;
            Decripcion1 = null;
        }
        public int IdAsociacion { get => idAsociacion; set => idAsociacion = value; }
        public string Asociacion1 { get => Asociacion; set => Asociacion = value; }
        public string Decripcion1 { get => Decripcion; set => Decripcion = value; }
    }
}
