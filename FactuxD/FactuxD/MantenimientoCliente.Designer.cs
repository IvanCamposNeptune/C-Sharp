namespace FactuxD
{
    partial class MantenimientoCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdCli = new FactuxD.ErrorTxtBox();
            this.txt_NomCli = new FactuxD.ErrorTxtBox();
            this.txt_ApeCli = new FactuxD.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id_Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Apellido:";
            // 
            // txt_IdCli
            // 
            this.txt_IdCli.Location = new System.Drawing.Point(182, 41);
            this.txt_IdCli.Name = "txt_IdCli";
            this.txt_IdCli.Size = new System.Drawing.Size(100, 20);
            this.txt_IdCli.SoloNumeros = true;
            this.txt_IdCli.TabIndex = 20;
            this.txt_IdCli.Validar = true;
            this.txt_IdCli.TextChanged += new System.EventHandler(this.txt_IdCli_TextChanged);
            // 
            // txt_NomCli
            // 
            this.txt_NomCli.Location = new System.Drawing.Point(182, 97);
            this.txt_NomCli.Name = "txt_NomCli";
            this.txt_NomCli.Size = new System.Drawing.Size(100, 20);
            this.txt_NomCli.SoloNumeros = false;
            this.txt_NomCli.TabIndex = 21;
            this.txt_NomCli.Validar = true;
            // 
            // txt_ApeCli
            // 
            this.txt_ApeCli.Location = new System.Drawing.Point(182, 153);
            this.txt_ApeCli.Name = "txt_ApeCli";
            this.txt_ApeCli.Size = new System.Drawing.Size(100, 20);
            this.txt_ApeCli.SoloNumeros = false;
            this.txt_ApeCli.TabIndex = 22;
            this.txt_ApeCli.Validar = true;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txt_ApeCli);
            this.Controls.Add(this.txt_NomCli);
            this.Controls.Add(this.txt_IdCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoCliente";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.btn_Salir, 0);
            this.Controls.SetChildIndex(this.txt_IdCli, 0);
            this.Controls.SetChildIndex(this.txt_NomCli, 0);
            this.Controls.SetChildIndex(this.txt_ApeCli, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ErrorTxtBox txt_IdCli;
        private ErrorTxtBox txt_NomCli;
        private ErrorTxtBox txt_ApeCli;
    }
}