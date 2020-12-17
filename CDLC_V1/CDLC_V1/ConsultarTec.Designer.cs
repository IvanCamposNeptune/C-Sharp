namespace CDLC_V1
{
    partial class ConsultarTec
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
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Todo
            // 
            this.btn_Todo.TabIndex = 2;
            this.btn_Todo.Click += new System.EventHandler(this.btn_Todo_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.TabIndex = 5;
            // 
            // ConsultarTec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 402);
            this.Name = "ConsultarTec";
            this.Text = "ConsultarTec";
            this.Load += new System.EventHandler(this.ConsultarTec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}