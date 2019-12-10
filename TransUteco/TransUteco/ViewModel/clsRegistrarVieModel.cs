using System;
using System.Collections.Generic;
using System.Text;
using TransUteco.Clases;

namespace TransUteco.ViewModel
{
  public  class clsRegistrarVieModel : BaseViewModel
    {
        public string PHNombre { get; set; } = clsConstantes.RNombre;
        public string PHSexo { get; set; } = clsConstantes.RSexo;
        public List<string> LSexo { get; set; } = clsConstantes.LSexo;
        public string PHEmail { get; set; } = clsConstantes.REmail;
        public string PHClave { get; set; } = clsConstantes.RClave;
        public string PHConfirmeClave { get; set; } = clsConstantes.RConfirmeClave;
        public string TBotonEnviarRegistro { get; set; } = clsConstantes.RBotonEnviarRegistro;
        public string TBotonYaTengoCuenta { get; set; } = clsConstantes.RBotonYaTengoCuenta;


       
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value != nombre)
                {
                    SetProperty(ref nombre, value, "nombre");
                }
            }
        }


        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if (value != email)
                {
                    SetProperty(ref email, value, "Email");
                }

            }
        }
        private string clave1;

        public string Clave1
        {
            get { return clave1; }
            set
            {
                SetProperty(ref clave1, value, "Clave1");

            }
        }
        private string clave2;

        public string Clave2
        {
            get { return clave2; }
            set
            {
                SetProperty(ref clave2, value, "Clave2");

            }
        }

       
    }
}
