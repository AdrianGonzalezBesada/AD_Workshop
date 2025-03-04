namespace T1_P_Ficheros_Forms
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
            this.txtInsertarTexto = new System.Windows.Forms.TextBox();
            this.btnInerstarTexto = new System.Windows.Forms.Button();
            this.btnMostrarTexto = new System.Windows.Forms.Button();
            this.txtMostrarTexto = new System.Windows.Forms.TextBox();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreAlumnoCompleto = new System.Windows.Forms.TextBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.txtDirecotorioAComprobar = new System.Windows.Forms.TextBox();
            this.btnComprobarDirectorio = new System.Windows.Forms.Button();
            this.btnMoverDirectorio = new System.Windows.Forms.Button();
            this.txtMoverDirectorio = new System.Windows.Forms.TextBox();
            this.btnMostrarArchivos = new System.Windows.Forms.Button();
            this.txtArchivosEnDirectorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInsertarTexto
            // 
            this.txtInsertarTexto.Location = new System.Drawing.Point(3, 28);
            this.txtInsertarTexto.Name = "txtInsertarTexto";
            this.txtInsertarTexto.Size = new System.Drawing.Size(219, 22);
            this.txtInsertarTexto.TabIndex = 0;
            // 
            // btnInerstarTexto
            // 
            this.btnInerstarTexto.Location = new System.Drawing.Point(41, 65);
            this.btnInerstarTexto.Name = "btnInerstarTexto";
            this.btnInerstarTexto.Size = new System.Drawing.Size(139, 23);
            this.btnInerstarTexto.TabIndex = 1;
            this.btnInerstarTexto.Text = "Insertar texto";
            this.btnInerstarTexto.UseVisualStyleBackColor = true;
            this.btnInerstarTexto.Click += new System.EventHandler(this.btnInerstarTexto_Click);
            // 
            // btnMostrarTexto
            // 
            this.btnMostrarTexto.Location = new System.Drawing.Point(285, 146);
            this.btnMostrarTexto.Name = "btnMostrarTexto";
            this.btnMostrarTexto.Size = new System.Drawing.Size(104, 23);
            this.btnMostrarTexto.TabIndex = 2;
            this.btnMostrarTexto.Text = "Mostrar texto";
            this.btnMostrarTexto.UseVisualStyleBackColor = true;
            this.btnMostrarTexto.Click += new System.EventHandler(this.btnMostrarTexto_Click);
            // 
            // txtMostrarTexto
            // 
            this.txtMostrarTexto.Location = new System.Drawing.Point(238, 4);
            this.txtMostrarTexto.Multiline = true;
            this.txtMostrarTexto.Name = "txtMostrarTexto";
            this.txtMostrarTexto.ReadOnly = true;
            this.txtMostrarTexto.Size = new System.Drawing.Size(196, 121);
            this.txtMostrarTexto.TabIndex = 3;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(457, 56);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(172, 32);
            this.btnSeleccionarArchivo.TabIndex = 4;
            this.btnSeleccionarArchivo.Text = "Seleccionar archivo";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(28, 43);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(139, 22);
            this.txtNombreAlumno.TabIndex = 5;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(187, 43);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(156, 22);
            this.txtApellidoAlumno.TabIndex = 6;
            // 
            // txtNombreAlumnoCompleto
            // 
            this.txtNombreAlumnoCompleto.Location = new System.Drawing.Point(373, 43);
            this.txtNombreAlumnoCompleto.Name = "txtNombreAlumnoCompleto";
            this.txtNombreAlumnoCompleto.ReadOnly = true;
            this.txtNombreAlumnoCompleto.Size = new System.Drawing.Size(195, 22);
            this.txtNombreAlumnoCompleto.TabIndex = 7;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(610, 27);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(109, 54);
            this.btnAgregarAlumno.TabIndex = 8;
            this.btnAgregarAlumno.Text = "Agregar alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // txtDirecotorioAComprobar
            // 
            this.txtDirecotorioAComprobar.Location = new System.Drawing.Point(19, 135);
            this.txtDirecotorioAComprobar.Name = "txtDirecotorioAComprobar";
            this.txtDirecotorioAComprobar.Size = new System.Drawing.Size(177, 22);
            this.txtDirecotorioAComprobar.TabIndex = 9;
            // 
            // btnComprobarDirectorio
            // 
            this.btnComprobarDirectorio.Location = new System.Drawing.Point(19, 106);
            this.btnComprobarDirectorio.Name = "btnComprobarDirectorio";
            this.btnComprobarDirectorio.Size = new System.Drawing.Size(177, 23);
            this.btnComprobarDirectorio.TabIndex = 10;
            this.btnComprobarDirectorio.Text = "Comprobar directorio";
            this.btnComprobarDirectorio.UseVisualStyleBackColor = true;
            this.btnComprobarDirectorio.Click += new System.EventHandler(this.btnComprobarDirectorio_Click);
            // 
            // btnMoverDirectorio
            // 
            this.btnMoverDirectorio.Location = new System.Drawing.Point(223, 106);
            this.btnMoverDirectorio.Name = "btnMoverDirectorio";
            this.btnMoverDirectorio.Size = new System.Drawing.Size(177, 23);
            this.btnMoverDirectorio.TabIndex = 12;
            this.btnMoverDirectorio.Text = "Mover a";
            this.btnMoverDirectorio.UseVisualStyleBackColor = true;
            this.btnMoverDirectorio.Click += new System.EventHandler(this.btnMoverDirectorio_Click);
            // 
            // txtMoverDirectorio
            // 
            this.txtMoverDirectorio.Location = new System.Drawing.Point(223, 135);
            this.txtMoverDirectorio.Name = "txtMoverDirectorio";
            this.txtMoverDirectorio.Size = new System.Drawing.Size(177, 22);
            this.txtMoverDirectorio.TabIndex = 11;
            // 
            // btnMostrarArchivos
            // 
            this.btnMostrarArchivos.Location = new System.Drawing.Point(544, 183);
            this.btnMostrarArchivos.Name = "btnMostrarArchivos";
            this.btnMostrarArchivos.Size = new System.Drawing.Size(123, 23);
            this.btnMostrarArchivos.TabIndex = 14;
            this.btnMostrarArchivos.Text = "Mostrar Archivos";
            this.btnMostrarArchivos.UseVisualStyleBackColor = true;
            this.btnMostrarArchivos.Click += new System.EventHandler(this.btnMostrarArchivos_Click);
            // 
            // txtArchivosEnDirectorio
            // 
            this.txtArchivosEnDirectorio.Location = new System.Drawing.Point(471, 44);
            this.txtArchivosEnDirectorio.Multiline = true;
            this.txtArchivosEnDirectorio.Name = "txtArchivosEnDirectorio";
            this.txtArchivosEnDirectorio.Size = new System.Drawing.Size(261, 133);
            this.txtArchivosEnDirectorio.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Escribir en archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Leer archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Archivos del directorio dado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nombre compelto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Carear archivo en la ruta dada, y moverlo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInsertarTexto);
            this.panel1.Controls.Add(this.btnInerstarTexto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMostrarTexto);
            this.panel1.Controls.Add(this.btnMostrarTexto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSeleccionarArchivo);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 181);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregarAlumno);
            this.panel2.Controls.Add(this.txtNombreAlumno);
            this.panel2.Controls.Add(this.txtApellidoAlumno);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNombreAlumnoCompleto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 100);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtArchivosEnDirectorio);
            this.panel3.Controls.Add(this.txtDirecotorioAComprobar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnComprobarDirectorio);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtMoverDirectorio);
            this.panel3.Controls.Add(this.btnMoverDirectorio);
            this.panel3.Controls.Add(this.btnMostrarArchivos);
            this.panel3.Location = new System.Drawing.Point(12, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(763, 238);
            this.panel3.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 596);
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

        private System.Windows.Forms.TextBox txtInsertarTexto;
        private System.Windows.Forms.Button btnInerstarTexto;
        private System.Windows.Forms.Button btnMostrarTexto;
        private System.Windows.Forms.TextBox txtMostrarTexto;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumnoCompleto;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.TextBox txtDirecotorioAComprobar;
        private System.Windows.Forms.Button btnComprobarDirectorio;
        private System.Windows.Forms.Button btnMoverDirectorio;
        private System.Windows.Forms.TextBox txtMoverDirectorio;
        private System.Windows.Forms.Button btnMostrarArchivos;
        private System.Windows.Forms.TextBox txtArchivosEnDirectorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

