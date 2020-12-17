namespace FactuxD
{
    partial class MantenimientoProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdPro = new FactuxD.ErrorTxtBox();
            this.txt_Nom_Pro = new FactuxD.ErrorTxtBox();
            this.txt_Precio = new FactuxD.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id_Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción:";
            // 
            // txt_IdPro
            // 
            this.txt_IdPro.Location = new System.Drawing.Point(168, 46);
            this.txt_IdPro.Name = "txt_IdPro";
            this.txt_IdPro.Size = new System.Drawing.Size(100, 20);
            this.txt_IdPro.SoloNumeros = true;
            this.txt_IdPro.TabIndex = 11;
            this.txt_IdPro.Validar = true;
            this.txt_IdPro.TextChanged += new System.EventHandler(this.txt_IdPro_TextChanged);
            // 
            // txt_Nom_Pro
            // 
            this.txt_Nom_Pro.Location = new System.Drawing.Point(168, 97);
            this.txt_Nom_Pro.Name = "txt_Nom_Pro";
            this.txt_Nom_Pro.Size = new System.Drawing.Size(100, 20);
            this.txt_Nom_Pro.SoloNumeros = false;
            this.txt_Nom_Pro.TabIndex = 12;
            this.txt_Nom_Pro.Validar = true;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(168, 158);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.SoloNumeros = false;
            this.txt_Precio.TabIndex = 13;
            this.txt_Precio.Validar = true;
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Nom_Pro);
            this.Controls.Add(this.txt_IdPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoProductos";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.btn_Salir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_IdPro, 0);
            this.Controls.SetChildIndex(this.txt_Nom_Pro, 0);
            this.Controls.SetChildIndex(this.txt_Precio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ErrorTxtBox txt_IdPro;
        private ErrorTxtBox txt_Nom_Pro;
        private ErrorTxtBox txt_Precio;
    }
}