using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa_Entidad;
using Capa_Negocio;
using System;

namespace Unitest1
{
    [TestClass]
    public class Unitest1 //------------------------------------------------- Clase de prueba unitaria (Login)
    
        [TestMethod]
        public Unitest1() // COnstructor de la clase
        {
            // Inicialización de los modelos Entidad y Negocio
            ClaseEntidad objent = new ClaseEntidad();
            ClaseNegocio objneg = new ClaseNegocio();
            string User = "";
        }
        
        // User setter
        [TestMethod]
        public void setUser()
        {
            this.User = "Tomás";
        }
       

        // ------------------------------------------------------------------ Método de validación de Login
        [TestMethod]
        void p_logueo() 
        {
            // Parametrización de objetos y variables
            DataTable dt = new DataTable();
            objent.usuario = "user";
            objent.clave = "password"
            dt = objneg.N_user(objent);

            // Si el usuario y la contraseña coinceden con un registro de la base de datos
            if (dt.Rows.Count > 0)
            {
                // obtener el nombre del usuario
                usuario_nombre = dt.Rows[0][1].ToString();
                // Cambiar nombre de usuario instanciado de "" a "Tomás"
                setUser()

                Console.WriteLine("Bienvenido " + usuario_nombre)
            }
            else
            {
                Console.WriteLine("Usuario o contraseña Incorrecta");
            }
        }
    }
}