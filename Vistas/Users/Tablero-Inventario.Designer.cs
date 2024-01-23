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
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtNumeroFisico = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dgvTablero = new DataGridView();
            panel3 = new Panel();
            txtPaginaActual = new TextBox();
            label3 = new Label();
            btnAnterior = new Button();
            txtTotalPaginas = new TextBox();
            btnSiguiente = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablero).BeginInit();
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
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 86);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(txtNumeroFisico);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 86);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // txtNumeroFisico
            // 
            txtNumeroFisico.Cursor = Cursors.IBeam;
            txtNumeroFisico.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroFisico.Location = new Point(20, 3);
            txtNumeroFisico.Margin = new Padding(20, 3, 3, 3);
            txtNumeroFisico.Multiline = true;
            txtNumeroFisico.Name = "txtNumeroFisico";
            txtNumeroFisico.PlaceholderText = "Buscar por Numero Fisico";
            txtNumeroFisico.Size = new Size(205, 29);
            txtNumeroFisico.TabIndex = 0;
            txtNumeroFisico.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(248, 3);
            textBox1.Margin = new Padding(20, 3, 3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por Descripción";
            textBox1.Size = new Size(205, 29);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(476, 3);
            textBox2.Margin = new Padding(20, 3, 3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Buscar Por Ubicación";
            textBox2.Size = new Size(205, 29);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvTablero
            // 
            dgvTablero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTablero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablero.Location = new Point(20, 168);
            dgvTablero.Name = "dgvTablero";
            dgvTablero.RowTemplate.Height = 25;
            dgvTablero.Size = new Size(765, 183);
            dgvTablero.TabIndex = 2;
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
            Controls.Add(dgvTablero);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tablero_Inventario";
            Text = "Tablero_Inventario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablero).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtNumeroFisico;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dgvTablero;
        private Panel panel3;
        private TextBox txtPaginaActual;
        private Label label3;
        private Button btnAnterior;
        private TextBox txtTotalPaginas;
        private Button btnSiguiente;
        private Label label2;
    }
}