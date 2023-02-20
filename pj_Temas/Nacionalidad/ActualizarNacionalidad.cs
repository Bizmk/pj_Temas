/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 19/11/2022
 * Hora: 09:59 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;


namespace pj_Temas.Nacionalidad
{
	/// <summary>
	/// Description of ActualizarNacionalidad.
	/// </summary>
	public partial class ActualizarNacionalidad : Form
	{
		public Form principal;
		MySqlConnection cnn = Conexion.conex();
		Nacionalidad act = new Nacionalidad();
		public ActualizarNacionalidad(string id_nac, string descri_nac)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.id_nac= id_nac;
			this.descri_nac = descri_nac;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string id_nac;
		string descri_nac;
		
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
				if (txtNombre.Text != "")
				{
					principal.Enabled = true;
					cnn.Open();
					string vId = lbID.Text;
					string vNombre = txtNombre.Text;
					string cadenaActualizar = "UPDATE tb_nacionalidad SET descri_nac='" + vNombre +
						"'WHERE id_nac='" + vId +
						"';";
					MySqlCommand cmd = new MySqlCommand(cadenaActualizar, cnn);
					cmd.ExecuteNonQuery();
					cnn.Close();
					MessageBox.Show("Se actualizo la nacionalidad");
                    this.Close();
                    Agregar();
				}
				else
				{
					MessageBox.Show("Por favor rellene correctamente todos los campos");
				}
			
			
			
			}
			
		}
		void ActualizarNacionalidadLoad(object sender, EventArgs e)
		{
			lbID.Text = id_nac;
			txtNombre.Text = descri_nac;

            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
        private void cerrarForm(object sender, EventArgs e)
        {
            principal.Enabled = true;
            this.Hide();
        }
        void TxtCancelarClick(object sender, EventArgs e)
		{
			principal.Enabled=true;
			this.Close();
		}
	}
}
