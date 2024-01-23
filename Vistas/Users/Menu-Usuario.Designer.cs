namespace Inventario_residencias.Vistas.Usuario
{
    partial class Menu_Usuario
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
            panel1 = new Panel();
            btnCerrarSesión = new Button();
            btnInventario = new Button();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnCerrarSesión);
            panel1.Controls.Add(btnInventario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 560);
            panel1.TabIndex = 0;
            // 
            // btnCerrarSesión
            // 
            btnCerrarSesión.BackColor = Color.IndianRed;
            btnCerrarSesión.Dock = DockStyle.Bottom;
            btnCerrarSesión.FlatAppearance.BorderSize = 2;
            btnCerrarSesión.FlatStyle = FlatStyle.Flat;
            btnCerrarSesión.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesión.Location = new Point(0, 484);
            btnCerrarSesión.Name = "btnCerrarSesión";
            btnCerrarSesión.Size = new Size(309, 76);
            btnCerrarSesión.TabIndex = 1;
            btnCerrarSesión.Text = "Cerrar Sesión";
            btnCerrarSesión.UseVisualStyleBackColor = false;
            btnCerrarSesión.Click += btnCerrarSesión_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(128, 128, 255);
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 2;
            btnInventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInventario.Location = new Point(0, 0);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(309, 76);
            btnInventario.TabIndex = 0;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.SteelBlue;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(309, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(955, 560);
            panelContenedor.TabIndex = 1;
            // 
            // Menu_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 560);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 599);
            Name = "Menu_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu_Usuario";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelContenedor;
        private Button btnInventario;
        private Button btnCerrarSesión;
    }
}