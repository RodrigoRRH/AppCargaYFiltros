namespace AppReporteErrores
{
    partial class frmCargarTramas
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
            this.gboTramas = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.rdbRegistrador = new System.Windows.Forms.RadioButton();
            this.rdbPaciente = new System.Windows.Forms.RadioButton();
            this.rdbPersonal = new System.Windows.Forms.RadioButton();
            this.rdbTrama = new System.Windows.Forms.RadioButton();
            this.gboArchivo = new System.Windows.Forms.GroupBox();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.dgvResumenTramas = new System.Windows.Forms.DataGridView();
            this.dgvResumenPersonas = new System.Windows.Forms.DataGridView();
            this.btnBorrarTablas = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnCargarMensaje = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gboTramas.SuspendLayout();
            this.gboArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenTramas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.MaximumSize = new System.Drawing.Size(350, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGAR TRAMAS";
            // 
            // gboTramas
            // 
            this.gboTramas.Controls.Add(this.label3);
            this.gboTramas.Controls.Add(this.label2);
            this.gboTramas.Controls.Add(this.cboMes);
            this.gboTramas.Controls.Add(this.cboAnio);
            this.gboTramas.Controls.Add(this.rdbRegistrador);
            this.gboTramas.Controls.Add(this.rdbPaciente);
            this.gboTramas.Controls.Add(this.rdbPersonal);
            this.gboTramas.Controls.Add(this.rdbTrama);
            this.gboTramas.Location = new System.Drawing.Point(41, 43);
            this.gboTramas.Name = "gboTramas";
            this.gboTramas.Size = new System.Drawing.Size(542, 117);
            this.gboTramas.TabIndex = 1;
            this.gboTramas.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 16);
            this.label3.MaximumSize = new System.Drawing.Size(350, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 16);
            this.label2.MaximumSize = new System.Drawing.Size(350, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AÑO";
            // 
            // cboMes
            // 
            this.cboMes.Enabled = false;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMes.Location = new System.Drawing.Point(341, 46);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 21);
            this.cboMes.TabIndex = 5;
            // 
            // cboAnio
            // 
            this.cboAnio.Enabled = false;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cboAnio.Location = new System.Drawing.Point(185, 46);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(121, 21);
            this.cboAnio.TabIndex = 4;
            // 
            // rdbRegistrador
            // 
            this.rdbRegistrador.AutoSize = true;
            this.rdbRegistrador.Location = new System.Drawing.Point(356, 85);
            this.rdbRegistrador.Name = "rdbRegistrador";
            this.rdbRegistrador.Size = new System.Drawing.Size(79, 17);
            this.rdbRegistrador.TabIndex = 3;
            this.rdbRegistrador.TabStop = true;
            this.rdbRegistrador.Text = "Registrador";
            this.rdbRegistrador.UseVisualStyleBackColor = true;
            this.rdbRegistrador.CheckedChanged += new System.EventHandler(this.rdbRegistrador_CheckedChanged);
            // 
            // rdbPaciente
            // 
            this.rdbPaciente.AutoSize = true;
            this.rdbPaciente.Location = new System.Drawing.Point(209, 85);
            this.rdbPaciente.Name = "rdbPaciente";
            this.rdbPaciente.Size = new System.Drawing.Size(67, 17);
            this.rdbPaciente.TabIndex = 2;
            this.rdbPaciente.TabStop = true;
            this.rdbPaciente.Text = "Paciente";
            this.rdbPaciente.UseVisualStyleBackColor = true;
            this.rdbPaciente.CheckedChanged += new System.EventHandler(this.rdbPaciente_CheckedChanged);
            // 
            // rdbPersonal
            // 
            this.rdbPersonal.AutoSize = true;
            this.rdbPersonal.Location = new System.Drawing.Point(41, 85);
            this.rdbPersonal.Name = "rdbPersonal";
            this.rdbPersonal.Size = new System.Drawing.Size(66, 17);
            this.rdbPersonal.TabIndex = 1;
            this.rdbPersonal.TabStop = true;
            this.rdbPersonal.Text = "Personal";
            this.rdbPersonal.UseVisualStyleBackColor = true;
            this.rdbPersonal.CheckedChanged += new System.EventHandler(this.rdbPersonal_CheckedChanged);
            // 
            // rdbTrama
            // 
            this.rdbTrama.AutoSize = true;
            this.rdbTrama.Location = new System.Drawing.Point(41, 50);
            this.rdbTrama.Name = "rdbTrama";
            this.rdbTrama.Size = new System.Drawing.Size(55, 17);
            this.rdbTrama.TabIndex = 0;
            this.rdbTrama.TabStop = true;
            this.rdbTrama.Text = "Trama";
            this.rdbTrama.UseVisualStyleBackColor = true;
            this.rdbTrama.CheckedChanged += new System.EventHandler(this.rdbTrama_CheckedChanged);
            // 
            // gboArchivo
            // 
            this.gboArchivo.Controls.Add(this.btnCargarArchivo);
            this.gboArchivo.Controls.Add(this.btnAbrirArchivo);
            this.gboArchivo.Controls.Add(this.txtRutaArchivo);
            this.gboArchivo.Location = new System.Drawing.Point(41, 166);
            this.gboArchivo.Name = "gboArchivo";
            this.gboArchivo.Size = new System.Drawing.Size(542, 109);
            this.gboArchivo.TabIndex = 2;
            this.gboArchivo.TabStop = false;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(295, 32);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(167, 23);
            this.btnCargarArchivo.TabIndex = 2;
            this.btnCargarArchivo.Text = "Cargar Archivo a la BD";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(98, 32);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(146, 23);
            this.btnAbrirArchivo.TabIndex = 1;
            this.btnAbrirArchivo.Text = "Seleccionar Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Enabled = false;
            this.txtRutaArchivo.Location = new System.Drawing.Point(41, 74);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(469, 20);
            this.txtRutaArchivo.TabIndex = 0;
            // 
            // dgvResumenTramas
            // 
            this.dgvResumenTramas.AllowUserToAddRows = false;
            this.dgvResumenTramas.AllowUserToDeleteRows = false;
            this.dgvResumenTramas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvResumenTramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenTramas.Location = new System.Drawing.Point(41, 411);
            this.dgvResumenTramas.Name = "dgvResumenTramas";
            this.dgvResumenTramas.ReadOnly = true;
            this.dgvResumenTramas.Size = new System.Drawing.Size(510, 150);
            this.dgvResumenTramas.TabIndex = 4;
            // 
            // dgvResumenPersonas
            // 
            this.dgvResumenPersonas.AllowUserToAddRows = false;
            this.dgvResumenPersonas.AllowUserToDeleteRows = false;
            this.dgvResumenPersonas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvResumenPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenPersonas.Location = new System.Drawing.Point(41, 281);
            this.dgvResumenPersonas.Name = "dgvResumenPersonas";
            this.dgvResumenPersonas.ReadOnly = true;
            this.dgvResumenPersonas.Size = new System.Drawing.Size(510, 115);
            this.dgvResumenPersonas.TabIndex = 5;
            // 
            // btnBorrarTablas
            // 
            this.btnBorrarTablas.Location = new System.Drawing.Point(476, 590);
            this.btnBorrarTablas.Name = "btnBorrarTablas";
            this.btnBorrarTablas.Size = new System.Drawing.Size(120, 40);
            this.btnBorrarTablas.TabIndex = 6;
            this.btnBorrarTablas.Text = "Borrar Tablas";
            this.btnBorrarTablas.UseVisualStyleBackColor = true;
            this.btnBorrarTablas.Click += new System.EventHandler(this.btnBorrarTablas_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(41, 567);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(352, 20);
            this.txtMensaje.TabIndex = 7;
            // 
            // btnCargarMensaje
            // 
            this.btnCargarMensaje.Location = new System.Drawing.Point(554, 345);
            this.btnCargarMensaje.Name = "btnCargarMensaje";
            this.btnCargarMensaje.Size = new System.Drawing.Size(75, 23);
            this.btnCargarMensaje.TabIndex = 8;
            this.btnCargarMensaje.Text = "Mensaje";
            this.btnCargarMensaje.UseVisualStyleBackColor = true;
            this.btnCargarMensaje.Click += new System.EventHandler(this.btnCargarMensaje_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 607);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(399, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmCargarTramas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 654);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCargarMensaje);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnBorrarTablas);
            this.Controls.Add(this.dgvResumenPersonas);
            this.Controls.Add(this.dgvResumenTramas);
            this.Controls.Add(this.gboArchivo);
            this.Controls.Add(this.gboTramas);
            this.Controls.Add(this.label1);
            this.Name = "frmCargarTramas";
            this.Text = "Tramas";
            this.Load += new System.EventHandler(this.frmCargarTramas_Load);
            this.gboTramas.ResumeLayout(false);
            this.gboTramas.PerformLayout();
            this.gboArchivo.ResumeLayout(false);
            this.gboArchivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenTramas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboTramas;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.RadioButton rdbRegistrador;
        private System.Windows.Forms.RadioButton rdbPaciente;
        private System.Windows.Forms.RadioButton rdbPersonal;
        private System.Windows.Forms.RadioButton rdbTrama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboArchivo;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.DataGridView dgvResumenTramas;
        private System.Windows.Forms.DataGridView dgvResumenPersonas;
        private System.Windows.Forms.Button btnBorrarTablas;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnCargarMensaje;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}