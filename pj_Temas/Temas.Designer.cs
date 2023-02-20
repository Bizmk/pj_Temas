/*
 * Creado por SharpDevelop.
 * Usuario: yevge
 * Fecha: 13/11/2022
 * Hora: 09:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace pj_Temas
{
	partial class Temas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvTemas;
		private System.Windows.Forms.Label lblTemas;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.ComboBox cboCampos;
		private System.Drawing.Printing.PrintDocument Imprimir;
		
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
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.lblTemas = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboCampos = new System.Windows.Forms.ComboBox();
            this.Imprimir = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTemas
            // 
            this.dgvTemas.AllowUserToAddRows = false;
            this.dgvTemas.AllowUserToDeleteRows = false;
            this.dgvTemas.AllowUserToResizeColumns = false;
            this.dgvTemas.AllowUserToResizeRows = false;
            this.dgvTemas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTemas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTemas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Location = new System.Drawing.Point(84, 107);
            this.dgvTemas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.ReadOnly = true;
            this.dgvTemas.RowHeadersVisible = false;
            this.dgvTemas.RowHeadersWidth = 51;
            this.dgvTemas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTemas.Size = new System.Drawing.Size(697, 234);
            this.dgvTemas.TabIndex = 1;
            this.dgvTemas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTemasCellClick);
            this.dgvTemas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvTemasKeyDown);
            this.dgvTemas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvTemasKeyPress);
            this.dgvTemas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvTemasKeyUp);
            // 
            // lblTemas
            // 
            this.lblTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTemas.Location = new System.Drawing.Point(301, 11);
            this.lblTemas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemas.Name = "lblTemas";
            this.lblTemas.Size = new System.Drawing.Size(259, 39);
            this.lblTemas.TabIndex = 19;
            this.lblTemas.Text = "TEMAS";
            this.lblTemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Location = new System.Drawing.Point(513, 366);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(109, 39);
            this.btnImprimir.TabIndex = 24;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimirClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Red;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(648, 366);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(109, 39);
            this.btnRegresar.TabIndex = 23;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(381, 366);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 39);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(248, 366);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 39);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Acutalizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(116, 366);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 39);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(249, 75);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 22);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombreTextChanged);
            // 
            // cboCampos
            // 
            this.cboCampos.FormattingEnabled = true;
            this.cboCampos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboCampos.IntegralHeight = false;
            this.cboCampos.Items.AddRange(new object[] {
            "id_tema",
            "nom_tema"});
            this.cboCampos.Location = new System.Drawing.Point(528, 73);
            this.cboCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCampos.Name = "cboCampos";
            this.cboCampos.Size = new System.Drawing.Size(121, 24);
            this.cboCampos.TabIndex = 26;
            this.cboCampos.Text = "id_tema";
            this.cboCampos.SelectedIndexChanged += new System.EventHandler(this.CboCamposSelectedIndexChanged);
            // 
            // Temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 468);
            this.Controls.Add(this.cboCampos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTemas);
            this.Controls.Add(this.dgvTemas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Temas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temas";
            this.Load += new System.EventHandler(this.TemasLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		}
	}

