/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 24/11/2022
 * Hora: 07:07 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace pj_Temas.Libros
{
	partial class ActualizarLibros
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPaginas;
		private System.Windows.Forms.Label lblIdNac;
		private System.Windows.Forms.TextBox txtAnio;
		private System.Windows.Forms.Label lblAp;
		private System.Windows.Forms.Button txtCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label lbD;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblIdNac = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblAp = new System.Windows.Forms.Label();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lbD = new System.Windows.Forms.Label();
            this.cboTema = new System.Windows.Forms.ComboBox();
            this.cboEdito = new System.Windows.Forms.ComboBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.cboAp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 494);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 28);
            this.label4.TabIndex = 79;
            this.label4.Text = "Id Tema";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 28);
            this.label3.TabIndex = 77;
            this.label3.Text = "Id Editorial";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(208, 366);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(357, 26);
            this.txtPrecio.TabIndex = 76;
            this.txtPrecio.Text = "0.0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 75;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 73;
            this.label1.Text = "Id Autor";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginas.Location = new System.Drawing.Point(208, 242);
            this.txtPaginas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(357, 26);
            this.txtPaginas.TabIndex = 72;
            this.txtPaginas.Text = "0";
            // 
            // lblIdNac
            // 
            this.lblIdNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNac.Location = new System.Drawing.Point(43, 246);
            this.lblIdNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdNac.Name = "lblIdNac";
            this.lblIdNac.Size = new System.Drawing.Size(167, 28);
            this.lblIdNac.TabIndex = 71;
            this.lblIdNac.Text = "Paginas";
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Location = new System.Drawing.Point(208, 176);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(357, 26);
            this.txtAnio.TabIndex = 70;
            this.txtAnio.Text = "0";
            // 
            // lblAp
            // 
            this.lblAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAp.Location = new System.Drawing.Point(43, 174);
            this.lblAp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(133, 28);
            this.lblAp.TabIndex = 69;
            this.lblAp.Text = "Año Edición";
            // 
            // txtCancelar
            // 
            this.txtCancelar.BackColor = System.Drawing.Color.Red;
            this.txtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCancelar.Location = new System.Drawing.Point(315, 552);
            this.txtCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(109, 39);
            this.txtCancelar.TabIndex = 68;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = false;
            this.txtCancelar.Click += new System.EventHandler(this.TxtCancelarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(143, 552);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 39);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(43, 108);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 28);
            this.lblTitulo.TabIndex = 66;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(43, 46);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(133, 28);
            this.lblId.TabIndex = 65;
            this.lblId.Text = "Id";
            // 
            // txtTitulo
            // 
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(208, 109);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(503, 26);
            this.txtTitulo.TabIndex = 63;
            // 
            // lbD
            // 
            this.lbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbD.Location = new System.Drawing.Point(208, 46);
            this.lbD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(133, 28);
            this.lbD.TabIndex = 81;
            this.lbD.Text = "Id";
            // 
            // cboTema
            // 
            this.cboTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTema.FormattingEnabled = true;
            this.cboTema.Location = new System.Drawing.Point(212, 494);
            this.cboTema.Name = "cboTema";
            this.cboTema.Size = new System.Drawing.Size(500, 28);
            this.cboTema.TabIndex = 84;
            // 
            // cboEdito
            // 
            this.cboEdito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEdito.FormattingEnabled = true;
            this.cboEdito.Location = new System.Drawing.Point(212, 426);
            this.cboEdito.Name = "cboEdito";
            this.cboEdito.Size = new System.Drawing.Size(499, 28);
            this.cboEdito.TabIndex = 83;
            // 
            // cboAutor
            // 
            this.cboAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(212, 304);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(245, 28);
            this.cboAutor.TabIndex = 82;
            this.cboAutor.SelectedIndexChanged += new System.EventHandler(this.cboAutor_SelectedIndexChanged);
            // 
            // cboAp
            // 
            this.cboAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAp.FormattingEnabled = true;
            this.cboAp.Location = new System.Drawing.Point(474, 304);
            this.cboAp.Name = "cboAp";
            this.cboAp.Size = new System.Drawing.Size(249, 28);
            this.cboAp.TabIndex = 85;
            this.cboAp.SelectedIndexChanged += new System.EventHandler(this.cboAp_SelectedIndexChanged);
            // 
            // ActualizarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 625);
            this.Controls.Add(this.cboAp);
            this.Controls.Add(this.cboTema);
            this.Controls.Add(this.cboEdito);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.lblIdNac);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lblAp);
            this.Controls.Add(this.txtCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtTitulo);
            this.Name = "ActualizarLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarLibros";
            this.Load += new System.EventHandler(this.ActualizarLibrosLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ComboBox cboTema;
        private System.Windows.Forms.ComboBox cboEdito;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.ComboBox cboAp;
    }
}
