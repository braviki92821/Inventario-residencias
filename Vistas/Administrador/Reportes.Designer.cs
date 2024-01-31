namespace Inventario_residencias.Vistas.Administrador
{
    partial class Reportes
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
            label1 = new Label();
            panel2 = new Panel();
            btnModificar = new Button();
            dgvReportes = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 24);
            label1.Name = "label1";
            label1.Size = new Size(186, 24);
            label1.TabIndex = 0;
            label1.Text = "Lista de Reportes";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnModificar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 72);
            panel2.TabIndex = 1;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.BackColor = Color.DarkGray;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(26, 22);
            btnModificar.Margin = new Padding(25, 3, 3, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(220, 31);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Marcar como leido";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(26, 161);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowTemplate.Height = 25;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(751, 220);
            dgvReportes.TabIndex = 2;
            dgvReportes.CellClick += dgvReportes_CellClick;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dgvReportes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reportes";
            Text = "Reportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnModificar;
        private DataGridView dgvReportes;
    }
}