using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pj_Temas
{
    public partial class MENU : Form
    {
        new cbRegistros cbb = new cbRegistros();
        
        public MENU(string nom_user)
        {
            InitializeComponent();
            this.nom_user = nom_user;
            lblNom.Text = Session.nom_user;
            
        }
        string nom_user;

        private void aUTORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autores.Autores aut = new pj_Temas.Autores.Autores();
            aut.Visible= true;
            this.Visible=false;
        }

        private void lIBROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libros.Libros lib = new pj_Temas.Libros.Libros();
            lib.Show();
            this.Hide(); 
        }

        private void tEMASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temas temas = new Temas();
            temas.Show();
            this.Hide();
        }

        private void eDITORIALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editoriales.Editoriales edito = new pj_Temas.Editoriales.Editoriales();
            edito.Show();
            this.Hide();
        }

        private void nACIONALIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nacionalidad.Nacionalidad nac = new pj_Temas.Nacionalidad.Nacionalidad();
            nac.Show();
            this.Hide();
        }

        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbRegistros registros = new cbRegistros();
            registros.Visible = true;
            this.Dispose();
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            
        }

        private void MENU_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbRegistros registros = new cbRegistros();
            registros.Show();
            this.Dispose();
        }

        private void cREDITOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Dispose();
        }
    }
}
