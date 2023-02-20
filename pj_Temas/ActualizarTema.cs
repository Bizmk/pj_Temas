/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 16/11/2022
 * Hora: 07:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace pj_Temas
{
	/// <summary>
	/// Description of ActualizarTema.
	/// </summary>
	public partial class ActualizarTema : Form
	{
		public Form principal;
		MySqlConnection cnn = Conexion.conex();
		Temas act = new Temas();
		public ActualizarTema(string id_tema, string nom_tema)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.id_tema= id_tema;
			this.nom_tema = nom_tema;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string id_tema;
		string nom_tema;
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
		void LbIDClick(object sender, EventArgs e)
		{
			
			 
			
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
					string cadenaActualizar = "UPDATE tb_temas SET nom_tema='" + vNombre +
						"'WHERE id_tema='" + vId +
						"';";
					MySqlCommand cmd = new MySqlCommand(cadenaActualizar, cnn);
					cmd.ExecuteNonQuery();
					cnn.Close();
					MessageBox.Show("Se actualizo el tema");
                    this.Close();
                    Agregar();
				}
				else
				{
					MessageBox.Show("Por favor rellene correctamente todos los campos");
				}
			
			
			}
			
		}
		void ActualizarTemaLoad(object sender, EventArgs e)
		{
			lbID.Text = id_tema;
			txtNombre.Text = nom_tema;

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
