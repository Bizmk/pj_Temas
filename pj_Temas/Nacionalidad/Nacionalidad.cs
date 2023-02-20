/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 19/11/2022
 * Hora: 09:59 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Drawing.Printing;
using System.Drawing;

namespace pj_Temas.Nacionalidad
{
	/// <summary>
	/// Description of Nacionalidad.
	/// </summary>
	public partial class Nacionalidad : Form
	{
		MySqlConnection cnn = Conexion.conex();
		public Nacionalidad()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			metodoConsultaNacionalidad();
            cboCampos.DropDownStyle = ComboBoxStyle.DropDownList;


            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        string id_nac="";
		string descri_nac="";
		string nom_user = "";
		
		
		public void nac()
		{
			string Nac;
			for (int i = 0; i<dgvNacionalidad.RowCount; i++)
			{
				Nac = dgvNacionalidad.Rows[i].Cells[0].Value.ToString();
			}
		}
		public void Buscar()
		{
			MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_nacionalidad WHERE "+cboCampos.Text+" LIKE '"+txtNombre.Text+"%';" , cnn);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataSet data = new DataSet();
			adaptador.Fill(data, "id_nac");
			dgvNacionalidad.DataSource = data;
			dgvNacionalidad.DataMember = "id_nac"; 
		}
		
		public void metodoConsultaNacionalidad(){
			MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_nacionalidad", cnn);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvNacionalidad.DataSource = tabla;
		}
		
		public void AgreUpdateEventHandler(object sender, AgregarNacionalidad.UpdateEventeArgs args)
		{
			metodoConsultaNacionalidad();
			Buscar();
		}
		
		public void AgreUpdateEventHandler2(object sender, ActualizarNacionalidad.UpdateEventeArgs args)
		{
			metodoConsultaNacionalidad();
			Buscar();
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			AgregarNacionalidad nac = new AgregarNacionalidad();
			nac.UpdateEventHandler += AgreUpdateEventHandler;
			this.Enabled=false;
			nac.principal=this;
			nac.Show();
		}
		void BtnRegresarClick(object sender, EventArgs e)
		{
            MENU regresar = new MENU(nom_user);
            regresar.Show();
            this.Dispose();
        }
		void TxtNombreTextChanged(object sender, EventArgs e)
		{
			Buscar();
			try
			{
                id_nac = dgvNacionalidad.SelectedRows[0].Cells[0].Value.ToString();
                descri_nac = dgvNacionalidad.SelectedRows[0].Cells[1].Value.ToString();
            }
			catch(ArgumentOutOfRangeException ar)
			{
				metodoConsultaNacionalidad();
			}
		}
		void CboCamposSelectedIndexChanged(object sender, EventArgs e)
		{
			Buscar();
		}
		void BtnActualizarClick(object sender, EventArgs e)
		{
			ActualizarNacionalidad actu = new ActualizarNacionalidad(id_nac, descri_nac);
			actu.UpdateEventHandler += AgreUpdateEventHandler2;
			this.Enabled=false;
			actu.principal=this;
			actu.Show();
		}
	
		void BtnEliminarClick(object sender, EventArgs e)
		{
			MessageBoxButtons botones = MessageBoxButtons.YesNo;
			DialogResult dr = MessageBox.Show("¿Desea eliminar esta Nacionalidad?", "Confirmación", botones);
			if(dr==DialogResult.Yes){
				cnn.Open();
			
				
			string cadenaEliminar = "CALL sp_eliminar_nacionalidad('"+id_nac+"');";
			MySqlCommand cmd = new MySqlCommand(cadenaEliminar, cnn);
			cmd.ExecuteNonQuery();
			cnn.Close();
			MessageBox.Show("Se ha eliminado la nacionalidad correctamente");
			Buscar();
			}
		}
		void BtnImprimirClick(object sender, EventArgs e)
		{
			PrintDocument doc = new PrintDocument();
			doc.DefaultPageSettings.Landscape = true;
			doc.PrinterSettings.PrinterName = "Microsoft print to PDF";
			
			PrintPreviewDialog pdd = new PrintPreviewDialog {Document = doc};
			((Form)pdd).WindowState = FormWindowState.Maximized;
			
			doc.PrintPage+=delegate(object ev, PrintPageEventArgs ep)
			{
				const int dgvAlto = 28;
				int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
			    
				foreach (DataGridViewColumn col in dgvNacionalidad.Columns){
					ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
					left += col.Width+35;
					if(col.Index < dgvNacionalidad.ColumnCount - 1)
					{
						ep.Graphics.DrawLine(Pens.Gray, left-5, top, left-5, top+43+(dgvNacionalidad.RowCount)*dgvAlto);
					}
				}
				left = ep.MarginBounds.Left;
				ep.Graphics.FillRectangle(Brushes.Black, left, top+40, ep.MarginBounds.Right - left,3);
				top += 43;
				
				foreach(DataGridViewRow row in dgvNacionalidad.Rows)
				{
					if(row.Index==dgvNacionalidad.RowCount) break;
					left = ep.MarginBounds.Left;
					foreach(DataGridViewCell cell in row.Cells)
					{
						ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 10), Brushes.Black, left, top + 4);
						left += cell.OwningColumn.Width+35;
						
						
						
					}
					top +=dgvAlto;
					ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left,top,ep.MarginBounds.Right, top);
				}
			 };
			pdd.ShowDialog();
		}
		
		
		void DgvNacionalidadKeyDown(object sender, KeyEventArgs e)
		{
			id_nac = dgvNacionalidad.SelectedRows[0].Cells[0].Value.ToString();
		   	descri_nac = dgvNacionalidad.SelectedRows[0].Cells[1].Value.ToString();
		}
		
		void DgvNacionalidadKeyPress(object sender, KeyPressEventArgs e)
		{
			id_nac = dgvNacionalidad.SelectedRows[0].Cells[0].Value.ToString();
		   	descri_nac = dgvNacionalidad.SelectedRows[0].Cells[1].Value.ToString();
		}
		
		void DgvNacionalidadKeyUp(object sender, KeyEventArgs e)
		{
			id_nac = dgvNacionalidad.SelectedRows[0].Cells[0].Value.ToString();
		   	descri_nac = dgvNacionalidad.SelectedRows[0].Cells[1].Value.ToString();
		}
		void NacionalidadLoad(object sender, EventArgs e)
		{
			id_nac = dgvNacionalidad.SelectedRows[0].Cells[0].Value.ToString();
		   	descri_nac = dgvNacionalidad.SelectedRows[0].Cells[1].Value.ToString();
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
        private void cerrarForm(object sender, EventArgs e)
        {
            MENU regresar = new MENU(nom_user);
            regresar.Show();
            this.Dispose();
        }
        void DgvNacionalidadCellClick(object sender, DataGridViewCellEventArgs e)
		{
			id_nac = dgvNacionalidad.SelectedRows[0].Cells[0].Value.ToString();
		   	descri_nac = dgvNacionalidad.SelectedRows[0].Cells[1].Value.ToString();
		}
		
		
	}
}
