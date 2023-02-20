/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 19/11/2022
 * Hora: 09:59 a. m.
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
using System.Text.RegularExpressions;

namespace pj_Temas.Nacionalidad
{
	/// <summary>
	/// Description of AgregarNacionalidad.
	/// </summary>
	public partial class AgregarNacionalidad : Form
	{
		public Form principal;
		MySqlConnection cnn = Conexion.conex();
		Nacionalidad mostrar = new Nacionalidad();
		public AgregarNacionalidad()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public delegate void UpdateDelagate(object sender, UpdateEventeArgs args);
		public event UpdateDelagate UpdateEventHandler;
		
		public class UpdateEventeArgs : EventArgs
		{
			public string Data { get; set;}
			
		}
		
		public void Agregar()
		{
			UpdateEventeArgs args = new UpdateEventeArgs();
			UpdateEventHandler.Invoke(this, args);
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			MessageBoxButtons botones = MessageBoxButtons.YesNo;
			DialogResult dr = MessageBox.Show("¿Son Correctos los datos?", "Confirmación", botones);
			if(dr==DialogResult.Yes){
				string strRgx1 = "^[N][0-9]{3}";
				Regex rg1 = new Regex(strRgx1);
				Match c1 = rg1.Match(txtId.Text);
				
				if(c1.Success)
				{
					if (txtNombre.Text != "")
					{
						try
						{
							principal.Enabled = true;
							cnn.Close();
							cnn.Open();
							string vId = txtId.Text;
							string vNombre = txtNombre.Text;
							string cadenaInsertar = "INSERT INTO tb_nacionalidad VALUES('" + vId + "', '" + vNombre + "')";
							MySqlCommand cmd = new MySqlCommand(cadenaInsertar, cnn);
							cmd.ExecuteNonQuery();
							cnn.Close();
							this.Close();
							mostrar.metodoConsultaNacionalidad();

							Agregar();
						}
						catch (Exception exception)
						{
                            principal.Enabled = false;
                            MessageBox.Show("Ese ID ya esta registrado");
						}
					}
					else
					{
						MessageBox.Show("Por favor rellene correctamente todos los campos");
					}
				}
				else
				{
					MessageBox.Show("Los valores no cumplen con el Formato");
					
				}
				
			}
			
		}
		void TxtCancelarClick(object sender, EventArgs e)
		{
			principal.Enabled=true;
			mostrar.Buscar();
			
			this.Close();
		}

        private void AgregarNacionalidad_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
        private void cerrarForm(object sender, EventArgs e)
        {
            principal.Enabled = true;
            this.Hide();
        }
    }
}
