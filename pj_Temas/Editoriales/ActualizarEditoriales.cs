/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 18/11/2022
 * Hora: 11:51 a. m.
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
using System.Data.SqlClient;
using System.Drawing.Printing;
namespace pj_Temas.Editoriales
{
	/// <summary>
	/// Description of ActualizarEditoriales.
	/// </summary>
	public partial class ActualizarEditoriales : Form
	{
		MySqlConnection cnn = Conexion.conex();
		Editoriales edi= new Editoriales();
		public Form principal;
		public ActualizarEditoriales(string id_edito, string nom_edito, string direcc, string email, string tel)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.id_edito=id_edito;
			this.nom_edito=nom_edito;
			this.direcc=direcc;
			this.email=email;
			this.tel=tel;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string id_edito;
		string nom_edito;
		string direcc;
		string email;
		string tel;
		
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
		void ActualizarEditorialesLoad(object sender, EventArgs e)
		{
			lbID.Text = id_edito;
			txtNombre.Text = nom_edito;
			txtDirecc.Text=direcc;
			txtEmail.Text=email;
			txtTel.Text=tel;
            this.FormClosed += new FormClosedEventHandler(cerrarForm);

        }
        private void cerrarForm(object sender, EventArgs e)
        {
            principal.Enabled = true;
            this.Hide();
        }
        void BtnGuardarClick(object sender, EventArgs e)
		{
			MessageBoxButtons botones = MessageBoxButtons.YesNo;
			DialogResult dr = MessageBox.Show("¿Son Correctos los datos?", "Confirmación", botones);
			if (dr == DialogResult.Yes) {
				if (txtNombre.Text != "" && txtDirecc.Text != "" && txtEmail.Text != "" && txtTel.Text != "")
				{


					principal.Enabled = true;

					cnn.Open();
					string vId = lbID.Text;
					string vNombre = txtNombre.Text;
					string vDirecc = txtDirecc.Text;
					string vEmail = txtEmail.Text;
					string vTel = txtTel.Text;
					string cadenaActualizar = "UPDATE tb_editoriales SET nom_edito='" + vNombre +
						"', direcc='" + vDirecc + "', " +
						"email= '" + vEmail + "'," +
						"tel='" + vTel + "' WHERE id_edito='" + vId +
						"';";
					MySqlCommand cmd = new MySqlCommand(cadenaActualizar, cnn);
					cmd.ExecuteNonQuery();
					cnn.Close();
					MessageBox.Show("Se actualizo la editorial");
					Agregar();
                    this.Close();

                }
				else
				{
					MessageBox.Show("Por favor rellene los campos correctamente");
				}
			
			
			
			}
			
		}
		void TxtCancelarClick(object sender, EventArgs e)
		{
			principal.Enabled=true;
			this.Close();
			
		}
	}
}
