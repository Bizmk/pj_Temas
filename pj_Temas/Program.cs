/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 02/11/2022
 * Hora: 11:06 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace pj_Temas
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new cbRegistros());
		}
		
	}
}
