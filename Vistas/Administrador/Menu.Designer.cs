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
            button1 = new Button();
            btnUsuarios = new Button();
            btnListaItems = new Button();
            btnAgregarItem = new Button();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.SteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnListaItems);
            panel1.Controls.Add(btnAgregarItem);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 560);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 482);
            button1.Name = "button1";
            button1.Size = new Size(307, 76);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(128, 128, 255);
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 2;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(0, 152);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(307, 76);
            btnUsuarios.TabIndex = 9;
            btnUsuarios.Text = "Lista de usuarios";
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
            btnListaItems.Location = new Point(0, 76);
            btnListaItems.Name = "btnListaItems";
            btnListaItems.Size = new Size(307, 76);
            btnListaItems.TabIndex = 6;
            btnListaItems.Text = "Lista de Inventario";
            btnListaItems.UseVisualStyleBackColor = false;
            btnListaItems.Click += btnListaItems_Click;
            // 
            // btnAgregarItem
            // 
            btnAgregarItem.BackColor = Color.FromArgb(128, 128, 255);
            btnAgregarItem.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregarItem.Cursor = Cursors.Hand;
            btnAgregarItem.Dock = DockStyle.Top;
            btnAgregarItem.FlatAppearance.BorderColor = Color.Black;
            btnAgregarItem.FlatAppearance.BorderSize = 2;
            btnAgregarItem.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnAgregarItem.FlatStyle = FlatStyle.Flat;
            btnAgregarItem.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarItem.Location = new Point(0, 0);
            btnAgregarItem.Margin = new Padding(3, 10, 3, 3);
            btnAgregarItem.Name = "btnAgregarItem";
            btnAgregarItem.Size = new Size(307, 76);
            btnAgregarItem.TabIndex = 5;
            btnAgregarItem.Text = "Agregar Item";
            btnAgregarItem.UseVisualStyleBackColor = false;
            btnAgregarItem.Click += btnAgregarItem_Click;
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
            MinimumSize = new Size(1000, 599);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelContenedor;
        private Button btnAgregarItem;
        private Button btnListaItems;
        private Button btnUsuarios;
        private Button button1;
    }
}