namespace CDLC_V1
{
    partial class MantenimientoTec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoTec));
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_IdUsu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.btn_Contacto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Folio = new CDLC_V1.ErrorTxtBox();
            this.txt_Presupuesto = new CDLC_V1.ErrorTxtBox();
            this.txt_Servicio = new CDLC_V1.ErrorTxtBox();
            this.txt_Reporte = new CDLC_V1.ErrorTxtBox();
            this.txt_Contacto = new CDLC_V1.ErrorTxtBox();
            this.btn_Estado = new System.Windows.Forms.Button();
            this.txt_Estado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(663, 196);
            this.btn_Nuevo.Size = new System.Drawing.Size(100, 41);
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(548, 196);
            this.btn_Eliminar.Size = new System.Drawing.Size(100, 41);
            this.btn_Eliminar.TabIndex = 7;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(548, 139);
            this.btn_Guardar.Size = new System.Drawing.Size(213, 41);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar o Modificar";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(663, 408);
            this.btn_Salir.Size = new System.Drawing.Size(109, 41);
            this.btn_Salir.TabIndex = 13;
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Usuario.Location = new System.Drawing.Point(13, 9);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(87, 25);
            this.label_Usuario.TabIndex = 7;
            this.label_Usuario.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reporte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nota De Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nota De Contacto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Servicio A Realizar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Presupuesto";
            // 
            // lbl_IdUsu
            // 
            this.lbl_IdUsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_IdUsu.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdUsu.Location = new System.Drawing.Point(106, 11);
            this.lbl_IdUsu.Name = "lbl_IdUsu";
            this.lbl_IdUsu.Size = new System.Drawing.Size(100, 23);
            this.lbl_IdUsu.TabIndex = 59;
            this.lbl_IdUsu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 21);
            this.label6.TabIndex = 61;
            this.label6.Text = "Opciones Tecnico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 62;
            this.label7.Text = "Folio";
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reporte.Location = new System.Drawing.Point(685, 296);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(76, 24);
            this.btn_Reporte.TabIndex = 9;
            this.btn_Reporte.Text = "Agregar";
            this.btn_Reporte.UseVisualStyleBackColor = true;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // btn_Contacto
            // 
            this.btn_Contacto.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contacto.Location = new System.Drawing.Point(685, 340);
            this.btn_Contacto.Name = "btn_Contacto";
            this.btn_Contacto.Size = new System.Drawing.Size(76, 24);
            this.btn_Contacto.TabIndex = 11;
            this.btn_Contacto.Text = "Agregar";
            this.btn_Contacto.UseVisualStyleBackColor = true;
            this.btn_Contacto.Click += new System.EventHandler(this.btn_Contacto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 66;
            this.label8.Text = "Estado";
            // 
            // txt_Folio
            // 
            this.txt_Folio.Location = new System.Drawing.Point(83, 69);
            this.txt_Folio.Name = "txt_Folio";
            this.txt_Folio.Size = new System.Drawing.Size(100, 20);
            this.txt_Folio.SoloNumeros = true;
            this.txt_Folio.TabIndex = 0;
            this.txt_Folio.Validar = true;
            this.txt_Folio.TextChanged += new System.EventHandler(this.txt_Folio_TextChanged);
            // 
            // txt_Presupuesto
            // 
            this.txt_Presupuesto.Location = new System.Drawing.Point(140, 174);
            this.txt_Presupuesto.Name = "txt_Presupuesto";
            this.txt_Presupuesto.Size = new System.Drawing.Size(153, 20);
            this.txt_Presupuesto.SoloNumeros = true;
            this.txt_Presupuesto.TabIndex = 2;
            this.txt_Presupuesto.Validar = true;
            this.txt_Presupuesto.TextChanged += new System.EventHandler(this.txt_Presupuesto_TextChanged);
            // 
            // txt_Servicio
            // 
            this.txt_Servicio.Location = new System.Drawing.Point(193, 139);
            this.txt_Servicio.Name = "txt_Servicio";
            this.txt_Servicio.Size = new System.Drawing.Size(100, 20);
            this.txt_Servicio.SoloNumeros = false;
            this.txt_Servicio.TabIndex = 1;
            this.txt_Servicio.Validar = true;
            this.txt_Servicio.TextChanged += new System.EventHandler(this.txt_Servicio_TextChanged);
            // 
            // txt_Reporte
            // 
            this.txt_Reporte.Location = new System.Drawing.Point(193, 300);
            this.txt_Reporte.Name = "txt_Reporte";
            this.txt_Reporte.Size = new System.Drawing.Size(403, 20);
            this.txt_Reporte.SoloNumeros = false;
            this.txt_Reporte.TabIndex = 8;
            this.txt_Reporte.Validar = false;
            // 
            // txt_Contacto
            // 
            this.txt_Contacto.Location = new System.Drawing.Point(193, 344);
            this.txt_Contacto.Name = "txt_Contacto";
            this.txt_Contacto.Size = new System.Drawing.Size(403, 20);
            this.txt_Contacto.SoloNumeros = false;
            this.txt_Contacto.TabIndex = 10;
            this.txt_Contacto.Validar = false;
            // 
            // btn_Estado
            // 
            this.btn_Estado.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Estado.Location = new System.Drawing.Point(319, 212);
            this.btn_Estado.Name = "btn_Estado";
            this.btn_Estado.Size = new System.Drawing.Size(120, 24);
            this.btn_Estado.TabIndex = 12;
            this.btn_Estado.Text = "Cambiar Estado";
            this.btn_Estado.UseVisualStyleBackColor = true;
            this.btn_Estado.Click += new System.EventHandler(this.btn_Estado_Click);
            // 
            // txt_Estado
            // 
            this.txt_Estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_Estado.FormattingEnabled = true;
            this.txt_Estado.Items.AddRange(new object[] {
            "En espera de refacciones",
            "Listo"});
            this.txt_Estado.Location = new System.Drawing.Point(106, 215);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(187, 21);
            this.txt_Estado.TabIndex = 3;
            // 
            // MantenimientoTec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.btn_Estado);
            this.Controls.Add(this.txt_Contacto);
            this.Controls.Add(this.txt_Reporte);
            this.Controls.Add(this.txt_Servicio);
            this.Controls.Add(this.txt_Presupuesto);
            this.Controls.Add(this.txt_Folio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Contacto);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_IdUsu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MantenimientoTec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tecnico";
            this.Load += new System.EventHandler(this.Tecnico_Load);
            this.Controls.SetChildIndex(this.label_Usuario, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lbl_IdUsu, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btn_Reporte, 0);
            this.Controls.SetChildIndex(this.btn_Contacto, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txt_Folio, 0);
            this.Controls.SetChildIndex(this.txt_Presupuesto, 0);
            this.Controls.SetChildIndex(this.txt_Servicio, 0);
            this.Controls.SetChildIndex(this.txt_Reporte, 0);
            this.Controls.SetChildIndex(this.txt_Contacto, 0);
            this.Controls.SetChildIndex(this.btn_Salir, 0);
            this.Controls.SetChildIndex(this.btn_Nuevo, 0);
            this.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.Controls.SetChildIndex(this.btn_Guardar, 0);
            this.Controls.SetChildIndex(this.btn_Estado, 0);
            this.Controls.SetChildIndex(this.txt_Estado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_IdUsu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.Button btn_Contacto;
        private System.Windows.Forms.Label label8;
        private ErrorTxtBox txt_Folio;
        private ErrorTxtBox txt_Presupuesto;
        private ErrorTxtBox txt_Servicio;
        private ErrorTxtBox txt_Reporte;
        private ErrorTxtBox txt_Contacto;
        private System.Windows.Forms.Button btn_Estado;
        private System.Windows.Forms.ComboBox txt_Estado;
    }
}