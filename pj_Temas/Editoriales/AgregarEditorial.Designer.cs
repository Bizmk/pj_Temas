/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 18/11/2022
 * Hora: 11:27 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace pj_Temas.Editoriales
{
	partial class AgregarEditorial
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button txtCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblDirecc;
		private System.Windows.Forms.TextBox txtDirecc;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblTel;
		private System.Windows.Forms.TextBox txtTel;
		
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
            this.txtCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDirecc = new System.Windows.Forms.Label();
            this.txtDirecc = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCancelar
            // 
            this.txtCancelar.BackColor = System.Drawing.Color.Red;
            this.txtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCancelar.Location = new System.Drawing.Point(323, 384);
            this.txtCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(109, 39);
            this.txtCancelar.TabIndex = 28;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = false;
            this.txtCancelar.Click += new System.EventHandler(this.TxtCancelarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Fuchsia;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(156, 384);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 39);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(51, 34);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(133, 28);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(216, 31);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(201, 26);
            this.txtId.TabIndex = 24;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(216, 97);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(357, 26);
            this.txtNombre.TabIndex = 23;
            // 
            // lblDirecc
            // 
            this.lblDirecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecc.Location = new System.Drawing.Point(51, 162);
            this.lblDirecc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirecc.Name = "lblDirecc";
            this.lblDirecc.Size = new System.Drawing.Size(133, 28);
            this.lblDirecc.TabIndex = 29;
            this.lblDirecc.Text = "Direccion";
            // 
            // txtDirecc
            // 
            this.txtDirecc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDirecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirecc.Location = new System.Drawing.Point(216, 164);
            this.txtDirecc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirecc.Name = "txtDirecc";
            this.txtDirecc.Size = new System.Drawing.Size(357, 26);
            this.txtDirecc.TabIndex = 30;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(51, 229);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(133, 28);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(216, 230);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(357, 26);
            this.txtEmail.TabIndex = 32;
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(51, 302);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(133, 28);
            this.lblTel.TabIndex = 33;
            this.lblTel.Text = "Teléfono";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(216, 298);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(357, 26);
            this.txtTel.TabIndex = 34;
            // 
            // AgregarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 464);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDirecc);
            this.Controls.Add(this.lblDirecc);
            this.Controls.Add(this.txtCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarEditorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEditorial";
            this.Load += new System.EventHandler(this.AgregarEditorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
