using System;
using System.Collections.Generic;
using System.Text;

namespace TransUteco.Clases
{
  public static  class clsConstantes
    {
        #region PageLogin
        public static string Email = "Ingrese su correo";
        public static string Clave = "Contraseña";
        public static string ClaveOlvidada = "La Olvidaste?";
        public static string BotonAcceder = "ACCEDER";
        public static string BotonRegistrarse = "Crear tu cuenta aquí.";
        public static string SwichRecordar = "Recordar cuenta?";
        #endregion

        #region PageRegistar
        public static string RNombre = "Nombre Completo";
        public static string RSexo = "Elija su sexo";
        public static List<string> LSexo = new List<string> { "Masculino", "Femenino", "No definir" };
        public static string REmail = "E-mail";
        public static string RClave = "Contraseña";
        public static string RConfirmeClave = "Confirmar Contraseña";
        public static string RBotonEnviarRegistro = "Enviar registro";
        public static string RBotonYaTengoCuenta = "Click aqui si ya tienes cuenta";
        
        #endregion



    }
}
