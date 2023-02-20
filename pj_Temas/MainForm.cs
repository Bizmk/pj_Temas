/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 02/11/2022
 * Hora: 11:06 p. m.
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

namespace pj_Temas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class cbRegistros : Form
	{

        MySqlConnection cnn = Conexion.conex();
        public cbRegistros()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            Seleccionar(cboUser);
            cboUser.DropDownStyle = ComboBoxStyle.DropDownList;




            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
		string nom_user="";
        public void Seleccionar(ComboBox cboUser)
        {
            cnn.Close();
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_usuarios", cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboUser.Items.Add(dr[1].ToString());
            }
            cnn.Close();
            cboUser.Items.Insert(0, "SELECCIONE UN USUARIO");
            cboUser.SelectedIndex = 0;
        }
		
		

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo_user = cboUser.Text;
            string clave = txtPass.Text;

            try
            {
                Control ctrl = new Control();
                string respuesta = ctrl.ctrlLogin(tipo_user, clave);
                if(respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MENU frm = new MENU(nom_user);
                    frm.Visible = true;
                    this.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        private void cbRegistros_Load(object sender, EventArgs e)
        {

        }

        private void cbRegistros_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                Application.Exit();
            }
            catch (InvalidOperationException invalid)
            {
                Application.ExitThread();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (InvalidOperationException invalid)
            {
                Application.ExitThread();
                
            }
        }
    }
}
