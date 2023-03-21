namespace AppReporteErrores
{
    partial class frmNominal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarErrores = new System.Windows.Forms.Button();
            this.dgvNominalErrores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadFilas = new System.Windows.Forms.TextBox();
            this.btnCargarTramas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominalErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarErrores
            // 
            this.btnMostrarErrores.Location = new System.Drawing.Point(656, 153);
            this.btnMostrarErrores.Name = "btnMostrarErrores";
            this.btnMostrarErrores.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarErrores.TabIndex = 0;
            this.btnMostrarErrores.Text = "Mostrar";
            this.btnMostrarErrores.UseVisualStyleBackColor = true;
            this.btnMostrarErrores.Click += new System.EventHandler(this.btnMostrarErrores_Click);
            // 
            // dgvNominalErrores
            // 
            this.dgvNominalErrores.AllowUserToAddRows = false;
            this.dgvNominalErrores.AllowUserToDeleteRows = false;
            this.dgvNominalErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNominalErrores.Location = new System.Drawing.Point(31, 196);
            this.dgvNominalErrores.Name = "dgvNominalErrores";
            this.dgvNominalErrores.ReadOnly = true;
            this.dgvNominalErrores.Size = new System.Drawing.Size(723, 186);
            this.dgvNominalErrores.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° Registros:";
            // 
            // txtCantidadFilas
            // 
            this.txtCantidadFilas.Enabled = false;
            this.txtCantidadFilas.Location = new System.Drawing.Point(103, 405);
            this.txtCantidadFilas.Name = "txtCantidadFilas";
            this.txtCantidadFilas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadFilas.TabIndex = 3;
            // 
            // btnCargarTramas
            // 
            this.btnCargarTramas.Location = new System.Drawing.Point(608, 62);
            this.btnCargarTramas.Name = "btnCargarTramas";
            this.btnCargarTramas.Size = new System.Drawing.Size(123, 23);
            this.btnCargarTramas.TabIndex = 4;
            this.btnCargarTramas.Text = "Cargar Tramas";
            this.btnCargarTramas.UseVisualStyleBackColor = true;
            this.btnCargarTramas.Click += new System.EventHandler(this.btnCargarTramas_Click);
            // 
            // frmNominal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarTramas);
            this.Controls.Add(this.txtCantidadFilas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNominalErrores);
            this.Controls.Add(this.btnMostrarErrores);
            this.Name = "frmNominal";
            this.Text = "Nominal de Errores";
            this.Load += new System.EventHandler(this.frmNominal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominalErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarErrores;
        private System.Windows.Forms.DataGridView dgvNominalErrores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadFilas;
        private System.Windows.Forms.Button btnCargarTramas;
    }
}

