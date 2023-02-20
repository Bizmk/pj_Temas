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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nom_user;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MENU frm = new MENU(nom_user);
            frm.Visible = true;
            this.Visible = false;
        }
    }
}
