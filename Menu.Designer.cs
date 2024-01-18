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
            btnUsuarios = new Button();
            label3 = new Label();
            btnListaItems = new Button();
            btnAgregarItem = new Button();
            label2 = new Label();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.SteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnListaItems);
            panel1.Controls.Add(btnAgregarItem);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 560);
            panel1.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(0, 148);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(305, 41);
            btnUsuarios.TabIndex = 9;
            btnUsuarios.Text = "Lista de usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 115);
            label3.Name = "label3";
            label3.Size = new Size(143, 33);
            label3.TabIndex = 7;
            label3.Text = "Usuarios";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnListaItems
            // 
            btnListaItems.Dock = DockStyle.Top;
            btnListaItems.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaItems.Location = new Point(0, 74);
            btnListaItems.Name = "btnListaItems";
            btnListaItems.Size = new Size(305, 41);
            btnListaItems.TabIndex = 6;
            btnListaItems.Text = "Lista de Inventario";
            btnListaItems.UseVisualStyleBackColor = true;
            btnListaItems.Click += btnListaItems_Click;
            // 
            // btnAgregarItem
            // 
            btnAgregarItem.Dock = DockStyle.Top;
            btnAgregarItem.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarItem.Location = new Point(0, 33);
            btnAgregarItem.Margin = new Padding(3, 10, 3, 3);
            btnAgregarItem.Name = "btnAgregarItem";
            btnAgregarItem.Size = new Size(305, 41);
            btnAgregarItem.TabIndex = 5;
            btnAgregarItem.Text = "Agregar Item";
            btnAgregarItem.UseVisualStyleBackColor = true;
            btnAgregarItem.Click += btnAgregarItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 33);
            label2.TabIndex = 4;
            label2.Text = "Inventario";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.SteelBlue;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(307, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(788, 560);
            panelContenedor.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1095, 560);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelContenedor;
        private Label label2;
        private Button btnAgregarItem;
        private Button btnListaItems;
        private Label label3;
        private Button btnUsuarios;
    }
}