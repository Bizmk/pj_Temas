/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 02/11/2022
 * Hora: 11:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace pj_Temas
{
	/// <summary>
	/// Description of Conexion.
	/// </summary>
	public class Conexion
	{
		public Conexion()
		{
		}
		
		public static MySqlConnection conex(){
			string servidor="localhost";
			string usuario="root";
			string clave="12345";
			string db="libreria";
			string cadena="server="+servidor+"; user="+usuario+"; pwd="+clave+"; database="+db+"";
			
			try{
				MySqlConnection cn=new MySqlConnection(cadena);
				return cn;
				
			}catch(MySqlException ex){
				MessageBox.Show("Error en la conexión a la DB"+ex.Message);
				return null;
			}
	
		}
	}
}
