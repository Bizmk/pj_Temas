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


namespace pj_Temas.Autores
{
	/// <summary>
	/// Description of AcutalizarAutores.
	/// </summary>
	public partial class AcutalizarAutores : Form
	{
		MySqlConnection cnn = Conexion.conex();
		Autores aut= new Autores();
		public Form principal;
		public AcutalizarAutores(string id_autor, string nom_aut, string ap, string id_nac)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.id_autor=id_autor;
			this.nom_aut=nom_aut;
			this.ap=ap;
			this.id_nac=id_nac;
			Seleccionar(cboNac);
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string id_autor;
		string nom_aut;
		string ap;
		string id_nac;
		
        

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
		void AcutalizarAutoresLoad(object sender, EventArgs e)
		{
            MySqlCommand cmd = new MySqlCommand("SELECT descri_nac FROM tb_nacionalidad WHERE id_nac='" + id_nac + "'", cnn);
			cnn.Close();
			cnn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               id_nac = dr.GetString(0);
            }
			cnn.Close();
            cboNac.Text = id_nac;
            lbID.Text= id_autor;
			txtNombre.Text= nom_aut;
			txtAp.Text= ap;


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
            if (cboNac.SelectedIndex > 0)
            {
                string[] valores = captar_info(cboNac.Text);

            }
            if (dr==DialogResult.Yes){
				
				
				if(cboNac.Text != null) 
				{
                    if (txtNombre.Text != "" && txtAp.Text != "")
                    {

                        try
						{
						principal.Enabled=true;
						string[] valores = captar_info(cboNac.Text);
						cnn.Close();
						cnn.Open();
						string vId=lbID.Text;
						string vNombre=txtNombre.Text;
						string vAp=txtAp.Text;
						string vIdNac = valores[0]; 
						
						
						string cadenaActualizar = "UPDATE tb_autores SET nom_aut='" + vNombre +
													"', ap='"+vAp+"', " +
													"id_nac= '"+vIdNac+"'" +
													" WHERE id_autor='" + vId+
													"';";
						MySqlCommand cmd = new MySqlCommand(cadenaActualizar, cnn);
						cmd.ExecuteNonQuery();
						cnn.Close();
						this.Close();
						aut.metodoConsultaAutores();
						aut.Enabled=true;
						MessageBox.Show("Se actualizo el autor");
						Agregar();
						}
						catch(Exception exception)
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
            cnn.Clone();
            if (cboNac.SelectedIndex > 0)
            {
                string[] valores = captar_info(cboNac.Text);
                string descri = valores[0];
                cboNac.Items.Insert(0, descri);
				cboNac.Text = descri;

            }
            




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
            cnn.Clone();
            return resultado;
        }

        private void txtIdNac_TextChanged(object sender, EventArgs e)
        {
            if(cboNac.SelectedIndex > 0)
            {
                string[] valores = captar_info(cboNac.Text);

            }
        }

        private void cboNac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            principal.Enabled = true;
            this.Close();
        }
    }
}
