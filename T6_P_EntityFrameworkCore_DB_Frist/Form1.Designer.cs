namespace T6_P_EntityFrameworkCore_DB_Frist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbPrecio = new TextBox();
            label3 = new Label();
            tbStock = new TextBox();
            btnGuardarProducto = new Button();
            dgvProductos = new DataGridView();
            btnVisualizarProductos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(173, 62);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(146, 27);
            tbNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 65);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 115);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Precio";
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(173, 112);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(146, 27);
            tbPrecio.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 161);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Stock";
            // 
            // tbStock
            // 
            tbStock.Location = new Point(173, 158);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(146, 27);
            tbStock.TabIndex = 4;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(201, 191);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(94, 29);
            btnGuardarProducto.TabIndex = 6;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(345, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(714, 339);
            dgvProductos.TabIndex = 7;
            // 
            // btnVisualizarProductos
            // 
            btnVisualizarProductos.Location = new Point(632, 357);
            btnVisualizarProductos.Name = "btnVisualizarProductos";
            btnVisualizarProductos.Size = new Size(173, 29);
            btnVisualizarProductos.TabIndex = 8;
            btnVisualizarProductos.Text = "Visualizar productos";
            btnVisualizarProductos.UseVisualStyleBackColor = true;
            btnVisualizarProductos.Click += btnVisualizarProductos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 461);
            Controls.Add(btnVisualizarProductos);
            Controls.Add(dgvProductos);
            Controls.Add(btnGuardarProducto);
            Controls.Add(label3);
            Controls.Add(tbStock);
            Controls.Add(label2);
            Controls.Add(tbPrecio);
            Controls.Add(label1);
            Controls.Add(tbNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private Label label1;
        private Label label2;
        private TextBox tbPrecio;
        private Label label3;
        private TextBox tbStock;
        private Button btnGuardarProducto;
        private DataGridView dgvProductos;
        private Button btnVisualizarProductos;
    }
}
