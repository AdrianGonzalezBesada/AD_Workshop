namespace GonzalezBesadaAdrianTarea1
{
    partial class Form1
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
            this.btnGuardarEnFichero = new System.Windows.Forms.Button();
            this.txtFicheroAGuardar = new System.Windows.Forms.TextBox();
            this.txtFicheroALeer = new System.Windows.Forms.TextBox();
            this.btnLeerFichero = new System.Windows.Forms.Button();
            this.txtFicheroAModificar = new System.Windows.Forms.TextBox();
            this.btnFicheroAModificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificarFichero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopiarArchivoA = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargarEstructura = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarEnFichero
            // 
            this.btnGuardarEnFichero.Location = new System.Drawing.Point(20, 177);
            this.btnGuardarEnFichero.Name = "btnGuardarEnFichero";
            this.btnGuardarEnFichero.Size = new System.Drawing.Size(125, 23);
            this.btnGuardarEnFichero.TabIndex = 0;
            this.btnGuardarEnFichero.Text = "Guardar en fichero";
            this.btnGuardarEnFichero.UseVisualStyleBackColor = true;
            this.btnGuardarEnFichero.Click += new System.EventHandler(this.btnGuardarEnFichero_Click);
            // 
            // txtFicheroAGuardar
            // 
            this.txtFicheroAGuardar.Location = new System.Drawing.Point(3, 3);
            this.txtFicheroAGuardar.Multiline = true;
            this.txtFicheroAGuardar.Name = "txtFicheroAGuardar";
            this.txtFicheroAGuardar.Size = new System.Drawing.Size(169, 168);
            this.txtFicheroAGuardar.TabIndex = 4;
            // 
            // txtFicheroALeer
            // 
            this.txtFicheroALeer.Location = new System.Drawing.Point(178, 3);
            this.txtFicheroALeer.Multiline = true;
            this.txtFicheroALeer.Name = "txtFicheroALeer";
            this.txtFicheroALeer.Size = new System.Drawing.Size(169, 168);
            this.txtFicheroALeer.TabIndex = 6;
            // 
            // btnLeerFichero
            // 
            this.btnLeerFichero.Location = new System.Drawing.Point(199, 177);
            this.btnLeerFichero.Name = "btnLeerFichero";
            this.btnLeerFichero.Size = new System.Drawing.Size(111, 23);
            this.btnLeerFichero.TabIndex = 5;
            this.btnLeerFichero.Text = "Leer fichero";
            this.btnLeerFichero.UseVisualStyleBackColor = true;
            this.btnLeerFichero.Click += new System.EventHandler(this.btnLeerFichero_Click);
            // 
            // txtFicheroAModificar
            // 
            this.txtFicheroAModificar.Location = new System.Drawing.Point(420, 3);
            this.txtFicheroAModificar.Multiline = true;
            this.txtFicheroAModificar.Name = "txtFicheroAModificar";
            this.txtFicheroAModificar.Size = new System.Drawing.Size(169, 168);
            this.txtFicheroAModificar.TabIndex = 8;
            // 
            // btnFicheroAModificar
            // 
            this.btnFicheroAModificar.Location = new System.Drawing.Point(372, 177);
            this.btnFicheroAModificar.Name = "btnFicheroAModificar";
            this.btnFicheroAModificar.Size = new System.Drawing.Size(144, 23);
            this.btnFicheroAModificar.TabIndex = 7;
            this.btnFicheroAModificar.Text = "Fichero a modificar";
            this.btnFicheroAModificar.UseVisualStyleBackColor = true;
            this.btnFicheroAModificar.Click += new System.EventHandler(this.btnFicheroAModificar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModificarFichero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFicheroAGuardar);
            this.panel1.Controls.Add(this.btnGuardarEnFichero);
            this.panel1.Controls.Add(this.txtFicheroAModificar);
            this.panel1.Controls.Add(this.btnFicheroAModificar);
            this.panel1.Controls.Add(this.txtFicheroALeer);
            this.panel1.Controls.Add(this.btnLeerFichero);
            this.panel1.Location = new System.Drawing.Point(57, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 230);
            this.panel1.TabIndex = 9;
            // 
            // btnModificarFichero
            // 
            this.btnModificarFichero.Location = new System.Drawing.Point(522, 177);
            this.btnModificarFichero.Name = "btnModificarFichero";
            this.btnModificarFichero.Size = new System.Drawing.Size(116, 23);
            this.btnModificarFichero.TabIndex = 9;
            this.btnModificarFichero.Text = "Modificar fichero";
            this.btnModificarFichero.UseVisualStyleBackColor = true;
            this.btnModificarFichero.Click += new System.EventHandler(this.btnModificarFichero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ejercicio 1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCopiarArchivoA);
            this.panel2.Location = new System.Drawing.Point(57, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 136);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ejercicio 2";
            // 
            // btnCopiarArchivoA
            // 
            this.btnCopiarArchivoA.Location = new System.Drawing.Point(29, 56);
            this.btnCopiarArchivoA.Name = "btnCopiarArchivoA";
            this.btnCopiarArchivoA.Size = new System.Drawing.Size(152, 23);
            this.btnCopiarArchivoA.TabIndex = 0;
            this.btnCopiarArchivoA.Text = "Copiar archivo a";
            this.btnCopiarArchivoA.UseVisualStyleBackColor = true;
            this.btnCopiarArchivoA.Click += new System.EventHandler(this.btnCopiarArchivoA_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCargarEstructura);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(266, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 136);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ejercicio 3";
            // 
            // btnCargarEstructura
            // 
            this.btnCargarEstructura.Location = new System.Drawing.Point(163, 53);
            this.btnCargarEstructura.Name = "btnCargarEstructura";
            this.btnCargarEstructura.Size = new System.Drawing.Size(150, 26);
            this.btnCargarEstructura.TabIndex = 1;
            this.btnCargarEstructura.Text = "Cargar estructura";
            this.btnCargarEstructura.UseVisualStyleBackColor = true;
            this.btnCargarEstructura.Click += new System.EventHandler(this.btnCargarEstructura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 429);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarEnFichero;
        private System.Windows.Forms.TextBox txtFicheroAGuardar;
        private System.Windows.Forms.TextBox txtFicheroALeer;
        private System.Windows.Forms.Button btnLeerFichero;
        private System.Windows.Forms.TextBox txtFicheroAModificar;
        private System.Windows.Forms.Button btnFicheroAModificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarFichero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopiarArchivoA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCargarEstructura;
        private System.Windows.Forms.Label label3;
    }
}

