namespace T4_P_Dapper
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
            this.lstbxEquipos = new System.Windows.Forms.ListBox();
            this.btnBuscarEquipos = new System.Windows.Forms.Button();
            this.lstbxJugadoresEquipo = new System.Windows.Forms.ListBox();
            this.btnConsultarJugadores = new System.Windows.Forms.Button();
            this.btnInsertarEquipo = new System.Windows.Forms.Button();
            this.txtENombreEquipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtECodigoEquipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFNombre = new System.Windows.Forms.TextBox();
            this.btnInsertarJugador = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateJugador = new System.Windows.Forms.Button();
            this.btnEliminarJugador = new System.Windows.Forms.Button();
            this.comboFEquipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlJugadorDetail = new System.Windows.Forms.Panel();
            this.comboFEquipoDetail = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFNombreDetail = new System.Windows.Forms.TextBox();
            this.pnlJugadorDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxEquipos
            // 
            this.lstbxEquipos.FormattingEnabled = true;
            this.lstbxEquipos.ItemHeight = 16;
            this.lstbxEquipos.Location = new System.Drawing.Point(12, 12);
            this.lstbxEquipos.Name = "lstbxEquipos";
            this.lstbxEquipos.Size = new System.Drawing.Size(189, 196);
            this.lstbxEquipos.TabIndex = 0;
            // 
            // btnBuscarEquipos
            // 
            this.btnBuscarEquipos.Location = new System.Drawing.Point(25, 214);
            this.btnBuscarEquipos.Name = "btnBuscarEquipos";
            this.btnBuscarEquipos.Size = new System.Drawing.Size(155, 23);
            this.btnBuscarEquipos.TabIndex = 1;
            this.btnBuscarEquipos.Text = "Buscar equipos";
            this.btnBuscarEquipos.UseVisualStyleBackColor = true;
            this.btnBuscarEquipos.Click += new System.EventHandler(this.btnBuscarEquipos_Click);
            // 
            // lstbxJugadoresEquipo
            // 
            this.lstbxJugadoresEquipo.FormattingEnabled = true;
            this.lstbxJugadoresEquipo.ItemHeight = 16;
            this.lstbxJugadoresEquipo.Location = new System.Drawing.Point(231, 12);
            this.lstbxJugadoresEquipo.Name = "lstbxJugadoresEquipo";
            this.lstbxJugadoresEquipo.Size = new System.Drawing.Size(189, 196);
            this.lstbxJugadoresEquipo.TabIndex = 2;
            this.lstbxJugadoresEquipo.DoubleClick += new System.EventHandler(this.lstbxJugadoresEquipo_DoubleClick);
            // 
            // btnConsultarJugadores
            // 
            this.btnConsultarJugadores.Location = new System.Drawing.Point(249, 214);
            this.btnConsultarJugadores.Name = "btnConsultarJugadores";
            this.btnConsultarJugadores.Size = new System.Drawing.Size(155, 23);
            this.btnConsultarJugadores.TabIndex = 3;
            this.btnConsultarJugadores.Text = "Buscar jugadores";
            this.btnConsultarJugadores.UseVisualStyleBackColor = true;
            this.btnConsultarJugadores.Click += new System.EventHandler(this.btnConsultarJugadores_Click);
            // 
            // btnInsertarEquipo
            // 
            this.btnInsertarEquipo.Location = new System.Drawing.Point(444, 138);
            this.btnInsertarEquipo.Name = "btnInsertarEquipo";
            this.btnInsertarEquipo.Size = new System.Drawing.Size(155, 23);
            this.btnInsertarEquipo.TabIndex = 4;
            this.btnInsertarEquipo.Text = "Insertar equipo";
            this.btnInsertarEquipo.UseVisualStyleBackColor = true;
            this.btnInsertarEquipo.Click += new System.EventHandler(this.btnInsertarEquipo_Click);
            // 
            // txtENombreEquipo
            // 
            this.txtENombreEquipo.Location = new System.Drawing.Point(444, 110);
            this.txtENombreEquipo.Name = "txtENombreEquipo";
            this.txtENombreEquipo.Size = new System.Drawing.Size(155, 22);
            this.txtENombreEquipo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo";
            // 
            // txtECodigoEquipo
            // 
            this.txtECodigoEquipo.Location = new System.Drawing.Point(444, 59);
            this.txtECodigoEquipo.Name = "txtECodigoEquipo";
            this.txtECodigoEquipo.Size = new System.Drawing.Size(155, 22);
            this.txtECodigoEquipo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Codigo";
            // 
            // txtFCodigo
            // 
            this.txtFCodigo.Location = new System.Drawing.Point(633, 59);
            this.txtFCodigo.Name = "txtFCodigo";
            this.txtFCodigo.Size = new System.Drawing.Size(155, 22);
            this.txtFCodigo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre";
            // 
            // txtFNombre
            // 
            this.txtFNombre.Location = new System.Drawing.Point(633, 110);
            this.txtFNombre.Name = "txtFNombre";
            this.txtFNombre.Size = new System.Drawing.Size(155, 22);
            this.txtFNombre.TabIndex = 10;
            // 
            // btnInsertarJugador
            // 
            this.btnInsertarJugador.Location = new System.Drawing.Point(633, 184);
            this.btnInsertarJugador.Name = "btnInsertarJugador";
            this.btnInsertarJugador.Size = new System.Drawing.Size(155, 23);
            this.btnInsertarJugador.TabIndex = 9;
            this.btnInsertarJugador.Text = "Insertar jugador";
            this.btnInsertarJugador.UseVisualStyleBackColor = true;
            this.btnInsertarJugador.Click += new System.EventHandler(this.btnInsertarJugador_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Equipo";
            // 
            // btnUpdateJugador
            // 
            this.btnUpdateJugador.Location = new System.Drawing.Point(33, 106);
            this.btnUpdateJugador.Name = "btnUpdateJugador";
            this.btnUpdateJugador.Size = new System.Drawing.Size(155, 23);
            this.btnUpdateJugador.TabIndex = 16;
            this.btnUpdateJugador.Text = "Actualizar jugador";
            this.btnUpdateJugador.UseVisualStyleBackColor = true;
            this.btnUpdateJugador.Click += new System.EventHandler(this.btnUpdateJugador_Click);
            // 
            // btnEliminarJugador
            // 
            this.btnEliminarJugador.Location = new System.Drawing.Point(33, 135);
            this.btnEliminarJugador.Name = "btnEliminarJugador";
            this.btnEliminarJugador.Size = new System.Drawing.Size(155, 23);
            this.btnEliminarJugador.TabIndex = 17;
            this.btnEliminarJugador.Text = "Eliminar jugador";
            this.btnEliminarJugador.UseVisualStyleBackColor = true;
            this.btnEliminarJugador.Click += new System.EventHandler(this.btnEliminarJugador_Click);
            // 
            // comboFEquipo
            // 
            this.comboFEquipo.FormattingEnabled = true;
            this.comboFEquipo.Location = new System.Drawing.Point(633, 156);
            this.comboFEquipo.Name = "comboFEquipo";
            this.comboFEquipo.Size = new System.Drawing.Size(155, 24);
            this.comboFEquipo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Equipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(685, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Jugador";
            // 
            // pnlJugadorDetail
            // 
            this.pnlJugadorDetail.Controls.Add(this.comboFEquipoDetail);
            this.pnlJugadorDetail.Controls.Add(this.label8);
            this.pnlJugadorDetail.Controls.Add(this.label9);
            this.pnlJugadorDetail.Controls.Add(this.txtFNombreDetail);
            this.pnlJugadorDetail.Controls.Add(this.btnEliminarJugador);
            this.pnlJugadorDetail.Controls.Add(this.btnUpdateJugador);
            this.pnlJugadorDetail.Location = new System.Drawing.Point(216, 255);
            this.pnlJugadorDetail.Name = "pnlJugadorDetail";
            this.pnlJugadorDetail.Size = new System.Drawing.Size(224, 183);
            this.pnlJugadorDetail.TabIndex = 21;
            this.pnlJugadorDetail.Visible = false;
            // 
            // comboFEquipoDetail
            // 
            this.comboFEquipoDetail.FormattingEnabled = true;
            this.comboFEquipoDetail.Location = new System.Drawing.Point(33, 76);
            this.comboFEquipoDetail.Name = "comboFEquipoDetail";
            this.comboFEquipoDetail.Size = new System.Drawing.Size(155, 24);
            this.comboFEquipoDetail.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Equipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nombre";
            // 
            // txtFNombreDetail
            // 
            this.txtFNombreDetail.Location = new System.Drawing.Point(33, 30);
            this.txtFNombreDetail.Name = "txtFNombreDetail";
            this.txtFNombreDetail.Size = new System.Drawing.Size(155, 22);
            this.txtFNombreDetail.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlJugadorDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboFEquipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFNombre);
            this.Controls.Add(this.btnInsertarJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtECodigoEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtENombreEquipo);
            this.Controls.Add(this.btnInsertarEquipo);
            this.Controls.Add(this.btnConsultarJugadores);
            this.Controls.Add(this.lstbxJugadoresEquipo);
            this.Controls.Add(this.btnBuscarEquipos);
            this.Controls.Add(this.lstbxEquipos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlJugadorDetail.ResumeLayout(false);
            this.pnlJugadorDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxEquipos;
        private System.Windows.Forms.Button btnBuscarEquipos;
        private System.Windows.Forms.ListBox lstbxJugadoresEquipo;
        private System.Windows.Forms.Button btnConsultarJugadores;
        private System.Windows.Forms.Button btnInsertarEquipo;
        private System.Windows.Forms.TextBox txtENombreEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtECodigoEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFNombre;
        private System.Windows.Forms.Button btnInsertarJugador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateJugador;
        private System.Windows.Forms.Button btnEliminarJugador;
        private System.Windows.Forms.ComboBox comboFEquipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlJugadorDetail;
        private System.Windows.Forms.ComboBox comboFEquipoDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFNombreDetail;
    }
}

