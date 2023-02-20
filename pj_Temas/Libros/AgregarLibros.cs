/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 24/11/2022
 * Hora: 07:06 a. m.
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
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;

namespace pj_Temas.Libros
{
	/// <summary>
	/// Description of AgregarLibros.
	/// </summary>
	public partial class AgregarLibros : Form
	{
		public Form principal;
		MySqlConnection cnn = Conexion.conex();
		Libros lib = new Libros();
        string nombre;
        string ap;
        public AgregarLibros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            cboAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEdito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTema.DropDownStyle = ComboBoxStyle.DropDownList;

            Seleccionar(cboAutor);
            Seleccionar0(cboAp);
            Seleccionar2(cboEdito);
            Seleccionar3(cboTema);
            
			
			
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

                if (cboAutor.SelectedIndex > 0)
                {
                    string[] valores = captar_info(cboAutor.Text, cboAp.Text);


                }
                if (cboEdito.SelectedIndex > 0)
                {
                    string[] valores2 = captar_info2(cboEdito.Text);


                }
                if (cboTema.SelectedIndex > 0)
                {
                    string[] valores3 = captar_info3(cboTema.Text);


                }
                string strRgx5 = "^[L][0-9]{3}";
                        Regex rg5 = new Regex(strRgx5);
                        Match c5 = rg5.Match(txtId.Text);
                
				if(c5.Success){
                    if (captar_info(cboAutor.Text, cboAp.Text) != null)
                    {
                        if (captar_info2(cboEdito.Text) != null)
                        {
                            if (captar_info3(cboTema.Text) != null)
                            {


                                try
                                {


                                    if (txtTitulo.Text != "" && int.Parse(txtAnio.Text) != 0 && int.Parse(txtPaginas.Text) != 0 && decimal.Parse(txtPrecio.Text) != 0)
                                    {




                                        try
                                        {

                                            principal.Enabled = true;
                                            string[] valores = captar_info(cboAutor.Text, cboAp.Text);
                                            string[] valores2 = captar_info2(cboEdito.Text);
                                            string[] valores3 = captar_info3(cboTema.Text);
                                            cnn.Close();
                                            cnn.Open();
                                            string vId = txtId.Text;
                                            string vTitulo = txtTitulo.Text;
                                            int vAnio = int.Parse(txtAnio.Text);
                                            int vPag = int.Parse(txtPaginas.Text);
                                            string vAut = valores[0];
                                            decimal vPre = decimal.Parse(txtPrecio.Text);
                                            string vEdi = valores2[0];
                                            string vTema = valores3[0];



                                            string cadenaInsertar = "INSERT INTO tb_libros VALUES('" + vId + "', '" + vTitulo + "'," + vAnio + ", " + vPag + ", '" + vAut + "', " + vPre + ", '" + vEdi + "', '" + vTema + "')";
                                            MySqlCommand cmd = new MySqlCommand(cadenaInsertar, cnn);
                                            cmd.ExecuteNonQuery();
                                            cnn.Close();
                                            this.Close();
                                            lib.metodoConsultaLibros();
                                            lib.Enabled = true;
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
                                        MessageBox.Show("Por favor rellena correctamente todos los campos");
                                    }
                                }
                                catch(FormatException fo)
                                {
                                    MessageBox.Show("Por favor rellena correctamente todos los campos");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Por favor selecciona un Tema");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor seleccionar una Editorial");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccionar un Nombre o un Apellido");
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
			this.Close();
		}

        public void Seleccionar(ComboBox cboAutor)
        {
            cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_autores", cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                

                cboAutor.Items.Add(dr[1].ToString());
                


            }
            cnn.Clone();
            cboAutor.Items.Insert(0,"SELECCIONE POR NOMBRE");
            cboAutor.SelectedIndex = 0;
        }

        public void Seleccionar0(ComboBox cboAp)
        {
            cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_autores", cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cboAp.Items.Add(dr[2].ToString());





            }
            
            cnn.Clone();
            cboAp.Items.Insert(0, " SELECCIONE POR APELLIDO");
            cboAp.SelectedIndex = 0;
        }
        public string[] captar_info(string nom_aut, string ap)
        {
            cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT id_autor FROM tb_autores WHERE nom_aut='"+nom_aut+"' AND ap='"+ap+"'", cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString()
                };
                resultado = valores;
            }
            cnn.Close();
            return resultado;
        }

        private void cboTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void Seleccionar2(ComboBox cboEdito)
        {
            cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_editoriales", cnn);
            MySqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cboEdito.Items.Add(dr2[1].ToString());
            }
            cnn.Clone();
            cboEdito.Items.Insert(0, "SELECCIONE UNA EDITORIAL");
            cboEdito.SelectedIndex = 0;
        }

        public string[] captar_info2(string nom_edito)
        {
            cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT id_edito FROM tb_editoriales WHERE nom_edito='" + nom_edito + "'", cnn);
            MySqlDataReader dr2 = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr2.Read())
            {
                string[] valores2 =
                {
                    dr2[0].ToString()
                };
                resultado = valores2;
            }
            cnn.Clone();
            return resultado;
        }

        public void Seleccionar3(ComboBox cboNac)
        {
            cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_temas", cnn);
            MySqlDataReader dr3 = cmd.ExecuteReader();
            while (dr3.Read())
            {
                cboNac.Items.Add(dr3[1].ToString());
            }
            cnn.Clone();
            cboNac.Items.Insert(0, "SELECCIONE UN TEMA");
            cboNac.SelectedIndex = 0;
        }

        public string[] captar_info3(string nom_tema)
        {
            cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT id_tema FROM tb_temas WHERE nom_tema='" + nom_tema + "'", cnn);
            MySqlDataReader dr3 = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr3.Read())
            {
                string[] valores3 =
                {
                    dr3[0].ToString()
                };
                resultado = valores3;
            }
            cnn.Clone();
            return resultado;
        }

        private void cboAp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAp.SelectedIndex > 0)
            {
                string[] valores = captar_info1(cboAp.Text);
                cboAutor.Text = valores[0];


            }

        }
        public string[] captar_info0(string nom_aut)
        {
            cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT ap FROM tb_autores WHERE nom_aut='" + nom_aut + "'", cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores1 =
                {
                    dr[0].ToString()
                };
                resultado = valores1;
            }
            cnn.Close();
            return resultado;
        }
        public string[] captar_info1(string ap)
        {
            cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT nom_aut FROM tb_autores WHERE ap='" + ap + "'", cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores1 =
                {
                    dr[0].ToString()
                };
                resultado = valores1;
            }
            cnn.Close();
            return resultado;
        }





        private void cboAutor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboAutor.SelectedIndex > 0)
            {
                string[] valores = captar_info0(cboAutor.Text);
                cboAp.Text = valores[0];


            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarLibros_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }

        private void cerrarForm(object sender, EventArgs e)
        {
            principal.Enabled = true;
            this.Dispose();
        }

       
    }
}
