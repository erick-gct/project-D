
using System;
using System.Data;
using System.ServiceModel.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniTestD
{
    //----------------------------------------------------------------------- Clase de prueba unitaria (Login)
    [TestClass]
    public class UniTest1
    { 
        public String User;

        // ------------------------------------------------------------------ Método de validación de Login
        [TestMethod]
        void p_logueo()
        {
            // Parametrización de objetos y variables
            String user = "user";
            String clave = "password";

            // Si el usuario y la contraseña coinciden
            if (user == "Tomás" && clave == "password")
            {
                // obtener el nombre del usuario
                this.User = user;

                Console.WriteLine("Bienvenido " + this.User);
                Console.ReadKey();
                Assert.AreEqual(true, user, "Login satisfactorio sin errores");
            }
            else
            {
                Console.WriteLine("Usuario o contraseña Incorrecta");
                Console.ReadKey();
                Assert.AreEqual(true, user, "Login fallido sin errores");
            }
        }
    }
}