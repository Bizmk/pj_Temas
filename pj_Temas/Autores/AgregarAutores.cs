/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 23/11/2022
 * Hora: 11:37 p. m.
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

namespace pj_Temas.Autores
{
	/// <summary>
	/// Description of AgregarAutores.
	/// </summary>
	public partial class AgregarAutores : Form
	{
		public Form principal;
		MySqlConnection cnn = Conexion.conex();
		Autores aut = new Autores();
		Nacionalidad.Nacionalidad naleli = new Nacionalidad.Nacionalidad();
		
		
		public AgregarAutores()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Seleccionar(cboNac);
            cboNac.DropDownStyle = ComboBoxStyle.DropDownList;




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

        public void Fac()
        {
            

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
				string strRgx1 = "^[A][0-9]{3}";
				Regex rg1 = new Regex(strRgx1);
				Match c1 = rg1.Match(txtId.Text);
                if (cboNac.SelectedIndex > 0)
                {
                    string[] valores = captar_info(cboNac.Text);
                    
                }

                if (c1.Success){
					
					if (captar_info(cboNac.Text) != null)
					{
						if (txtNombre.Text != "" && txtAp.Text != "")
						{


							try
							{


								principal.Enabled = true;
								string[] valores = captar_info(cboNac.Text);
								cnn.Close();
								cnn.Open();

								string vId = txtId.Text;
								string vNombre = txtNombre.Text;
								string vAp = txtAp.Text;
								string vIdNac = valores[0];
								string cadenaInsertar = "INSERT INTO tb_autores VALUES('" + vId + "', '" + vNombre + "','" + vAp + "', '" + vIdNac + "')";
								MySqlCommand cmd = new MySqlCommand(cadenaInsertar, cnn);
								cmd.ExecuteNonQuery();
								cnn.Close();
								this.Close();
								aut.metodoConsultaAutores();
								aut.Enabled = true;
								Agregar();

							}
                            catch (Exception exception)
                            {
                                MessageBox.Show("Ese ID ya esta registrado");
                            }

                        }
						else
						{
							MessageBox.Show("Por favor rellena todos los campos");
						}
					}
					else
					{
						MessageBox.Show("Por favor selecciona una Nacionalidad");
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

        public void Seleccionar(ComboBox cboNac)
        {
			cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_nacionalidad", cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboNac.Items.Add(dr[1].ToString());
            }
            cnn.Close();
            cboNac.Items.Insert(0, "SELECCIONE UNA NACIONALIDAD");
            cboNac.SelectedIndex = 0;
        }

        public string[] captar_info(string descri_nac)
		{

			cnn.Close();
			cnn.Open();
			MySqlCommand cmd = new MySqlCommand("SELECT id_nac FROM tb_nacionalidad WHERE descri_nac='" + descri_nac + "'", cnn);
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
		
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNac.SelectedIndex > 0)
            {
                string[] valores = captar_info(cboNac.Text);
                
            }

        }

        private void lblIdNac_Click(object sender, EventArgs e)
        {

        }

        private void AgregarAutores_Load(object sender, EventArgs e)
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
