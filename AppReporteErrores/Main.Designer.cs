namespace AppReporteErrores
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCargaCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMostrarErrores = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBarraProgreso = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemMostrarFrom = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFiltroNominal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCargaCSV,
            this.itemMostrarErrores,
            this.itemBarraProgreso,
            this.itemMostrarFrom,
            this.itemFiltroNominal});
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(53, 20);
            this.tsmMenu.Text = "MENU";
            // 
            // itemCargaCSV
            // 
            this.itemCargaCSV.Name = "itemCargaCSV";
            this.itemCargaCSV.Size = new System.Drawing.Size(186, 22);
            this.itemCargaCSV.Text = "Carga CSV";
            this.itemCargaCSV.Click += new System.EventHandler(this.itemCargaCSV_Click);
            // 
            // itemMostrarErrores
            // 
            this.itemMostrarErrores.Name = "itemMostrarErrores";
            this.itemMostrarErrores.Size = new System.Drawing.Size(186, 22);
            this.itemMostrarErrores.Text = "Mostrar Errores";
            this.itemMostrarErrores.Click += new System.EventHandler(this.itemMostrarErrores_Click);
            // 
            // itemBarraProgreso
            // 
            this.itemBarraProgreso.Name = "itemBarraProgreso";
            this.itemBarraProgreso.Size = new System.Drawing.Size(186, 22);
            this.itemBarraProgreso.Text = "Barra Progreso Demo";
            this.itemBarraProgreso.Click += new System.EventHandler(this.itemBarraProgreso_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(182, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 567);
            this.panel1.TabIndex = 1;
            // 
            // itemMostrarFrom
            // 
            this.itemMostrarFrom.Name = "itemMostrarFrom";
            this.itemMostrarFrom.Size = new System.Drawing.Size(186, 22);
            this.itemMostrarFrom.Text = "Mostrar Form";
            this.itemMostrarFrom.Click += new System.EventHandler(this.mostrarFormToolStripMenuItem_Click);
            // 
            // itemFiltroNominal
            // 
            this.itemFiltroNominal.Name = "itemFiltroNominal";
            this.itemFiltroNominal.Size = new System.Drawing.Size(186, 22);
            this.itemFiltroNominal.Text = "Filtro de Nominal";
            this.itemFiltroNominal.Click += new System.EventHandler(this.itemFiltroNominal_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "INICIO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem itemCargaCSV;
        private System.Windows.Forms.ToolStripMenuItem itemMostrarErrores;
        private System.Windows.Forms.ToolStripMenuItem itemBarraProgreso;
        private System.Windows.Forms.ToolStripMenuItem itemMostrarFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem itemFiltroNominal;
    }
}