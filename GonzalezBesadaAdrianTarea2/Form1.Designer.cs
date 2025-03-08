namespace GonzalezBesadaAdrianTarea2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstvwProductos = new System.Windows.Forms.ListView();
            this.btnSelectListaProductos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstvwFabricantes = new System.Windows.Forms.ListView();
            this.btnSelectListaFabricantes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstvwResultadosBusqueda = new System.Windows.Forms.ListView();
            this.txtBusquedaRB = new System.Windows.Forms.TextBox();
            this.rbFabricante = new System.Windows.Forms.RadioButton();
            this.rbProducto = new System.Windows.Forms.RadioButton();
            this.btnBuscarConRadio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarSeleccionado = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEjecutarConsulta = new System.Windows.Forms.Button();
            this.comboConsultas = new System.Windows.Forms.ComboBox();
            this.lstvwResultadoConsulta = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstvwProductos);
            this.panel1.Controls.Add(this.btnSelectListaProductos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 275);
            this.panel1.TabIndex = 0;
            // 
            // lstvwProductos
            // 
            this.lstvwProductos.HideSelection = false;
            this.lstvwProductos.Location = new System.Drawing.Point(42, 39);
            this.lstvwProductos.Name = "lstvwProductos";
            this.lstvwProductos.Size = new System.Drawing.Size(367, 154);
            this.lstvwProductos.TabIndex = 2;
            this.lstvwProductos.UseCompatibleStateImageBehavior = false;
            this.lstvwProductos.View = System.Windows.Forms.View.Details;
            // 
            // btnSelectListaProductos
            // 
            this.btnSelectListaProductos.Location = new System.Drawing.Point(179, 219);
            this.btnSelectListaProductos.Name = "btnSelectListaProductos";
            this.btnSelectListaProductos.Size = new System.Drawing.Size(135, 23);
            this.btnSelectListaProductos.TabIndex = 1;
            this.btnSelectListaProductos.Text = "Ver productos";
            this.btnSelectListaProductos.UseVisualStyleBackColor = true;
            this.btnSelectListaProductos.Click += new System.EventHandler(this.btnSelectListaProductos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio 1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstvwFabricantes);
            this.panel2.Controls.Add(this.btnSelectListaFabricantes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 275);
            this.panel2.TabIndex = 3;
            // 
            // lstvwFabricantes
            // 
            this.lstvwFabricantes.HideSelection = false;
            this.lstvwFabricantes.Location = new System.Drawing.Point(53, 39);
            this.lstvwFabricantes.Name = "lstvwFabricantes";
            this.lstvwFabricantes.Size = new System.Drawing.Size(367, 154);
            this.lstvwFabricantes.TabIndex = 3;
            this.lstvwFabricantes.UseCompatibleStateImageBehavior = false;
            this.lstvwFabricantes.View = System.Windows.Forms.View.Details;
            // 
            // btnSelectListaFabricantes
            // 
            this.btnSelectListaFabricantes.Location = new System.Drawing.Point(179, 219);
            this.btnSelectListaFabricantes.Name = "btnSelectListaFabricantes";
            this.btnSelectListaFabricantes.Size = new System.Drawing.Size(122, 23);
            this.btnSelectListaFabricantes.TabIndex = 1;
            this.btnSelectListaFabricantes.Text = "Ver fabricantes";
            this.btnSelectListaFabricantes.UseVisualStyleBackColor = true;
            this.btnSelectListaFabricantes.Click += new System.EventHandler(this.btnSelectListaFabricantes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ejercicio 2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstvwResultadosBusqueda);
            this.panel3.Controls.Add(this.txtBusquedaRB);
            this.panel3.Controls.Add(this.rbFabricante);
            this.panel3.Controls.Add(this.rbProducto);
            this.panel3.Controls.Add(this.btnBuscarConRadio);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(478, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 275);
            this.panel3.TabIndex = 4;
            // 
            // lstvwResultadosBusqueda
            // 
            this.lstvwResultadosBusqueda.HideSelection = false;
            this.lstvwResultadosBusqueda.Location = new System.Drawing.Point(49, 36);
            this.lstvwResultadosBusqueda.Name = "lstvwResultadosBusqueda";
            this.lstvwResultadosBusqueda.Size = new System.Drawing.Size(422, 157);
            this.lstvwResultadosBusqueda.TabIndex = 6;
            this.lstvwResultadosBusqueda.UseCompatibleStateImageBehavior = false;
            this.lstvwResultadosBusqueda.View = System.Windows.Forms.View.Details;
            // 
            // txtBusquedaRB
            // 
            this.txtBusquedaRB.Location = new System.Drawing.Point(192, 208);
            this.txtBusquedaRB.Name = "txtBusquedaRB";
            this.txtBusquedaRB.Size = new System.Drawing.Size(205, 22);
            this.txtBusquedaRB.TabIndex = 5;
            // 
            // rbFabricante
            // 
            this.rbFabricante.AutoSize = true;
            this.rbFabricante.Location = new System.Drawing.Point(62, 236);
            this.rbFabricante.Name = "rbFabricante";
            this.rbFabricante.Size = new System.Drawing.Size(92, 20);
            this.rbFabricante.TabIndex = 4;
            this.rbFabricante.TabStop = true;
            this.rbFabricante.Text = "Fabricante";
            this.rbFabricante.UseVisualStyleBackColor = true;
            // 
            // rbProducto
            // 
            this.rbProducto.AutoSize = true;
            this.rbProducto.Location = new System.Drawing.Point(62, 210);
            this.rbProducto.Name = "rbProducto";
            this.rbProducto.Size = new System.Drawing.Size(82, 20);
            this.rbProducto.TabIndex = 3;
            this.rbProducto.TabStop = true;
            this.rbProducto.Text = "Producto";
            this.rbProducto.UseVisualStyleBackColor = true;
            // 
            // btnBuscarConRadio
            // 
            this.btnBuscarConRadio.Location = new System.Drawing.Point(236, 236);
            this.btnBuscarConRadio.Name = "btnBuscarConRadio";
            this.btnBuscarConRadio.Size = new System.Drawing.Size(122, 23);
            this.btnBuscarConRadio.TabIndex = 1;
            this.btnBuscarConRadio.Text = "Bucar";
            this.btnBuscarConRadio.UseVisualStyleBackColor = true;
            this.btnBuscarConRadio.Click += new System.EventHandler(this.btnBuscarConRadio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ejercicio 3";
            // 
            // btnEliminarSeleccionado
            // 
            this.btnEliminarSeleccionado.Location = new System.Drawing.Point(17, 40);
            this.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            this.btnEliminarSeleccionado.Size = new System.Drawing.Size(171, 23);
            this.btnEliminarSeleccionado.TabIndex = 4;
            this.btnEliminarSeleccionado.Text = "Eliminar seleccionado";
            this.btnEliminarSeleccionado.UseVisualStyleBackColor = true;
            this.btnEliminarSeleccionado.Click += new System.EventHandler(this.btnEliminarSeleccionado_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnEliminarSeleccionado);
            this.panel4.Location = new System.Drawing.Point(146, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 78);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ejercicio 4";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lstvwResultadoConsulta);
            this.panel5.Controls.Add(this.comboConsultas);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnEjecutarConsulta);
            this.panel5.Location = new System.Drawing.Point(475, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(497, 401);
            this.panel5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ejercicio 5";
            // 
            // btnEjecutarConsulta
            // 
            this.btnEjecutarConsulta.Location = new System.Drawing.Point(161, 70);
            this.btnEjecutarConsulta.Name = "btnEjecutarConsulta";
            this.btnEjecutarConsulta.Size = new System.Drawing.Size(171, 23);
            this.btnEjecutarConsulta.TabIndex = 4;
            this.btnEjecutarConsulta.Text = "Ejecutar consulta";
            this.btnEjecutarConsulta.UseVisualStyleBackColor = true;
            this.btnEjecutarConsulta.Click += new System.EventHandler(this.btnEjecutarConsulta_Click);
            // 
            // comboConsultas
            // 
            this.comboConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboConsultas.FormattingEnabled = true;
            this.comboConsultas.Location = new System.Drawing.Point(31, 40);
            this.comboConsultas.Name = "comboConsultas";
            this.comboConsultas.Size = new System.Drawing.Size(443, 24);
            this.comboConsultas.TabIndex = 5;
            // 
            // lstvwResultadoConsulta
            // 
            this.lstvwResultadoConsulta.HideSelection = false;
            this.lstvwResultadoConsulta.Location = new System.Drawing.Point(31, 112);
            this.lstvwResultadoConsulta.Name = "lstvwResultadoConsulta";
            this.lstvwResultadoConsulta.Size = new System.Drawing.Size(443, 269);
            this.lstvwResultadoConsulta.TabIndex = 4;
            this.lstvwResultadoConsulta.UseCompatibleStateImageBehavior = false;
            this.lstvwResultadoConsulta.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 706);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectListaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelectListaFabricantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbFabricante;
        private System.Windows.Forms.RadioButton rbProducto;
        private System.Windows.Forms.Button btnBuscarConRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusquedaRB;
        private System.Windows.Forms.ListView lstvwResultadosBusqueda;
        private System.Windows.Forms.ListView lstvwProductos;
        private System.Windows.Forms.ListView lstvwFabricantes;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboConsultas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEjecutarConsulta;
        private System.Windows.Forms.ListView lstvwResultadoConsulta;
    }
}

