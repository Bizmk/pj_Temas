using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj_Temas
{
    class Usuarios
    {
        int id_user;
        string tipo_user, nom_user, clave;

        public int Id_user { get => id_user; set => id_user = value; }
        public string Tipo_user { get => tipo_user; set => tipo_user = value; }
        public string Nom_user { get => nom_user; set => nom_user = value; }
        public string Clave { get => clave; set => clave = value; }

    }
}
