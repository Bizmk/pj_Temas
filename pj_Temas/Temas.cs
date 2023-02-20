/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 13/11/2022
 * Hora: 09:58 p. m.
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


namespace pj_Temas
{
	/// <summary>
	/// Description of Temas.
	/// </summary>
	public partial class Temas : Form
	{
		MySqlConnection cnn = Conexion.conex();
		public Temas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			metodoConsultaTemas();
			this.id_tema=id_tema;
			this.nom_tema=nom_tema;
            cboCampos.DropDownStyle = ComboBoxStyle.DropDownList;



            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        string id_tema="";
		string nom_tema="";
        string nom_user = "";




        public void Buscar()
		{
			MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_temas WHERE "+cboCampos.Text+" LIKE '"+txtNombre.Text+"%';" , cnn);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataSet data = new DataSet();
			adaptador.Fill(data, "id_tema");
			dgvTemas.DataSource = data;
			dgvTemas.DataMember = "id_tema"; 
		}
		
		
		public void metodoConsultaTemas(){
			MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_temas", cnn);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvTemas.DataSource = tabla;
		}
		
		public void AgreUpdateEventHandler(object sender, AgregarTema.UpdateEventeArgs args)
		{
			metodoConsultaTemas();
			Buscar();
		}
		
		public void AgreUpdateEventHandler2(object sender, ActualizarTema.UpdateEventeArgs args)
		{
			metodoConsultaTemas();
			Buscar();
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			
			AgregarTema temas = new AgregarTema();
			temas.UpdateEventHandler += AgreUpdateEventHandler;
			this.Enabled=false;
			temas.principal=this;
			temas.Show();
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
                id_tema = dgvTemas.SelectedRows[0].Cells[0].Value.ToString();
                nom_tema = dgvTemas.SelectedRows[0].Cells[1].Value.ToString();
            }
			catch(ArgumentOutOfRangeException ar)
			{
				metodoConsultaTemas();
			}
		}
		void CboCamposSelectedIndexChanged(object sender, EventArgs e)
		{
			Buscar();
		}
	    void BtnActualizarClick(object sender, EventArgs e)
		{
	    	
			ActualizarTema actu = new ActualizarTema(id_tema, nom_tema);
			actu.UpdateEventHandler += AgreUpdateEventHandler2;
			this.Enabled=false;
			actu.principal=this;
			actu.Show();
		}
		void DgvTemasCellClick(object sender, DataGridViewCellEventArgs e)
		{
		   id_tema = dgvTemas.SelectedRows[0].Cells[0].Value.ToString();
		   nom_tema = dgvTemas.SelectedRows[0].Cells[1].Value.ToString();
			
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			
			MessageBoxButtons botones = MessageBoxButtons.YesNo;
			DialogResult dr = MessageBox.Show("¿Desea eliminar este Tema?", "Confirmación", botones);
			if(dr==DialogResult.Yes){
			cnn.Open();
			
				
			string cadenaEliminar = "CALL sp_eliminar_tema('" + id_tema +"');";
			MySqlCommand cmd = new MySqlCommand(cadenaEliminar, cnn);
			cmd.ExecuteNonQuery();
			cnn.Close();
			MessageBox.Show("Se ha eliminado el tema correctamente");
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
			    
				foreach (DataGridViewColumn col in dgvTemas.Columns){
					//para poner los titulos de los campos
					ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
					left += col.Width+35;
					if(col.Index < dgvTemas.ColumnCount - 1)
					{
						ep.Graphics.DrawLine(Pens.Gray, left-5, top, left-5, top+43+(dgvTemas.RowCount)*dgvAlto);
					}
				}
				left = ep.MarginBounds.Left;
				ep.Graphics.FillRectangle(Brushes.Black, left, top+40, ep.MarginBounds.Right - left,3);
				top += 43;
				
				foreach(DataGridViewRow row in dgvTemas.Rows)
				{
					if(row.Index==dgvTemas.RowCount) break;
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
		void ImprimirPrintPage(object sender, PrintPageEventArgs e)
		{
			
		}
		void TemasLoad(object sender, EventArgs e)
		{
			id_tema = dgvTemas.SelectedRows[0].Cells[0].Value.ToString();
		   nom_tema = dgvTemas.SelectedRows[0].Cells[1].Value.ToString();
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
        private void cerrarForm(object sender, EventArgs e)
        {
            MENU regresar = new MENU(nom_user);
            regresar.Show();
            this.Dispose();
        }
        void DgvTemasKeyPress(object sender, KeyPressEventArgs e)
		{
			id_tema = dgvTemas.SelectedRows[0].Cells[0].Value.ToString();
		   nom_tema = dgvTemas.SelectedRows[0].Cells[1].Value.ToString();
		}
		void DgvTemasKeyDown(object sender, KeyEventArgs e)
		{
			id_tema = dgvTemas.SelectedRows[0].Cells[0].Value.ToString();
		   nom_tema = dgvTemas.SelectedRows[0].Cells[1].Value.ToString();
		}
		void DgvTemasKeyUp(object sender, KeyEventArgs e)
		{
			id_tema = dgvTemas.SelectedRows[0].Cells[0].Value.ToString();
		   nom_tema = dgvTemas.SelectedRows[0].Cells[1].Value.ToString();
		}
		
		
		
		
	}
}
