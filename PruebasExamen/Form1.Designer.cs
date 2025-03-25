namespace PruebasExamen
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
            btnGetFutbolistas = new Button();
            lstbxFutbolistas = new ListBox();
            lstvwFutbolistas = new ListView();
            btnGetFutbolistasLstvw = new Button();
            btnDeleteSelected = new Button();
            tbFicheroAEscribir = new TextBox();
            btnEscribir = new Button();
            btnGetJugadoresByEquipo = new Button();
            SuspendLayout();
            // 
            // btnGetFutbolistas
            // 
            btnGetFutbolistas.Location = new Point(27, 142);
            btnGetFutbolistas.Name = "btnGetFutbolistas";
            btnGetFutbolistas.Size = new Size(172, 29);
            btnGetFutbolistas.TabIndex = 0;
            btnGetFutbolistas.Text = "Get futbolistas";
            btnGetFutbolistas.UseVisualStyleBackColor = true;
            btnGetFutbolistas.Click += btnGetFutbolistas_Click;
            // 
            // lstbxFutbolistas
            // 
            lstbxFutbolistas.FormattingEnabled = true;
            lstbxFutbolistas.Location = new Point(12, 12);
            lstbxFutbolistas.Name = "lstbxFutbolistas";
            lstbxFutbolistas.Size = new Size(187, 124);
            lstbxFutbolistas.TabIndex = 1;
            // 
            // lstvwFutbolistas
            // 
            lstvwFutbolistas.Location = new Point(276, 15);
            lstvwFutbolistas.Name = "lstvwFutbolistas";
            lstvwFutbolistas.Size = new Size(315, 121);
            lstvwFutbolistas.TabIndex = 2;
            lstvwFutbolistas.UseCompatibleStateImageBehavior = false;
            lstvwFutbolistas.View = View.Details;
            // 
            // btnGetFutbolistasLstvw
            // 
            btnGetFutbolistasLstvw.Location = new Point(356, 142);
            btnGetFutbolistasLstvw.Name = "btnGetFutbolistasLstvw";
            btnGetFutbolistasLstvw.Size = new Size(172, 29);
            btnGetFutbolistasLstvw.TabIndex = 3;
            btnGetFutbolistasLstvw.Text = "Get futbolistas";
            btnGetFutbolistasLstvw.UseVisualStyleBackColor = true;
            btnGetFutbolistasLstvw.Click += btnGetFutbolistasLstvw_Click;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Location = new Point(27, 209);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(172, 29);
            btnDeleteSelected.TabIndex = 4;
            btnDeleteSelected.Text = "DeleteSelected";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // tbFicheroAEscribir
            // 
            tbFicheroAEscribir.Location = new Point(12, 264);
            tbFicheroAEscribir.Multiline = true;
            tbFicheroAEscribir.Name = "tbFicheroAEscribir";
            tbFicheroAEscribir.Size = new Size(252, 112);
            tbFicheroAEscribir.TabIndex = 5;
            // 
            // btnEscribir
            // 
            btnEscribir.Location = new Point(55, 382);
            btnEscribir.Name = "btnEscribir";
            btnEscribir.Size = new Size(172, 29);
            btnEscribir.TabIndex = 6;
            btnEscribir.Text = "Escribir";
            btnEscribir.UseVisualStyleBackColor = true;
            btnEscribir.Click += btnEscribir_Click;
            // 
            // btnGetJugadoresByEquipo
            // 
            btnGetJugadoresByEquipo.Location = new Point(356, 382);
            btnGetJugadoresByEquipo.Name = "btnGetJugadoresByEquipo";
            btnGetJugadoresByEquipo.Size = new Size(172, 29);
            btnGetJugadoresByEquipo.TabIndex = 7;
            btnGetJugadoresByEquipo.Text = "Escribir";
            btnGetJugadoresByEquipo.UseVisualStyleBackColor = true;
            btnGetJugadoresByEquipo.Click += btnGetJugadoresByEquipo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetJugadoresByEquipo);
            Controls.Add(btnEscribir);
            Controls.Add(tbFicheroAEscribir);
            Controls.Add(btnDeleteSelected);
            Controls.Add(btnGetFutbolistasLstvw);
            Controls.Add(lstvwFutbolistas);
            Controls.Add(lstbxFutbolistas);
            Controls.Add(btnGetFutbolistas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetFutbolistas;
        private ListBox lstbxFutbolistas;
        private ListView lstvwFutbolistas;
        private Button btnGetFutbolistasLstvw;
        private Button btnDeleteSelected;
        private TextBox tbFicheroAEscribir;
        private Button btnEscribir;
        private Button btnGetJugadoresByEquipo;
    }
}
