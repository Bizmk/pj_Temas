/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 18/11/2022
 * Hora: 11:20 a. m.
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pj_Temas.Editoriales
{
	/// <summary>
	/// Description of Editoriales.
	/// </summary>
	public partial class Editoriales : Form
	{
		MySqlConnection cnn = Conexion.conex();
		public Editoriales()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			metodoConsultaEditoriales();
            cboCampos.DropDownStyle = ComboBoxStyle.DropDownList;

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        string id_edito="";
		string nom_edito="";
		string direcc="";
		string email="";
		string tel="";
        string nom_user = "";
        public void Buscar()
		{
			MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_editoriales WHERE "+cboCampos.Text+" LIKE '"+txtNombre.Text+"%';" , cnn);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataSet data = new DataSet();
			adaptador.Fill(data, "id_edito");
			dgvEditoriales.DataSource = data;
			dgvEditoriales.DataMember = "id_edito"; 
		}
		public void metodoConsultaEditoriales(){
			MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_editoriales", cnn);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvEditoriales.DataSource = tabla;
			
			
		}
		
		public void AgreUpdateEventHandler(object sender, AgregarEditorial.UpdateEventeArgs args)
		{
			metodoConsultaEditoriales();
			Buscar();
			this.Enabled=true;
		}
		public void AgreUpdateEventHandler2(object sender, ActualizarEditoriales.UpdateEventeArgs args)
		{
			metodoConsultaEditoriales();
			Buscar();
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			
			AgregarEditorial edi = new AgregarEditorial();
			edi.UpdateEventHandler += AgreUpdateEventHandler;
			this.Enabled=false;
			edi.principal = this;
			edi.Show();
			
		}
		void TxtNombreTextChanged(object sender, EventArgs e)
		{
			Buscar();
			try
			{
                id_edito = dgvEditoriales.SelectedRows[0].Cells[0].Value.ToString();
                nom_edito = dgvEditoriales.SelectedRows[0].Cells[1].Value.ToString();
                direcc = dgvEditoriales.SelectedRows[0].Cells[2].Value.ToString();
                email = dgvEditoriales.SelectedRows[0].Cells[3].Value.ToString();
                tel = dgvEditoriales.SelectedRows[0].Cells[4].Value.ToString();
            }
			catch (ArgumentOutOfRangeException ar)
			{
				metodoConsultaEditoriales();
			}
		}
		
		void CboCamposSelectedIndexChanged(object sender, EventArgs e)
		{
			Buscar();
		}
		void BtnActualizarClick(object sender, EventArgs e)
		{
			ActualizarEditoriales actu = new ActualizarEditoriales(id_edito, nom_edito, direcc, email, tel);
			actu.UpdateEventHandler += AgreUpdateEventHandler2;
			this.Enabled=false;
			actu.principal = this;
			actu.Show();
			
		}
		void DgvEditorialesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			id_edito = dgvEditoriales.SelectedRows[0].Cells[0].Value.ToString();
		   	nom_edito = dgvEditoriales.SelectedRows[0].Cells[1].Value.ToString();
		   	direcc = dgvEditoriales.SelectedRows[0].Cells[2].Value.ToString();
		   	email = dgvEditoriales.SelectedRows[0].Cells[3].Value.ToString();
		    tel = dgvEditoriales.SelectedRows[0].Cells[4].Value.ToString();
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			
			MessageBoxButtons botones = MessageBoxButtons.YesNo;
			DialogResult dr = MessageBox.Show("¿Desea eliminar esta Editorial?", "Confirmación", botones);
			if(dr==DialogResult.Yes){
			cnn.Open();
			
				
			string cadenaEliminar = "CALL sp_eliminar_editorial('" + id_edito +"');";
			MySqlCommand cmd = new MySqlCommand(cadenaEliminar, cnn);
			cmd.ExecuteNonQuery();
			cnn.Close();
			MessageBox.Show("Se ha eliminado la editorial correctamente");
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
			    
				foreach (DataGridViewColumn col in dgvEditoriales.Columns){
					ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
					left += col.Width+50;
					if(col.Index < dgvEditoriales.ColumnCount-1)
					{
						ep.Graphics.DrawLine(Pens.Gray, left-5, top, left-5, top+43+(dgvEditoriales.RowCount)*dgvAlto);
					}
				}
				left = ep.MarginBounds.Left;
				ep.Graphics.FillRectangle(Brushes.Black, left, top+40, ep.MarginBounds.Right-left,3);
				top += 43;
				
				foreach(DataGridViewRow row in dgvEditoriales.Rows)
				{
					if(row.Index==dgvEditoriales.RowCount) break;
					left = ep.MarginBounds.Left;
					foreach(DataGridViewCell cell in row.Cells)
					{
						ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 10), Brushes.Black, left, top + 4);
						left += cell.OwningColumn.Width+50;
						
						
						
					}
					top +=dgvAlto;
					ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left,top,ep.MarginBounds.Right, top);
				}
			 };
			pdd.ShowDialog();
		}
		void BtnRegresarClick(object sender, EventArgs e)
		{
            MENU regresar = new MENU(nom_user);
            regresar.Show();
            this.Dispose();
        }
		void EditorialesLoad(object sender, EventArgs e)
		{
			id_edito = dgvEditoriales.SelectedRows[0].Cells[0].Value.ToString();
		   	nom_edito = dgvEditoriales.SelectedRows[0].Cells[1].Value.ToString();
		   	direcc = dgvEditoriales.SelectedRows[0].Cells[2].Value.ToString();
		   	email = dgvEditoriales.SelectedRows[0].Cells[3].Value.ToString();
		    tel = dgvEditoriales.SelectedRows[0].Cells[4].Value.ToString();
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
        private void cerrarForm(object sender, EventArgs e)
        {
            MENU regresar = new MENU(nom_user);
            regresar.Show();
            this.Dispose();
        }
        void DgvEditorialesKeyDown(object sender, KeyEventArgs e)
		{
			id_edito = dgvEditoriales.SelectedRows[0].Cells[0].Value.ToString();
		   	nom_edito = dgvEditoriales.SelectedRows[0].Cells[1].Value.ToString();
		   	direcc = dgvEditoriales.SelectedRows[0].Cells[2].Value.ToString();
		   	email = dgvEditoriales.SelectedRows[0].Cells[3].Value.ToString();
		    tel = dgvEditoriales.SelectedRows[0].Cells[4].Value.ToString();
		}
		void DgvEditorialesKeyPress(object sender, KeyPressEventArgs e)
		{
			id_edito = dgvEditoriales.SelectedRows[0].Cells[0].Value.ToString();
		   	nom_edito = dgvEditoriales.SelectedRows[0].Cells[1].Value.ToString();
		   	direcc = dgvEditoriales.SelectedRows[0].Cells[2].Value.ToString();
		   	email = dgvEditoriales.SelectedRows[0].Cells[3].Value.ToString();
		    tel = dgvEditoriales.SelectedRows[0].Cells[4].Value.ToString();
		}
		void DgvEditorialesKeyUp(object sender, KeyEventArgs e)
		{
			id_edito = dgvEditoriales.SelectedRows[0].Cells[0].Value.ToString();
		   	nom_edito = dgvEditoriales.SelectedRows[0].Cells[1].Value.ToString();
		   	direcc = dgvEditoriales.SelectedRows[0].Cells[2].Value.ToString();
		   	email = dgvEditoriales.SelectedRows[0].Cells[3].Value.ToString();
		    tel = dgvEditoriales.SelectedRows[0].Cells[4].Value.ToString();
		}
		
	}
}
