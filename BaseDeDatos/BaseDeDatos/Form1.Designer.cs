﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TablaTfnos = new System.Windows.Forms.DataGridView();
            this.colFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCasado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaTfnos)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaTfnos
            // 
            this.TablaTfnos.AllowUserToOrderColumns = true;
            this.TablaTfnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaTfnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TablaTfnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaTfnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFoto,
            this.colNombre,
            this.colDireccion,
            this.colTelefono,
            this.colCasado});
            this.TablaTfnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaTfnos.Location = new System.Drawing.Point(0, 0);
            this.TablaTfnos.Name = "TablaTfnos";
            this.TablaTfnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TablaTfnos.Size = new System.Drawing.Size(534, 272);
            this.TablaTfnos.TabIndex = 0;
            this.TablaTfnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaTfnos_CellClick);
            this.TablaTfnos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.TablaTfnos_CellFormatting);
            // 
            // colFoto
            // 
            this.colFoto.Name = "colFoto";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.Name = "colDireccion";
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colCasado
            // 
            this.colCasado.HeaderText = "Casado";
            this.colCasado.Name = "colCasado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 272);
            this.Controls.Add(this.TablaTfnos);
            this.Name = "Form1";
            this.Text = "Telefonos";
            ((System.ComponentModel.ISupportInitialize)(this.TablaTfnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaTfnos;
        private System.Windows.Forms.DataGridViewImageColumn colFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCasado;
    }
}

