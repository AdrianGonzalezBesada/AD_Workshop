namespace T3_P_SQL_Server
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
            this.btnBDConnection = new System.Windows.Forms.Button();
            this.btnBDDisconnection = new System.Windows.Forms.Button();
            this.txtFabricanteCodigo = new System.Windows.Forms.TextBox();
            this.txtFabricanteNombre = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.textResultadoConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnConsultarConDataAdapter = new System.Windows.Forms.Button();
            this.ListBoxFabricantes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBDConnection
            // 
            this.btnBDConnection.Location = new System.Drawing.Point(169, 415);
            this.btnBDConnection.Name = "btnBDConnection";
            this.btnBDConnection.Size = new System.Drawing.Size(211, 23);
            this.btnBDConnection.TabIndex = 0;
            this.btnBDConnection.Text = "Conectar con la BD";
            this.btnBDConnection.UseVisualStyleBackColor = true;
            this.btnBDConnection.Click += new System.EventHandler(this.btnBDConnection_Click);
            // 
            // btnBDDisconnection
            // 
            this.btnBDDisconnection.Location = new System.Drawing.Point(418, 415);
            this.btnBDDisconnection.Name = "btnBDDisconnection";
            this.btnBDDisconnection.Size = new System.Drawing.Size(211, 23);
            this.btnBDDisconnection.TabIndex = 1;
            this.btnBDDisconnection.Text = "Desconectar la BD";
            this.btnBDDisconnection.UseVisualStyleBackColor = true;
            this.btnBDDisconnection.Click += new System.EventHandler(this.btnBDDisconnection_Click);
            // 
            // txtFabricanteCodigo
            // 
            this.txtFabricanteCodigo.Location = new System.Drawing.Point(36, 41);
            this.txtFabricanteCodigo.Name = "txtFabricanteCodigo";
            this.txtFabricanteCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtFabricanteCodigo.TabIndex = 2;
            // 
            // txtFabricanteNombre
            // 
            this.txtFabricanteNombre.Location = new System.Drawing.Point(201, 41);
            this.txtFabricanteNombre.Name = "txtFabricanteNombre";
            this.txtFabricanteNombre.Size = new System.Drawing.Size(100, 22);
            this.txtFabricanteNombre.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(21, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(135, 16);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Código del fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del Fabricante";
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.Location = new System.Drawing.Point(129, 69);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarRegistros.TabIndex = 6;
            this.btnInsertarRegistros.Text = "Insertar";
            this.btnInsertarRegistros.UseVisualStyleBackColor = true;
            this.btnInsertarRegistros.Click += new System.EventHandler(this.btnInsertarRegistros_Click);
            // 
            // textResultadoConsulta
            // 
            this.textResultadoConsulta.Location = new System.Drawing.Point(447, 22);
            this.textResultadoConsulta.Multiline = true;
            this.textResultadoConsulta.Name = "textResultadoConsulta";
            this.textResultadoConsulta.ReadOnly = true;
            this.textResultadoConsulta.Size = new System.Drawing.Size(279, 213);
            this.textResultadoConsulta.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(554, 241);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnConsultarConDataAdapter
            // 
            this.btnConsultarConDataAdapter.Location = new System.Drawing.Point(85, 318);
            this.btnConsultarConDataAdapter.Name = "btnConsultarConDataAdapter";
            this.btnConsultarConDataAdapter.Size = new System.Drawing.Size(107, 23);
            this.btnConsultarConDataAdapter.TabIndex = 9;
            this.btnConsultarConDataAdapter.Text = "DataAdapter";
            this.btnConsultarConDataAdapter.UseVisualStyleBackColor = true;
            this.btnConsultarConDataAdapter.Click += new System.EventHandler(this.btnConsultarConDataAdapter_Click);
            // 
            // ListBoxFabricantes
            // 
            this.ListBoxFabricantes.FormattingEnabled = true;
            this.ListBoxFabricantes.ItemHeight = 16;
            this.ListBoxFabricantes.Location = new System.Drawing.Point(24, 180);
            this.ListBoxFabricantes.Name = "ListBoxFabricantes";
            this.ListBoxFabricantes.Size = new System.Drawing.Size(231, 132);
            this.ListBoxFabricantes.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxFabricantes);
            this.Controls.Add(this.btnConsultarConDataAdapter);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.textResultadoConsulta);
            this.Controls.Add(this.btnInsertarRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtFabricanteNombre);
            this.Controls.Add(this.txtFabricanteCodigo);
            this.Controls.Add(this.btnBDDisconnection);
            this.Controls.Add(this.btnBDConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBDConnection;
        private System.Windows.Forms.Button btnBDDisconnection;
        private System.Windows.Forms.TextBox txtFabricanteCodigo;
        private System.Windows.Forms.TextBox txtFabricanteNombre;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.TextBox textResultadoConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConsultarConDataAdapter;
        private System.Windows.Forms.ListBox ListBoxFabricantes;
    }
}

