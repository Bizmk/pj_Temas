/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 23/11/2022
 * Hora: 11:37 p. m.
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


namespace pj_Temas.Autores
{
	/// <summary>
	/// Description of Autores.
	/// </summary>
	public partial class Autores : Form
	{
		MySqlConnection cnn = Conexion.conex();
		string tipo_user;
		public Autores()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			tipo_user = Session.tipo_user;
			metodoConsultaAutores();
            cboCampos.DropDownStyle = ComboBoxStyle.DropDownList;

			if (tipo_user == "SUPERVISOR")
			{
				this.btnAgregar.Visible = false;
                this.btnActualizar.Visible = false;
                this.btnEliminar.Visible = false;
                this.btnImprimir.Visible = false;
            }

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        string id_autor="";
		string nom_aut="";
		string ap="";
		string id_nac="";
        string nom_user;
		
		


        public void Buscar()
		{
			MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_autores WHERE "+cboCampos.Text+" LIKE '"+txtNombre.Text+"%';" , cnn);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataSet data = new DataSet();
			adaptador.Fill(data, "id_autor");
			dgvAutores.DataSource = data;
			dgvAutores.DataMember = "id_autor"; 
		}
		public void metodoConsultaAutores(){
			MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_autores", cnn);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvAutores.DataSource = tabla;
			
			
			
			
		}
		
		
		public void AgreUpdateEventHandler(object sender, AgregarAutores.UpdateEventeArgs args)
		{
			metodoConsultaAutores();
			Buscar();
			this.Enabled=true;
		}
		public void AgreUpdateEventHandler2(object sender, AcutalizarAutores.UpdateEventeArgs args)
		{
			metodoConsultaAutores();
			Buscar();
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			AgregarAutores aut = new AgregarAutores();
			aut.UpdateEventHandler += AgreUpdateEventHandler;
			this.Enabled=false;
			aut.principal = this;
			aut.Show();
		}
		void TxtNombreTextChanged(object sender, EventArgs e)
		{
			Buscar();
			try
			{
				id_autor = dgvAutores.SelectedRows[0].Cells[0].Value.ToString();
				nom_aut = dgvAutores.SelectedRows[0].Cells[1].Value.ToString();
				ap = dgvAutores.SelectedRows[0].Cells[2].Value.ToString();
				id_nac = dgvAutores.SelectedRows[0].Cells[3].Value.ToString();
			}
			catch(ArgumentOutOfRangeException arg)
			{
				metodoConsultaAutores();
			}
        }
		void CboCamposSelectedIndexChanged(object sender, EventArgs e)
		{
			Buscar();
		}
		void BtnActualizarClick(object sender, EventArgs e)
		{
			AcutalizarAutores actu = new AcutalizarAutores(id_autor, nom_aut, ap, id_nac);
			actu.UpdateEventHandler += AgreUpdateEventHandler2;
			this.Enabled=false;
			actu.principal=this;
			actu.Show();
		}
		void DgvAutoresCellClick(object sender, DataGridViewCellEventArgs e)
		{
			id_autor = dgvAutores.SelectedRows[0].Cells[0].Value.ToString();
		   	nom_aut = dgvAutores.SelectedRows[0].Cells[1].Value.ToString();
		   	ap = dgvAutores.SelectedRows[0].Cells[2].Value.ToString();
		   	id_nac = dgvAutores.SelectedRows[0].Cells[3].Value.ToString();
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			MessageBoxButtons botones = MessageBoxButtons.YesNo;
			DialogResult dr = MessageBox.Show("¿Desea eliminar este Autor?", "Confirmación", botones);
			if(dr==DialogResult.Yes){
			cnn.Open();
			
				
			string cadenaEliminar = "DELETE FROM tb_autores WHERE id_autor='" + id_autor +"';";
			MySqlCommand cmd = new MySqlCommand(cadenaEliminar, cnn);
			cmd.ExecuteNonQuery();
			cnn.Close();
			MessageBox.Show("Se ha eliminado el autor correctamente");
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
			    
				foreach (DataGridViewColumn col in dgvAutores.Columns){
					ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
					left += col.Width+50;
					if(col.Index < dgvAutores.ColumnCount-1)
					{
						ep.Graphics.DrawLine(Pens.Gray, left-5, top, left-5, top+43+(dgvAutores.RowCount)*dgvAlto);
					}
				}
				left = ep.MarginBounds.Left;
				ep.Graphics.FillRectangle(Brushes.Black, left, top+40, ep.MarginBounds.Right-left,3);
				top += 43;
				
				foreach(DataGridViewRow row in dgvAutores.Rows)
				{
					if(row.Index==dgvAutores.RowCount) break;
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
            regresar.Visible = true;
			this.Visible = false;
        }
		void AutoresLoad(object sender, EventArgs e)
		{
			id_autor = dgvAutores.SelectedRows[0].Cells[0].Value.ToString();
		   	nom_aut = dgvAutores.SelectedRows[0].Cells[1].Value.ToString();
		   	ap = dgvAutores.SelectedRows[0].Cells[2].Value.ToString();
			id_nac = dgvAutores.SelectedRows[0].Cells[3].Value.ToString();


			this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
        private void cerrarForm(object sender, EventArgs e)
        {
            MENU regresar = new MENU(nom_user);
            regresar.Show();
            this.Dispose();
        }
        void DgvAutoresKeyDown(object sender, KeyEventArgs e)
		{
			id_autor = dgvAutores.SelectedRows[0].Cells[0].Value.ToString();
		   	nom_aut = dgvAutores.SelectedRows[0].Cells[1].Value.ToString();
		   	ap = dgvAutores.SelectedRows[0].Cells[2].Value.ToString();
		   	id_nac = dgvAutores.SelectedRows[0].Cells[3].Value.ToString();
		}
		void DgvAutoresKeyPress(object sender, KeyPressEventArgs e)
		{
			id_autor = dgvAutores.SelectedRows[0].Cells[0].Value.ToString();
		   	nom_aut = dgvAutores.SelectedRows[0].Cells[1].Value.ToString();
		   	ap = dgvAutores.SelectedRows[0].Cells[2].Value.ToString();
		   	id_nac = dgvAutores.SelectedRows[0].Cells[3].Value.ToString();
		}
		void DgvAutoresKeyUp(object sender, KeyEventArgs e)
		{
			id_autor = dgvAutores.SelectedRows[0].Cells[0].Value.ToString();
		   	nom_aut = dgvAutores.SelectedRows[0].Cells[1].Value.ToString();
		   	ap = dgvAutores.SelectedRows[0].Cells[2].Value.ToString();
		   	id_nac = dgvAutores.SelectedRows[0].Cells[3].Value.ToString();
		}
		void CbVisuaCheckedChanged(object sender, EventArgs e)
		{
			
		}
	
	}
}
