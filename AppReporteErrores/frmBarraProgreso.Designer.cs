namespace AppReporteErrores
{
    partial class frmBarraProgreso
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnCargarTabla = new System.Windows.Forms.Button();
            this.lblNroRegistros = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtNroRegistros = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiarTabla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(40, 131);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(574, 247);
            this.dgvTabla.TabIndex = 0;
            // 
            // btnCargarTabla
            // 
            this.btnCargarTabla.Location = new System.Drawing.Point(117, 82);
            this.btnCargarTabla.Name = "btnCargarTabla";
            this.btnCargarTabla.Size = new System.Drawing.Size(75, 23);
            this.btnCargarTabla.TabIndex = 1;
            this.btnCargarTabla.Text = "Mostrar Tabla";
            this.btnCargarTabla.UseVisualStyleBackColor = true;
            this.btnCargarTabla.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // lblNroRegistros
            // 
            this.lblNroRegistros.AutoSize = true;
            this.lblNroRegistros.Location = new System.Drawing.Point(403, 425);
            this.lblNroRegistros.Name = "lblNroRegistros";
            this.lblNroRegistros.Size = new System.Drawing.Size(74, 13);
            this.lblNroRegistros.TabIndex = 2;
            this.lblNroRegistros.Text = "Nro Registros:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(40, 422);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo.TabIndex = 3;
            // 
            // txtNroRegistros
            // 
            this.txtNroRegistros.Location = new System.Drawing.Point(514, 422);
            this.txtNroRegistros.Name = "txtNroRegistros";
            this.txtNroRegistros.ReadOnly = true;
            this.txtNroRegistros.Size = new System.Drawing.Size(100, 20);
            this.txtNroRegistros.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(294, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiarTabla
            // 
            this.btnLimpiarTabla.Location = new System.Drawing.Point(494, 82);
            this.btnLimpiarTabla.Name = "btnLimpiarTabla";
            this.btnLimpiarTabla.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarTabla.TabIndex = 6;
            this.btnLimpiarTabla.Text = "Limpiar Tabla";
            this.btnLimpiarTabla.UseVisualStyleBackColor = true;
            this.btnLimpiarTabla.Click += new System.EventHandler(this.btnLimpiarTabla_Click);
            // 
            // frmBarraProgreso
            // 
            this.ClientSize = new System.Drawing.Size(653, 474);
            this.Controls.Add(this.btnLimpiarTabla);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNroRegistros);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblNroRegistros);
            this.Controls.Add(this.btnCargarTabla);
            this.Controls.Add(this.dgvTabla);
            this.Name = "frmBarraProgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Cargar Tabla";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnCargarTabla;
        private System.Windows.Forms.Label lblNroRegistros;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtNroRegistros;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiarTabla;
    }
}