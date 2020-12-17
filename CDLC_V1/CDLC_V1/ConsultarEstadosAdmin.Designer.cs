namespace CDLC_V1
{
    partial class ConsultarEstadosAdmin
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
            this.txt_Estado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Todo
            // 
            this.btn_Todo.Click += new System.EventHandler(this.btn_Todo_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(351, 7);
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.Text = "Estado";
            // 
            // txt_Folio
            // 
            this.txt_Folio.Location = new System.Drawing.Point(399, 41);
            this.txt_Folio.Visible = false;
            // 
            // txt_Estado
            // 
            this.txt_Estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_Estado.FormattingEnabled = true;
            this.txt_Estado.Items.AddRange(new object[] {
            "Recepción",
            "Listo",
            "Entregado"});
            this.txt_Estado.Location = new System.Drawing.Point(423, 7);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(121, 21);
            this.txt_Estado.TabIndex = 61;
            // 
            // ConsultarEstadosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 414);
            this.Controls.Add(this.txt_Estado);
            this.Name = "ConsultarEstadosAdmin";
            this.Text = "ConsultarEstados";
            this.Load += new System.EventHandler(this.ConsultarEstados_Load);
            this.Controls.SetChildIndex(this.btn_Salir, 0);
            this.Controls.SetChildIndex(this.txt_Folio, 0);
            this.Controls.SetChildIndex(this.btn_Buscar, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btn_Todo, 0);
            this.Controls.SetChildIndex(this.txt_Estado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_Estado;
    }
}