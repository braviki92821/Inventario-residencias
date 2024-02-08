namespace Inventario_residencias.Vistas.Usuario
{
    partial class Tablero_Inventario
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
            btnReiniciar = new Button();
            btnReportar = new Button();
            btnBuscarNumero = new Button();
            label4 = new Label();
            txtNumFisico = new TextBox();
            dgvInventario = new DataGridView();
            panel3 = new Panel();
            txtPaginaActual = new TextBox();
            label3 = new Label();
            btnAnterior = new Button();
            txtTotalPaginas = new TextBox();
            btnSiguiente = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(226, 24);
            label1.TabIndex = 0;
            label1.Text = "Tablero de Inventario";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnReiniciar);
            panel2.Controls.Add(btnReportar);
            panel2.Controls.Add(btnBuscarNumero);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtNumFisico);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 66);
            panel2.TabIndex = 1;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.MediumSeaGreen;
            btnReiniciar.FlatAppearance.BorderSize = 2;
            btnReiniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReiniciar.Location = new Point(518, 21);
            btnReiniciar.Margin = new Padding(10, 3, 3, 3);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(115, 29);
            btnReiniciar.TabIndex = 10;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnReportar
            // 
            btnReportar.BackColor = Color.Brown;
            btnReportar.FlatAppearance.BorderSize = 2;
            btnReportar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnReportar.FlatStyle = FlatStyle.Flat;
            btnReportar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportar.Location = new Point(390, 21);
            btnReportar.Margin = new Padding(10, 3, 3, 3);
            btnReportar.Name = "btnReportar";
            btnReportar.Size = new Size(115, 29);
            btnReportar.TabIndex = 9;
            btnReportar.Text = "Reportar";
            btnReportar.UseVisualStyleBackColor = false;
            btnReportar.Click += btnReportar_Click;
            // 
            // btnBuscarNumero
            // 
            btnBuscarNumero.BackColor = Color.RoyalBlue;
            btnBuscarNumero.FlatAppearance.BorderSize = 2;
            btnBuscarNumero.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnBuscarNumero.FlatStyle = FlatStyle.Flat;
            btnBuscarNumero.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarNumero.Location = new Point(262, 21);
            btnBuscarNumero.Margin = new Padding(10, 3, 3, 3);
            btnBuscarNumero.Name = "btnBuscarNumero";
            btnBuscarNumero.Size = new Size(115, 29);
            btnBuscarNumero.TabIndex = 8;
            btnBuscarNumero.Text = "Buscar";
            btnBuscarNumero.UseVisualStyleBackColor = false;
            btnBuscarNumero.Click += btnBuscarNumero_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 3);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // txtNumFisico
            // 
            txtNumFisico.Cursor = Cursors.IBeam;
            txtNumFisico.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumFisico.Location = new Point(20, 21);
            txtNumFisico.Margin = new Padding(20, 3, 3, 3);
            txtNumFisico.Multiline = true;
            txtNumFisico.Name = "txtNumFisico";
            txtNumFisico.PlaceholderText = "Buscar por Numero Fisico";
            txtNumFisico.Size = new Size(229, 29);
            txtNumFisico.TabIndex = 4;
            txtNumFisico.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(20, 156);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(765, 195);
            dgvInventario.TabIndex = 2;
            dgvInventario.CellClick += dgvInventario_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPaginaActual);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnAnterior);
            panel3.Controls.Add(txtTotalPaginas);
            panel3.Controls.Add(btnSiguiente);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 357);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 93);
            panel3.TabIndex = 3;
            // 
            // txtPaginaActual
            // 
            txtPaginaActual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPaginaActual.Enabled = false;
            txtPaginaActual.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaginaActual.Location = new Point(596, 12);
            txtPaginaActual.Name = "txtPaginaActual";
            txtPaginaActual.Size = new Size(35, 21);
            txtPaginaActual.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(678, 16);
            label3.Name = "label3";
            label3.Size = new Size(23, 14);
            label3.TabIndex = 15;
            label3.Text = "De";
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnterior.Location = new Point(639, 11);
            btnAnterior.Margin = new Padding(5, 3, 3, 3);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(33, 23);
            btnAnterior.TabIndex = 10;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // txtTotalPaginas
            // 
            txtTotalPaginas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalPaginas.Enabled = false;
            txtTotalPaginas.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPaginas.Location = new Point(748, 13);
            txtTotalPaginas.Name = "txtTotalPaginas";
            txtTotalPaginas.Size = new Size(35, 21);
            txtTotalPaginas.TabIndex = 14;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSiguiente.Location = new Point(709, 11);
            btnSiguiente.Margin = new Padding(5, 3, 3, 3);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(33, 23);
            btnSiguiente.TabIndex = 11;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(543, 16);
            label2.Name = "label2";
            label2.Size = new Size(47, 14);
            label2.TabIndex = 12;
            label2.Text = "Pagina";
            // 
            // Tablero_Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(dgvInventario);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tablero_Inventario";
            Text = "Tablero_Inventario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvInventario;
        private Panel panel3;
        private TextBox txtPaginaActual;
        private Label label3;
        private Button btnAnterior;
        private TextBox txtTotalPaginas;
        private Button btnSiguiente;
        private Label label2;
        private Button btnBuscarNumero;
        private Label label4;
        private TextBox txtNumFisico;
        private Button btnReiniciar;
        private Button btnReportar;
    }
}