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
            this.SuspendLayout();
            // 
            // txtInsertarTexto
            // 
            this.txtInsertarTexto.Location = new System.Drawing.Point(12, 12);
            this.txtInsertarTexto.Name = "txtInsertarTexto";
            this.txtInsertarTexto.Size = new System.Drawing.Size(219, 22);
            this.txtInsertarTexto.TabIndex = 0;
            // 
            // btnInerstarTexto
            // 
            this.btnInerstarTexto.Location = new System.Drawing.Point(56, 67);
            this.btnInerstarTexto.Name = "btnInerstarTexto";
            this.btnInerstarTexto.Size = new System.Drawing.Size(139, 23);
            this.btnInerstarTexto.TabIndex = 1;
            this.btnInerstarTexto.Text = "Insertar texto";
            this.btnInerstarTexto.UseVisualStyleBackColor = true;
            this.btnInerstarTexto.Click += new System.EventHandler(this.btnInerstarTexto_Click);
            // 
            // btnMostrarTexto
            // 
            this.btnMostrarTexto.Location = new System.Drawing.Point(315, 154);
            this.btnMostrarTexto.Name = "btnMostrarTexto";
            this.btnMostrarTexto.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarTexto.TabIndex = 2;
            this.btnMostrarTexto.Text = "Mostrar texto";
            this.btnMostrarTexto.UseVisualStyleBackColor = true;
            this.btnMostrarTexto.Click += new System.EventHandler(this.btnMostrarTexto_Click);
            // 
            // txtMostrarTexto
            // 
            this.txtMostrarTexto.Location = new System.Drawing.Point(251, 12);
            this.txtMostrarTexto.Multiline = true;
            this.txtMostrarTexto.Name = "txtMostrarTexto";
            this.txtMostrarTexto.ReadOnly = true;
            this.txtMostrarTexto.Size = new System.Drawing.Size(196, 121);
            this.txtMostrarTexto.TabIndex = 3;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(494, 58);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(172, 32);
            this.btnSeleccionarArchivo.TabIndex = 4;
            this.btnSeleccionarArchivo.Text = "Seleccionar archivo";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(15, 193);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(139, 22);
            this.txtNombreAlumno.TabIndex = 5;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(174, 193);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(156, 22);
            this.txtApellidoAlumno.TabIndex = 6;
            // 
            // txtNombreAlumnoCompleto
            // 
            this.txtNombreAlumnoCompleto.Location = new System.Drawing.Point(360, 193);
            this.txtNombreAlumnoCompleto.Name = "txtNombreAlumnoCompleto";
            this.txtNombreAlumnoCompleto.ReadOnly = true;
            this.txtNombreAlumnoCompleto.Size = new System.Drawing.Size(195, 22);
            this.txtNombreAlumnoCompleto.TabIndex = 7;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(597, 177);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(109, 54);
            this.btnAgregarAlumno.TabIndex = 8;
            this.btnAgregarAlumno.Text = "Agregar alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // txtDirecotorioAComprobar
            // 
            this.txtDirecotorioAComprobar.Location = new System.Drawing.Point(18, 353);
            this.txtDirecotorioAComprobar.Name = "txtDirecotorioAComprobar";
            this.txtDirecotorioAComprobar.Size = new System.Drawing.Size(177, 22);
            this.txtDirecotorioAComprobar.TabIndex = 9;
            // 
            // btnComprobarDirectorio
            // 
            this.btnComprobarDirectorio.Location = new System.Drawing.Point(18, 324);
            this.btnComprobarDirectorio.Name = "btnComprobarDirectorio";
            this.btnComprobarDirectorio.Size = new System.Drawing.Size(177, 23);
            this.btnComprobarDirectorio.TabIndex = 10;
            this.btnComprobarDirectorio.Text = "Comprobar directorio";
            this.btnComprobarDirectorio.UseVisualStyleBackColor = true;
            this.btnComprobarDirectorio.Click += new System.EventHandler(this.btnComprobarDirectorio_Click);
            // 
            // btnMoverDirectorio
            // 
            this.btnMoverDirectorio.Location = new System.Drawing.Point(222, 324);
            this.btnMoverDirectorio.Name = "btnMoverDirectorio";
            this.btnMoverDirectorio.Size = new System.Drawing.Size(177, 23);
            this.btnMoverDirectorio.TabIndex = 12;
            this.btnMoverDirectorio.Text = "Mover a";
            this.btnMoverDirectorio.UseVisualStyleBackColor = true;
            this.btnMoverDirectorio.Click += new System.EventHandler(this.btnMoverDirectorio_Click);
            // 
            // txtMoverDirectorio
            // 
            this.txtMoverDirectorio.Location = new System.Drawing.Point(222, 353);
            this.txtMoverDirectorio.Name = "txtMoverDirectorio";
            this.txtMoverDirectorio.Size = new System.Drawing.Size(177, 22);
            this.txtMoverDirectorio.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoverDirectorio);
            this.Controls.Add(this.txtMoverDirectorio);
            this.Controls.Add(this.btnComprobarDirectorio);
            this.Controls.Add(this.txtDirecotorioAComprobar);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.txtNombreAlumnoCompleto);
            this.Controls.Add(this.txtApellidoAlumno);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.txtMostrarTexto);
            this.Controls.Add(this.btnMostrarTexto);
            this.Controls.Add(this.btnInerstarTexto);
            this.Controls.Add(this.txtInsertarTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

