namespace CDLC_V1
{
    partial class ContenedorAdmin
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstadosTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.volverToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem1,
            this.consultarEstadosToolStripMenuItem,
            this.tecnicoToolStripMenuItem,
            this.consultarEstadosTécnicoToolStripMenuItem,
            this.reporteTecnicoToolStripMenuItem,
            this.notaDeContactoToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // administradorToolStripMenuItem1
            // 
            this.administradorToolStripMenuItem1.Name = "administradorToolStripMenuItem1";
            this.administradorToolStripMenuItem1.Size = new System.Drawing.Size(247, 22);
            this.administradorToolStripMenuItem1.Text = "Administrador";
            this.administradorToolStripMenuItem1.Click += new System.EventHandler(this.administradorToolStripMenuItem1_Click);
            // 
            // consultarEstadosToolStripMenuItem
            // 
            this.consultarEstadosToolStripMenuItem.Name = "consultarEstadosToolStripMenuItem";
            this.consultarEstadosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consultarEstadosToolStripMenuItem.Text = "Consultar Estados Administrador";
            this.consultarEstadosToolStripMenuItem.Click += new System.EventHandler(this.consultarEstadosToolStripMenuItem_Click);
            // 
            // tecnicoToolStripMenuItem
            // 
            this.tecnicoToolStripMenuItem.Name = "tecnicoToolStripMenuItem";
            this.tecnicoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.tecnicoToolStripMenuItem.Text = "Tecnico";
            this.tecnicoToolStripMenuItem.Click += new System.EventHandler(this.tecnicoToolStripMenuItem_Click);
            // 
            // reporteTecnicoToolStripMenuItem
            // 
            this.reporteTecnicoToolStripMenuItem.Name = "reporteTecnicoToolStripMenuItem";
            this.reporteTecnicoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.reporteTecnicoToolStripMenuItem.Text = "Reporte Tecnico";
            this.reporteTecnicoToolStripMenuItem.Click += new System.EventHandler(this.reporteTecnicoToolStripMenuItem_Click);
            // 
            // notaDeContactoToolStripMenuItem
            // 
            this.notaDeContactoToolStripMenuItem.Name = "notaDeContactoToolStripMenuItem";
            this.notaDeContactoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.notaDeContactoToolStripMenuItem.Text = "Notas de Contacto Tecnicos";
            this.notaDeContactoToolStripMenuItem.Click += new System.EventHandler(this.notaDeContactoToolStripMenuItem_Click);
            // 
            // consultarEstadosTécnicoToolStripMenuItem
            // 
            this.consultarEstadosTécnicoToolStripMenuItem.Name = "consultarEstadosTécnicoToolStripMenuItem";
            this.consultarEstadosTécnicoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consultarEstadosTécnicoToolStripMenuItem.Text = "Consultar Estados Técnico";
            this.consultarEstadosTécnicoToolStripMenuItem.Click += new System.EventHandler(this.consultarEstadosTécnicoToolStripMenuItem_Click);
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 639);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // ContenedorAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "ContenedorAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContenedorAdmin_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteTecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaDeContactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstadosTécnicoToolStripMenuItem;
    }
}



