/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 24/11/2022
 * Hora: 07:06 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace pj_Temas.Libros
{
	partial class AgregarLibros
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtPaginas;
		private System.Windows.Forms.Label lblIdNac;
		private System.Windows.Forms.TextBox txtAnio;
		private System.Windows.Forms.Label lblAp;
		private System.Windows.Forms.Button txtCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		
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
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblIdNac = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblAp = new System.Windows.Forms.Label();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.cboEdito = new System.Windows.Forms.ComboBox();
            this.cboTema = new System.Windows.Forms.ComboBox();
            this.cboAp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginas.Location = new System.Drawing.Point(208, 253);
            this.txtPaginas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(357, 26);
            this.txtPaginas.TabIndex = 54;
            this.txtPaginas.Text = "0";
            // 
            // lblIdNac
            // 
            this.lblIdNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNac.Location = new System.Drawing.Point(43, 257);
            this.lblIdNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdNac.Name = "lblIdNac";
            this.lblIdNac.Size = new System.Drawing.Size(167, 28);
            this.lblIdNac.TabIndex = 53;
            this.lblIdNac.Text = "Paginas";
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Location = new System.Drawing.Point(208, 187);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(357, 26);
            this.txtAnio.TabIndex = 52;
            this.txtAnio.Text = "0";
            // 
            // lblAp
            // 
            this.lblAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAp.Location = new System.Drawing.Point(43, 185);
            this.lblAp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(133, 28);
            this.lblAp.TabIndex = 51;
            this.lblAp.Text = "Año Edición";
            // 
            // txtCancelar
            // 
            this.txtCancelar.BackColor = System.Drawing.Color.Red;
            this.txtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCancelar.Location = new System.Drawing.Point(405, 566);
            this.txtCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(109, 39);
            this.txtCancelar.TabIndex = 50;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = false;
            this.txtCancelar.Click += new System.EventHandler(this.TxtCancelarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Fuchsia;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(233, 566);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 39);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(43, 119);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 28);
            this.lblTitulo.TabIndex = 48;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(43, 57);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(133, 28);
            this.lblId.TabIndex = 47;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(208, 54);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(201, 26);
            this.txtId.TabIndex = 46;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(208, 120);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(449, 26);
            this.txtTitulo.TabIndex = 45;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 55;
            this.label1.Text = "Autor";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(208, 377);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(357, 26);
            this.txtPrecio.TabIndex = 58;
            this.txtPrecio.Text = "0.0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 57;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 437);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "Editorial";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 505);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 28);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tema";
            // 
            // cboAutor
            // 
            this.cboAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(208, 312);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(249, 28);
            this.cboAutor.TabIndex = 62;
            this.cboAutor.SelectedIndexChanged += new System.EventHandler(this.cboAutor_SelectedIndexChanged_1);
            // 
            // cboEdito
            // 
            this.cboEdito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEdito.FormattingEnabled = true;
            this.cboEdito.Location = new System.Drawing.Point(208, 434);
            this.cboEdito.Name = "cboEdito";
            this.cboEdito.Size = new System.Drawing.Size(448, 28);
            this.cboEdito.TabIndex = 63;
            // 
            // cboTema
            // 
            this.cboTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTema.FormattingEnabled = true;
            this.cboTema.Location = new System.Drawing.Point(208, 502);
            this.cboTema.Name = "cboTema";
            this.cboTema.Size = new System.Drawing.Size(449, 28);
            this.cboTema.TabIndex = 64;
            this.cboTema.SelectedIndexChanged += new System.EventHandler(this.cboTema_SelectedIndexChanged);
            // 
            // cboAp
            // 
            this.cboAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAp.FormattingEnabled = true;
            this.cboAp.Location = new System.Drawing.Point(474, 312);
            this.cboAp.Name = "cboAp";
            this.cboAp.Size = new System.Drawing.Size(249, 28);
            this.cboAp.TabIndex = 65;
            this.cboAp.SelectedIndexChanged += new System.EventHandler(this.cboAp_SelectedIndexChanged);
            // 
            // AgregarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 634);
            this.Controls.Add(this.cboAp);
            this.Controls.Add(this.cboTema);
            this.Controls.Add(this.cboEdito);
            this.Controls.Add(this.cboAutor);
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
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTitulo);
            this.Name = "AgregarLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarLibros";
            this.Load += new System.EventHandler(this.AgregarLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.ComboBox cboEdito;
        private System.Windows.Forms.ComboBox cboTema;
        private System.Windows.Forms.ComboBox cboAp;
    }
}
