namespace AppReporteErrores
{
    partial class frmFiltrado
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
            this.cboMicrored = new System.Windows.Forms.ComboBox();
            this.cboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.dteDesde = new System.Windows.Forms.DateTimePicker();
            this.dteHasta = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.txtDescripcionItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboMicroEstFecha = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboFiltros = new System.Windows.Forms.GroupBox();
            this.cboRandoEdades = new System.Windows.Forms.ComboBox();
            this.txtNombresPersonal = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.cboTipoEdad = new System.Windows.Forms.ComboBox();
            this.txtDNIPersonal = new System.Windows.Forms.TextBox();
            this.txtDNIPaciente = new System.Windows.Forms.TextBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorLab = new System.Windows.Forms.TextBox();
            this.cboTipoDx = new System.Windows.Forms.ComboBox();
            this.gboMicroEstFecha.SuspendLayout();
            this.gboFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMicrored
            // 
            this.cboMicrored.FormattingEnabled = true;
            this.cboMicrored.Location = new System.Drawing.Point(149, 22);
            this.cboMicrored.Name = "cboMicrored";
            this.cboMicrored.Size = new System.Drawing.Size(200, 21);
            this.cboMicrored.TabIndex = 0;
            this.cboMicrored.SelectedIndexChanged += new System.EventHandler(this.cboMicrored_SelectedIndexChanged);
            this.cboMicrored.SelectionChangeCommitted += new System.EventHandler(this.cboMicrored_SelectionChangeCommitted);
            // 
            // cboEstablecimiento
            // 
            this.cboEstablecimiento.FormattingEnabled = true;
            this.cboEstablecimiento.Location = new System.Drawing.Point(149, 64);
            this.cboEstablecimiento.Name = "cboEstablecimiento";
            this.cboEstablecimiento.Size = new System.Drawing.Size(200, 21);
            this.cboEstablecimiento.TabIndex = 1;
            // 
            // dteDesde
            // 
            this.dteDesde.Location = new System.Drawing.Point(149, 98);
            this.dteDesde.Name = "dteDesde";
            this.dteDesde.Size = new System.Drawing.Size(200, 20);
            this.dteDesde.TabIndex = 2;
            // 
            // dteHasta
            // 
            this.dteHasta.Location = new System.Drawing.Point(149, 137);
            this.dteHasta.Name = "dteHasta";
            this.dteHasta.Size = new System.Drawing.Size(200, 20);
            this.dteHasta.TabIndex = 3;
            // 
            // txtCodigoItem
            // 
            this.txtCodigoItem.Location = new System.Drawing.Point(119, 27);
            this.txtCodigoItem.Name = "txtCodigoItem";
            this.txtCodigoItem.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoItem.TabIndex = 4;
            this.txtCodigoItem.Enter += new System.EventHandler(this.txtCodigoItem_Enter);
            this.txtCodigoItem.Leave += new System.EventHandler(this.txtCodigoItem_Leave);
            // 
            // txtDescripcionItem
            // 
            this.txtDescripcionItem.Location = new System.Drawing.Point(238, 27);
            this.txtDescripcionItem.Multiline = true;
            this.txtDescripcionItem.Name = "txtDescripcionItem";
            this.txtDescripcionItem.Size = new System.Drawing.Size(279, 39);
            this.txtDescripcionItem.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CÓDIGO ITEM";
            // 
            // gboMicroEstFecha
            // 
            this.gboMicroEstFecha.Controls.Add(this.label5);
            this.gboMicroEstFecha.Controls.Add(this.label4);
            this.gboMicroEstFecha.Controls.Add(this.label3);
            this.gboMicroEstFecha.Controls.Add(this.label2);
            this.gboMicroEstFecha.Controls.Add(this.cboMicrored);
            this.gboMicroEstFecha.Controls.Add(this.cboEstablecimiento);
            this.gboMicroEstFecha.Controls.Add(this.dteDesde);
            this.gboMicroEstFecha.Controls.Add(this.dteHasta);
            this.gboMicroEstFecha.Location = new System.Drawing.Point(12, 25);
            this.gboMicroEstFecha.Name = "gboMicroEstFecha";
            this.gboMicroEstFecha.Size = new System.Drawing.Size(379, 177);
            this.gboMicroEstFecha.TabIndex = 7;
            this.gboMicroEstFecha.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "HASTA: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DESDE: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ESTABLECIMIENTO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MICRORED";
            // 
            // gboFiltros
            // 
            this.gboFiltros.Controls.Add(this.cboRandoEdades);
            this.gboFiltros.Controls.Add(this.txtNombresPersonal);
            this.gboFiltros.Controls.Add(this.cboSexo);
            this.gboFiltros.Controls.Add(this.cboTipoEdad);
            this.gboFiltros.Controls.Add(this.txtDNIPersonal);
            this.gboFiltros.Controls.Add(this.txtDNIPaciente);
            this.gboFiltros.Controls.Add(this.numEdad);
            this.gboFiltros.Controls.Add(this.label9);
            this.gboFiltros.Controls.Add(this.label13);
            this.gboFiltros.Controls.Add(this.txtApp);
            this.gboFiltros.Controls.Add(this.label14);
            this.gboFiltros.Controls.Add(this.label12);
            this.gboFiltros.Controls.Add(this.label11);
            this.gboFiltros.Controls.Add(this.label10);
            this.gboFiltros.Controls.Add(this.label8);
            this.gboFiltros.Controls.Add(this.label7);
            this.gboFiltros.Controls.Add(this.label6);
            this.gboFiltros.Controls.Add(this.txtValorLab);
            this.gboFiltros.Controls.Add(this.cboTipoDx);
            this.gboFiltros.Controls.Add(this.label1);
            this.gboFiltros.Controls.Add(this.txtCodigoItem);
            this.gboFiltros.Controls.Add(this.txtDescripcionItem);
            this.gboFiltros.Location = new System.Drawing.Point(415, 25);
            this.gboFiltros.Name = "gboFiltros";
            this.gboFiltros.Size = new System.Drawing.Size(726, 177);
            this.gboFiltros.TabIndex = 8;
            this.gboFiltros.TabStop = false;
            // 
            // cboRandoEdades
            // 
            this.cboRandoEdades.FormattingEnabled = true;
            this.cboRandoEdades.Location = new System.Drawing.Point(367, 136);
            this.cboRandoEdades.Name = "cboRandoEdades";
            this.cboRandoEdades.Size = new System.Drawing.Size(150, 21);
            this.cboRandoEdades.TabIndex = 25;
            // 
            // txtNombresPersonal
            // 
            this.txtNombresPersonal.Location = new System.Drawing.Point(238, 104);
            this.txtNombresPersonal.Name = "txtNombresPersonal";
            this.txtNombresPersonal.Size = new System.Drawing.Size(279, 20);
            this.txtNombresPersonal.TabIndex = 24;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "",
            "F",
            "M"});
            this.cboSexo.Location = new System.Drawing.Point(623, 137);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(83, 21);
            this.cboSexo.TabIndex = 23;
            // 
            // cboTipoEdad
            // 
            this.cboTipoEdad.FormattingEnabled = true;
            this.cboTipoEdad.Items.AddRange(new object[] {
            "",
            "D",
            "M",
            "A"});
            this.cboTipoEdad.Location = new System.Drawing.Point(623, 101);
            this.cboTipoEdad.Name = "cboTipoEdad";
            this.cboTipoEdad.Size = new System.Drawing.Size(83, 21);
            this.cboTipoEdad.TabIndex = 22;
            // 
            // txtDNIPersonal
            // 
            this.txtDNIPersonal.Location = new System.Drawing.Point(367, 79);
            this.txtDNIPersonal.Name = "txtDNIPersonal";
            this.txtDNIPersonal.Size = new System.Drawing.Size(150, 20);
            this.txtDNIPersonal.TabIndex = 9;
            // 
            // txtDNIPaciente
            // 
            this.txtDNIPaciente.Location = new System.Drawing.Point(119, 136);
            this.txtDNIPaciente.Name = "txtDNIPaciente";
            this.txtDNIPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtDNIPaciente.TabIndex = 21;
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(623, 60);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(83, 20);
            this.numEdad.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "DNI PACIENTE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "RANGO EDADES";
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(623, 30);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(83, 20);
            this.txtApp.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(235, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "DNI PERSONAL SALUD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(540, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "TIPO EDAD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(540, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "EDAD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(540, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "SEXO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "APP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "VALOR LAB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "TIPO DX";
            // 
            // txtValorLab
            // 
            this.txtValorLab.Location = new System.Drawing.Point(119, 97);
            this.txtValorLab.Name = "txtValorLab";
            this.txtValorLab.Size = new System.Drawing.Size(100, 20);
            this.txtValorLab.TabIndex = 8;
            // 
            // cboTipoDx
            // 
            this.cboTipoDx.FormattingEnabled = true;
            this.cboTipoDx.Items.AddRange(new object[] {
            "",
            "P",
            "D",
            "R"});
            this.cboTipoDx.Location = new System.Drawing.Point(119, 60);
            this.cboTipoDx.Name = "cboTipoDx";
            this.cboTipoDx.Size = new System.Drawing.Size(100, 21);
            this.cboTipoDx.TabIndex = 7;
            // 
            // frmFiltrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 646);
            this.Controls.Add(this.gboFiltros);
            this.Controls.Add(this.gboMicroEstFecha);
            this.Name = "frmFiltrado";
            this.Text = "frmFiltrado";
            this.gboMicroEstFecha.ResumeLayout(false);
            this.gboMicroEstFecha.PerformLayout();
            this.gboFiltros.ResumeLayout(false);
            this.gboFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMicrored;
        private System.Windows.Forms.ComboBox cboEstablecimiento;
        private System.Windows.Forms.DateTimePicker dteDesde;
        private System.Windows.Forms.DateTimePicker dteHasta;
        private System.Windows.Forms.TextBox txtCodigoItem;
        private System.Windows.Forms.TextBox txtDescripcionItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboMicroEstFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboFiltros;
        private System.Windows.Forms.ComboBox cboRandoEdades;
        private System.Windows.Forms.TextBox txtNombresPersonal;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.ComboBox cboTipoEdad;
        private System.Windows.Forms.TextBox txtDNIPersonal;
        private System.Windows.Forms.TextBox txtDNIPaciente;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtApp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorLab;
        private System.Windows.Forms.ComboBox cboTipoDx;
    }
}