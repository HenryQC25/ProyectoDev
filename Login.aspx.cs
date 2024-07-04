using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevProjectLocal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Ingresar_Click(object sender, EventArgs e)
        {
            // Validar la autenticación
            if (validar())
            {

                //verificar si existe en Base de datos, de lo contrario se inserta como nuevo registro automaticamente.
                //↓






                // Obtener el nombre de usuario
                // Redirigir con parámetro nombre de usuario
                Response.Redirect("~/Inicio/PaginaPrincipal?nombre=" + "henry");
            }
            else
            {
                int tipo = 1; // tipo de alerta 1 error, 2 success, 3 warning, 4 pregunta sobre eliminar
                string mensaje = "Usuario o contraseña incorrectos.";
                string script = $"alertas({tipo}, '{HttpUtility.JavaScriptStringEncode(mensaje)}');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "runScript", script, true);

            }
        }

        private bool validar()
        {
            // Validar usuario y contraseña

            string contrasena = this.contrasena.Value.Trim(); // Obtener el valor del campo HTML

            //active directory retorno true o false ↓


            // valida contraseña se agregará validar usuario tambien.!!!
            //reemplazar valor estatico por valor de active directory.
            if (contrasena == "123")
            {



                return true; // Autenticación exitosa
            }

            return false; // Autenticación fallida
        }
        ////////////////////
    }
}