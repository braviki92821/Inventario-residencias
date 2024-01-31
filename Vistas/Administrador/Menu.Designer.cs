namespace Inventario_residencias
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            btnRespaldo = new Button();
            btnReportes = new Button();
            btnCerrarSesion = new Button();
            btnUsuarios = new Button();
            btnListaItems = new Button();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.SteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRespaldo);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnListaItems);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 560);
            panel1.TabIndex = 0;
            // 
            // btnRespaldo
            // 
            btnRespaldo.BackColor = Color.FromArgb(128, 128, 255);
            btnRespaldo.Dock = DockStyle.Top;
            btnRespaldo.FlatAppearance.BorderSize = 2;
            btnRespaldo.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnRespaldo.FlatStyle = FlatStyle.Flat;
            btnRespaldo.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRespaldo.Location = new Point(0, 228);
            btnRespaldo.Name = "btnRespaldo";
            btnRespaldo.Size = new Size(307, 76);
            btnRespaldo.TabIndex = 12;
            btnRespaldo.Text = "Respaldo";
            btnRespaldo.UseVisualStyleBackColor = false;
            btnRespaldo.Click += btnRespaldo_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(128, 128, 255);
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 2;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportes.Location = new Point(0, 152);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(307, 76);
            btnReportes.TabIndex = 11;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.IndianRed;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 3;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.Image = Properties.Resources._4115234_login_sign_in_114046;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.Location = new Point(0, 482);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(307, 76);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(128, 128, 255);
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 2;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(0, 76);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(307, 76);
            btnUsuarios.TabIndex = 9;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnListaItems
            // 
            btnListaItems.BackColor = Color.FromArgb(128, 128, 255);
            btnListaItems.Dock = DockStyle.Top;
            btnListaItems.FlatAppearance.BorderSize = 2;
            btnListaItems.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnListaItems.FlatStyle = FlatStyle.Flat;
            btnListaItems.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaItems.Location = new Point(0, 0);
            btnListaItems.Name = "btnListaItems";
            btnListaItems.Size = new Size(307, 76);
            btnListaItems.TabIndex = 6;
            btnListaItems.Text = "Inventario";
            btnListaItems.UseVisualStyleBackColor = false;
            btnListaItems.Click += btnListaItems_Click;
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
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1264, 560);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 599);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelContenedor;
        private Button btnListaItems;
        private Button btnUsuarios;
        private Button btnCerrarSesion;
        private Button btnReportes;
        private Button btnRespaldo;
    }
}