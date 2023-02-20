/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 18/11/2022
 * Hora: 11:20 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace pj_Temas.Editoriales
{
	partial class Editoriales
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox cboCampos;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnAgregar;
		
		private System.Windows.Forms.Label lblTemas;
		private System.Windows.Forms.DataGridView dgvEditoriales;
		
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
            this.cboCampos = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTemas = new System.Windows.Forms.Label();
            this.dgvEditoriales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCampos
            // 
            this.cboCampos.FormattingEnabled = true;
            this.cboCampos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboCampos.IntegralHeight = false;
            this.cboCampos.Items.AddRange(new object[] {
            "id_edito",
            "nom_edito",
            "direcc",
            "email",
            "tel"});
            this.cboCampos.Location = new System.Drawing.Point(521, 75);
            this.cboCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCampos.Name = "cboCampos";
            this.cboCampos.Size = new System.Drawing.Size(121, 24);
            this.cboCampos.TabIndex = 34;
            this.cboCampos.Text = "id_edito";
            this.cboCampos.SelectedIndexChanged += new System.EventHandler(this.CboCamposSelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(243, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 22);
            this.txtNombre.TabIndex = 33;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombreTextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Location = new System.Drawing.Point(507, 368);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(109, 39);
            this.btnImprimir.TabIndex = 32;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimirClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Red;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(641, 368);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(109, 39);
            this.btnRegresar.TabIndex = 31;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(375, 368);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 39);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(241, 368);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 39);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "Acutalizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(109, 368);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 39);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
            // 
            // lblTemas
            // 
            this.lblTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTemas.Location = new System.Drawing.Point(309, 11);
            this.lblTemas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemas.Name = "lblTemas";
            this.lblTemas.Size = new System.Drawing.Size(259, 39);
            this.lblTemas.TabIndex = 35;
            this.lblTemas.Text = "EDITORIALES";
            this.lblTemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEditoriales
            // 
            this.dgvEditoriales.AllowUserToAddRows = false;
            this.dgvEditoriales.AllowUserToDeleteRows = false;
            this.dgvEditoriales.AllowUserToResizeColumns = false;
            this.dgvEditoriales.AllowUserToResizeRows = false;
            this.dgvEditoriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEditoriales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditoriales.Location = new System.Drawing.Point(84, 117);
            this.dgvEditoriales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEditoriales.Name = "dgvEditoriales";
            this.dgvEditoriales.ReadOnly = true;
            this.dgvEditoriales.RowHeadersVisible = false;
            this.dgvEditoriales.RowHeadersWidth = 51;
            this.dgvEditoriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditoriales.Size = new System.Drawing.Size(697, 234);
            this.dgvEditoriales.TabIndex = 36;
            this.dgvEditoriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEditorialesCellClick);
            this.dgvEditoriales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvEditorialesKeyDown);
            this.dgvEditoriales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvEditorialesKeyPress);
            this.dgvEditoriales.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvEditorialesKeyUp);
            // 
            // Editoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 468);
            this.Controls.Add(this.dgvEditoriales);
            this.Controls.Add(this.lblTemas);
            this.Controls.Add(this.cboCampos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Editoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editoriales";
            this.Load += new System.EventHandler(this.EditorialesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		}
	}

