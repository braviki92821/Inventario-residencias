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
            panel1 = new Panel();
            panelUsuarioSubMenu = new Panel();
            btnListaUsuarios = new Button();
            btnAgregarUsuario = new Button();
            btnUsuarios = new Button();
            panelInventarioSubMenu = new Panel();
            btnListaItems = new Button();
            btnAgregarItem = new Button();
            btnInventario = new Button();
            panelProfileSubMenu = new Panel();
            btnLogout = new Button();
            btnMisDatos = new Button();
            btnPerfil = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            panelUsuarioSubMenu.SuspendLayout();
            panelInventarioSubMenu.SuspendLayout();
            panelProfileSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(panelUsuarioSubMenu);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(panelInventarioSubMenu);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(panelProfileSubMenu);
            panel1.Controls.Add(btnPerfil);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 560);
            panel1.TabIndex = 0;
            // 
            // panelUsuarioSubMenu
            // 
            panelUsuarioSubMenu.Controls.Add(btnListaUsuarios);
            panelUsuarioSubMenu.Controls.Add(btnAgregarUsuario);
            panelUsuarioSubMenu.Dock = DockStyle.Top;
            panelUsuarioSubMenu.Location = new Point(0, 422);
            panelUsuarioSubMenu.Name = "panelUsuarioSubMenu";
            panelUsuarioSubMenu.Size = new Size(292, 91);
            panelUsuarioSubMenu.TabIndex = 6;
            // 
            // btnListaUsuarios
            // 
            btnListaUsuarios.Dock = DockStyle.Top;
            btnListaUsuarios.Location = new Point(0, 45);
            btnListaUsuarios.Name = "btnListaUsuarios";
            btnListaUsuarios.Size = new Size(292, 45);
            btnListaUsuarios.TabIndex = 1;
            btnListaUsuarios.Text = "Lista de usuarios";
            btnListaUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Dock = DockStyle.Top;
            btnAgregarUsuario.Location = new Point(0, 0);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(292, 45);
            btnAgregarUsuario.TabIndex = 0;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(0, 378);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(292, 44);
            btnUsuarios.TabIndex = 5;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelInventarioSubMenu
            // 
            panelInventarioSubMenu.Controls.Add(btnListaItems);
            panelInventarioSubMenu.Controls.Add(btnAgregarItem);
            panelInventarioSubMenu.Dock = DockStyle.Top;
            panelInventarioSubMenu.Location = new Point(0, 290);
            panelInventarioSubMenu.Name = "panelInventarioSubMenu";
            panelInventarioSubMenu.Size = new Size(292, 88);
            panelInventarioSubMenu.TabIndex = 4;
            // 
            // btnListaItems
            // 
            btnListaItems.Dock = DockStyle.Top;
            btnListaItems.Location = new Point(0, 45);
            btnListaItems.Name = "btnListaItems";
            btnListaItems.Size = new Size(292, 40);
            btnListaItems.TabIndex = 1;
            btnListaItems.Text = "Lista de items";
            btnListaItems.UseVisualStyleBackColor = true;
            btnListaItems.Click += btnListaItems_Click;
            // 
            // btnAgregarItem
            // 
            btnAgregarItem.Dock = DockStyle.Top;
            btnAgregarItem.Location = new Point(0, 0);
            btnAgregarItem.Name = "btnAgregarItem";
            btnAgregarItem.Size = new Size(292, 45);
            btnAgregarItem.TabIndex = 0;
            btnAgregarItem.Text = "Añadir Item";
            btnAgregarItem.UseVisualStyleBackColor = true;
            btnAgregarItem.Click += btnAgregarItem_Click;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInventario.Location = new Point(0, 241);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(292, 49);
            btnInventario.TabIndex = 3;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // panelProfileSubMenu
            // 
            panelProfileSubMenu.BackColor = Color.LightSkyBlue;
            panelProfileSubMenu.Controls.Add(btnLogout);
            panelProfileSubMenu.Controls.Add(btnMisDatos);
            panelProfileSubMenu.Dock = DockStyle.Top;
            panelProfileSubMenu.Location = new Point(0, 146);
            panelProfileSubMenu.Name = "panelProfileSubMenu";
            panelProfileSubMenu.Size = new Size(292, 95);
            panelProfileSubMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.Location = new Point(0, 45);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(292, 47);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnMisDatos
            // 
            btnMisDatos.Dock = DockStyle.Top;
            btnMisDatos.Location = new Point(0, 0);
            btnMisDatos.Name = "btnMisDatos";
            btnMisDatos.Size = new Size(292, 45);
            btnMisDatos.TabIndex = 0;
            btnMisDatos.Text = "Mis Datos";
            btnMisDatos.UseVisualStyleBackColor = true;
            // 
            // btnPerfil
            // 
            btnPerfil.Dock = DockStyle.Top;
            btnPerfil.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPerfil.Location = new Point(0, 97);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(292, 49);
            btnPerfil.TabIndex = 1;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Azure;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.SteelBlue;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(292, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(776, 560);
            panelContenedor.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1068, 560);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel1.ResumeLayout(false);
            panelUsuarioSubMenu.ResumeLayout(false);
            panelInventarioSubMenu.ResumeLayout(false);
            panelProfileSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelProfileSubMenu;
        private Button btnPerfil;
        private Button btnMisDatos;
        private Button btnLogout;
        private Button btnInventario;
        private Panel panelInventarioSubMenu;
        private Button btnAgregarItem;
        private Button btnListaItems;
        private Button btnUsuarios;
        private Panel panelUsuarioSubMenu;
        private Button btnListaUsuarios;
        private Button btnAgregarUsuario;
        private Panel panelContenedor;
    }
}