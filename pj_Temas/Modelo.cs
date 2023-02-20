using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace pj_Temas
{
    class Modelo
    {
        public Usuarios porUsuario (string tipo_user)
        {
            MySqlDataReader reader;
            MySqlConnection cnn = Conexion.conex();
            cnn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT id_user, clave, nom_user, tipo_user FROM tb_usuarios WHERE tipo_user LIKE @tipo_user", cnn);
            cmd.Parameters.AddWithValue("@tipo_user", tipo_user);

            reader = cmd.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id_user = int.Parse(reader["id_user"].ToString());
                usr.Clave = reader["clave"].ToString();
                usr.Nom_user = reader["nom_user"].ToString();
                usr.Tipo_user = reader["tipo_user"].ToString();
            }
            return usr;

        }
    }
}
