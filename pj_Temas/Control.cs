using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj_Temas
{
    class Control
    {

        public string ctrlLogin(string tipo_user, string clave)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if(string.IsNullOrEmpty(tipo_user) || string.IsNullOrEmpty(clave))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.porUsuario(tipo_user);

                if(datosUsuario == null)
                {
                    respuesta = "Debe seleccionar un usuario"; 
                }
                else
                {
                    if(datosUsuario.Clave != clave)
                    {
                        respuesta = "Usuario y/o contraseña no coinciden";
                    }
                    else
                    {
                        
                        Session.id_user = datosUsuario.Id_user;
                        Session.tipo_user = tipo_user;
                        Session.nom_user = datosUsuario.Nom_user;

                    }
                }
            }
            return respuesta;
        }
    }
}
