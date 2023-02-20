namespace pj_Temas
{
    partial class MENU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aUTORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIBROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEMASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITORIALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nACIONALIDADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cERRARSESIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWel = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.cREDITOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "LIBRERIA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUTORESToolStripMenuItem,
            this.lIBROSToolStripMenuItem,
            this.tEMASToolStripMenuItem,
            this.eDITORIALESToolStripMenuItem,
            this.nACIONALIDADToolStripMenuItem,
            this.cERRARSESIONToolStripMenuItem,
            this.cREDITOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aUTORESToolStripMenuItem
            // 
            this.aUTORESToolStripMenuItem.Name = "aUTORESToolStripMenuItem";
            this.aUTORESToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aUTORESToolStripMenuItem.Text = "AUTORES";
            this.aUTORESToolStripMenuItem.Click += new System.EventHandler(this.aUTORESToolStripMenuItem_Click);
            // 
            // lIBROSToolStripMenuItem
            // 
            this.lIBROSToolStripMenuItem.Name = "lIBROSToolStripMenuItem";
            this.lIBROSToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.lIBROSToolStripMenuItem.Text = "LIBROS";
            this.lIBROSToolStripMenuItem.Click += new System.EventHandler(this.lIBROSToolStripMenuItem_Click);
            // 
            // tEMASToolStripMenuItem
            // 
            this.tEMASToolStripMenuItem.Name = "tEMASToolStripMenuItem";
            this.tEMASToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tEMASToolStripMenuItem.Text = "TEMAS";
            this.tEMASToolStripMenuItem.Click += new System.EventHandler(this.tEMASToolStripMenuItem_Click);
            // 
            // eDITORIALESToolStripMenuItem
            // 
            this.eDITORIALESToolStripMenuItem.Name = "eDITORIALESToolStripMenuItem";
            this.eDITORIALESToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.eDITORIALESToolStripMenuItem.Text = "EDITORIALES";
            this.eDITORIALESToolStripMenuItem.Click += new System.EventHandler(this.eDITORIALESToolStripMenuItem_Click);
            // 
            // nACIONALIDADToolStripMenuItem
            // 
            this.nACIONALIDADToolStripMenuItem.Name = "nACIONALIDADToolStripMenuItem";
            this.nACIONALIDADToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.nACIONALIDADToolStripMenuItem.Text = "NACIONALIDAD";
            this.nACIONALIDADToolStripMenuItem.Click += new System.EventHandler(this.nACIONALIDADToolStripMenuItem_Click);
            // 
            // cERRARSESIONToolStripMenuItem
            // 
            this.cERRARSESIONToolStripMenuItem.Name = "cERRARSESIONToolStripMenuItem";
            this.cERRARSESIONToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.cERRARSESIONToolStripMenuItem.Text = "CERRAR SESION";
            this.cERRARSESIONToolStripMenuItem.Click += new System.EventHandler(this.cERRARSESIONToolStripMenuItem_Click);
            // 
            // lblWel
            // 
            this.lblWel.AutoSize = true;
            this.lblWel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWel.Location = new System.Drawing.Point(187, 178);
            this.lblWel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWel.Name = "lblWel";
            this.lblWel.Size = new System.Drawing.Size(108, 18);
            this.lblWel.TabIndex = 4;
            this.lblWel.Text = "BIENVENIDO";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(187, 217);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(14, 18);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "-";
            // 
            // cREDITOSToolStripMenuItem
            // 
            this.cREDITOSToolStripMenuItem.Name = "cREDITOSToolStripMenuItem";
            this.cREDITOSToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cREDITOSToolStripMenuItem.Text = "CREDITOS";
            this.cREDITOSToolStripMenuItem.Click += new System.EventHandler(this.cREDITOSToolStripMenuItem_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 453);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblWel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MENU_FormClosing);
            this.Load += new System.EventHandler(this.MENU_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aUTORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIBROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEMASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITORIALESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nACIONALIDADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cERRARSESIONToolStripMenuItem;
        private System.Windows.Forms.Label lblWel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ToolStripMenuItem cREDITOSToolStripMenuItem;
    }
}