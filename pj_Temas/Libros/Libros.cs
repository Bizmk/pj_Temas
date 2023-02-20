/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 24/11/2022
 * Hora: 07:06 a. m.
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


namespace pj_Temas.Libros
{
	
	/// <summary>
	/// Description of Libros.
	/// </summary>
	public partial class Libros : Form
	{
		
		MySqlConnection cnn = Conexion.conex();
		
		public Libros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			metodoConsultaLibros();
			cboCampos.DropDownStyle = ComboBoxStyle.DropDownList;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string id_libro="";
		string titulo="";
		int anio_edic=0;
		int npaginas=0;
		string id_autor="";
		decimal precio=0;
		string id_edito="";
		string id_tema="";
        string nom_user = "";


        public void Buscar()
		{
			MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_libros WHERE "+cboCampos.Text+" LIKE '"+txtNombre.Text+"%';" , cnn);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataSet data = new DataSet();
			adaptador.Fill(data, "id_libro");
			dgvLibros.DataSource = data;
			dgvLibros.DataMember = "id_libro"; 
		}
		public void metodoConsultaLibros(){
			MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_libros", cnn);
			MySqlDataAdapter adaptador = new MySqlDataAdapter();
			adaptador.SelectCommand = comando;
			DataTable tabla = new DataTable();
			adaptador.Fill(tabla);
			dgvLibros.DataSource = tabla;
			
			
			
			
		}
		
		
		public void AgreUpdateEventHandler(object sender, AgregarLibros.UpdateEventeArgs args)
		{
			metodoConsultaLibros();
			Buscar();
			this.Enabled=true;
		}
		public void AgreUpdateEventHandler2(object sender, ActualizarLibros.UpdateEventeArgs args)
		{
			metodoConsultaLibros();
			Buscar();
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			AgregarLibros lib = new AgregarLibros();
			lib.UpdateEventHandler += AgreUpdateEventHandler;
			this.Enabled=false;
			lib.principal = this;
			lib.Show();
		}
		void BtnActualizarClick(object sender, EventArgs e)
		{
			ActualizarLibros actu = new ActualizarLibros(id_libro, titulo, anio_edic,  npaginas, id_autor,  precio,  id_edito,  id_tema);
			actu.UpdateEventHandler += AgreUpdateEventHandler2;
			this.Enabled=false;
			actu.principal = this;
			actu.Show();	
		}
		void TxtNombreTextChanged(object sender, EventArgs e)
		{
			Buscar();
			try
			{
                id_libro = dgvLibros.SelectedRows[0].Cells[0].Value.ToString();
                titulo = dgvLibros.SelectedRows[0].Cells[1].Value.ToString();
                anio_edic = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[2].Value);
                npaginas = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[3].Value);
                id_autor = dgvLibros.SelectedRows[0].Cells[4].Value.ToString(); ;
                precio = Convert.ToDecimal(dgvLibros.SelectedRows[0].Cells[5].Value); ;
                id_edito = dgvLibros.SelectedRows[0].Cells[6].Value.ToString(); ;
                id_tema = dgvLibros.SelectedRows[0].Cells[7].Value.ToString(); ;

            }
			catch (ArgumentOutOfRangeException ar)
			{
				metodoConsultaLibros();
			}
			
           
        }
		void CboCamposSelectedIndexChanged(object sender, EventArgs e)
		{
			Buscar();
		}
		void DgvAutoresCellClick(object sender, DataGridViewCellEventArgs e)
		{
			id_libro = dgvLibros.SelectedRows[0].Cells[0].Value.ToString();
		   	titulo = dgvLibros.SelectedRows[0].Cells[1].Value.ToString();
		   	anio_edic = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[2].Value);
		   	npaginas = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[3].Value);
		   	id_autor=dgvLibros.SelectedRows[0].Cells[4].Value.ToString();;
		   	precio=Convert.ToDecimal(dgvLibros.SelectedRows[0].Cells[5].Value);;
		   	id_edito=dgvLibros.SelectedRows[0].Cells[6].Value.ToString();;
		   	id_tema=dgvLibros.SelectedRows[0].Cells[7].Value.ToString();;
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			MessageBoxButtons botones = MessageBoxButtons.YesNo;
			DialogResult dr = MessageBox.Show("¿Desea eliminar este Libro?", "Confirmación", botones);
			if(dr==DialogResult.Yes){
			cnn.Open();
			
				
			string cadenaEliminar = "DELETE FROM tb_libros WHERE id_libro='" + id_libro +"';";
			MySqlCommand cmd = new MySqlCommand(cadenaEliminar, cnn);
			cmd.ExecuteNonQuery();
			cnn.Close();
			MessageBox.Show("Se ha eliminado el libro correctamente");
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
			    
				foreach (DataGridViewColumn col in dgvLibros.Columns){
					ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
					left += col.Width+40;
					if(col.Index < dgvLibros.ColumnCount-1)
					{
						ep.Graphics.DrawLine(Pens.Gray, left-5, top, left-5, top+43+(dgvLibros.RowCount)*dgvAlto);
					}
				}
				left = ep.MarginBounds.Left;
				ep.Graphics.FillRectangle(Brushes.Black, left, top+40, ep.MarginBounds.Right-left,3);
				top += 43;
				
				foreach(DataGridViewRow row in dgvLibros.Rows)
				{
					if(row.Index==dgvLibros.RowCount) break;
					left = ep.MarginBounds.Left;
					foreach(DataGridViewCell cell in row.Cells)
					{
						ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 10), Brushes.Black, left, top + 4);
						left += cell.OwningColumn.Width+40;
						
						
						
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
		
		void DgvLibrosKeyDown(object sender, KeyEventArgs e)
		{
			id_libro = dgvLibros.SelectedRows[0].Cells[0].Value.ToString();
		   	titulo = dgvLibros.SelectedRows[0].Cells[1].Value.ToString();
		   	anio_edic = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[2].Value);
		   	npaginas = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[3].Value);
		   	id_autor=dgvLibros.SelectedRows[0].Cells[4].Value.ToString();;
		   	precio=Convert.ToDecimal(dgvLibros.SelectedRows[0].Cells[5].Value);;
		   	id_edito=dgvLibros.SelectedRows[0].Cells[6].Value.ToString();;
		   	id_tema=dgvLibros.SelectedRows[0].Cells[7].Value.ToString();;
		}
		void DgvLibrosKeyPress(object sender, KeyPressEventArgs e)
		{
			id_libro = dgvLibros.SelectedRows[0].Cells[0].Value.ToString();
		   	titulo = dgvLibros.SelectedRows[0].Cells[1].Value.ToString();
		   	anio_edic = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[2].Value);
		   	npaginas = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[3].Value);
		   	id_autor=dgvLibros.SelectedRows[0].Cells[4].Value.ToString();;
		   	precio=Convert.ToDecimal(dgvLibros.SelectedRows[0].Cells[5].Value);;
		   	id_edito=dgvLibros.SelectedRows[0].Cells[6].Value.ToString();;
		   	id_tema=dgvLibros.SelectedRows[0].Cells[7].Value.ToString();;
		}
		void DgvLibrosKeyUp(object sender, KeyEventArgs e)
		{
			id_libro = dgvLibros.SelectedRows[0].Cells[0].Value.ToString();
		   	titulo = dgvLibros.SelectedRows[0].Cells[1].Value.ToString();
		   	anio_edic = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[2].Value);
		   	npaginas = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[3].Value);
		   	id_autor=dgvLibros.SelectedRows[0].Cells[4].Value.ToString();;
		   	precio=Convert.ToDecimal(dgvLibros.SelectedRows[0].Cells[5].Value);;
		   	id_edito=dgvLibros.SelectedRows[0].Cells[6].Value.ToString();;
		   	id_tema=dgvLibros.SelectedRows[0].Cells[7].Value.ToString();;
		}
		void LibrosLoad(object sender, EventArgs e)
		{
			id_libro = dgvLibros.SelectedRows[0].Cells[0].Value.ToString();
		   	titulo = dgvLibros.SelectedRows[0].Cells[1].Value.ToString();
		   	anio_edic = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[2].Value);
		   	npaginas = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[3].Value);
		   	id_autor=dgvLibros.SelectedRows[0].Cells[4].Value.ToString();;
		   	precio=Convert.ToDecimal(dgvLibros.SelectedRows[0].Cells[5].Value);;
		   	id_edito=dgvLibros.SelectedRows[0].Cells[6].Value.ToString();;
		   	id_tema=dgvLibros.SelectedRows[0].Cells[7].Value.ToString();;
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
        private void cerrarForm(object sender, EventArgs e)
        {
            MENU regresar = new MENU(nom_user);
            regresar.Show();
            this.Dispose();
        }




    }
}
