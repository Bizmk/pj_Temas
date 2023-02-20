/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 23/11/2022
 * Hora: 11:37 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace pj_Temas.Autores
{
	partial class AcutalizarAutores
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblIdNac;
		private System.Windows.Forms.TextBox txtAp;
		private System.Windows.Forms.Label lblAp;
		private System.Windows.Forms.Button txtCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lbID;
		
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
            this.lblIdNac = new System.Windows.Forms.Label();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.lblAp = new System.Windows.Forms.Label();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.cboNac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIdNac
            // 
            this.lblIdNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNac.Location = new System.Drawing.Point(43, 239);
            this.lblIdNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdNac.Name = "lblIdNac";
            this.lblIdNac.Size = new System.Drawing.Size(167, 28);
            this.lblIdNac.TabIndex = 53;
            this.lblIdNac.Text = "Id Nacionalidad";
            // 
            // txtAp
            // 
            this.txtAp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAp.Location = new System.Drawing.Point(208, 169);
            this.txtAp.Margin = new System.Windows.Forms.Padding(4);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(357, 26);
            this.txtAp.TabIndex = 52;
            // 
            // lblAp
            // 
            this.lblAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAp.Location = new System.Drawing.Point(43, 167);
            this.lblAp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(133, 28);
            this.lblAp.TabIndex = 51;
            this.lblAp.Text = "Apellidos";
            // 
            // txtCancelar
            // 
            this.txtCancelar.BackColor = System.Drawing.Color.Red;
            this.txtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCancelar.Location = new System.Drawing.Point(315, 389);
            this.txtCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(109, 39);
            this.txtCancelar.TabIndex = 50;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = false;
            this.txtCancelar.Click += new System.EventHandler(this.txtCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(148, 389);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 39);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(43, 39);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(133, 28);
            this.lblId.TabIndex = 47;
            this.lblId.Text = "Id";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(208, 102);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(357, 26);
            this.txtNombre.TabIndex = 45;
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(208, 39);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(133, 28);
            this.lbID.TabIndex = 55;
            this.lbID.Text = "Id";
            // 
            // cboNac
            // 
            this.cboNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNac.FormattingEnabled = true;
            this.cboNac.Location = new System.Drawing.Point(212, 237);
            this.cboNac.Name = "cboNac";
            this.cboNac.Size = new System.Drawing.Size(353, 26);
            this.cboNac.TabIndex = 56;
            // 
            // AcutalizarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 464);
            this.Controls.Add(this.cboNac);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lblIdNac);
            this.Controls.Add(this.txtAp);
            this.Controls.Add(this.lblAp);
            this.Controls.Add(this.txtCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AcutalizarAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcutalizarAutores";
            this.Load += new System.EventHandler(this.AcutalizarAutoresLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ComboBox cboNac;
    }
}
