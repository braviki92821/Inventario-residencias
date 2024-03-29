﻿namespace Inventario_residencias.Vistas.Administrador
{
    partial class Lista_Inventario
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
            label1 = new Label();
            panel1 = new Panel();
            btnRecargar = new Button();
            txtNumFisico = new TextBox();
            dgvInventario = new DataGridView();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEstatus = new Button();
            btnEliminar = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            label2 = new Label();
            txtPaginaActual = new TextBox();
            txtTotalPaginas = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            btnGenerarExcel = new Button();
            btnReporte = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(226, 28);
            label1.TabIndex = 1;
            label1.Text = "Lista de Inventario";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(txtNumFisico);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 0;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(540, 20);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(86, 23);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Refrescar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // txtNumFisico
            // 
            txtNumFisico.Cursor = Cursors.IBeam;
            txtNumFisico.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumFisico.Location = new Point(282, 22);
            txtNumFisico.Name = "txtNumFisico";
            txtNumFisico.PlaceholderText = "Buscar por Numero Fisico";
            txtNumFisico.Size = new Size(186, 21);
            txtNumFisico.TabIndex = 2;
            txtNumFisico.TextChanged += txtNumFisico_TextChanged;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(24, 163);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(757, 194);
            dgvInventario.TabIndex = 2;
            dgvInventario.CellClick += dgvInventario_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 77);
            panel2.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnAgregar);
            flowLayoutPanel2.Controls.Add(btnModificar);
            flowLayoutPanel2.Controls.Add(btnEstatus);
            flowLayoutPanel2.Controls.Add(btnEliminar);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(800, 98);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.BackColor = Color.ForestGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(25, 3);
            btnAgregar.Margin = new Padding(25, 3, 3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(230, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.BackColor = Color.Goldenrod;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(283, 3);
            btnModificar.Margin = new Padding(25, 3, 3, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(230, 31);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEstatus
            // 
            btnEstatus.AutoSize = true;
            btnEstatus.BackColor = Color.Tomato;
            btnEstatus.BackgroundImageLayout = ImageLayout.None;
            btnEstatus.Cursor = Cursors.Hand;
            btnEstatus.FlatAppearance.BorderSize = 2;
            btnEstatus.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnEstatus.FlatStyle = FlatStyle.Flat;
            btnEstatus.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstatus.ForeColor = SystemColors.ControlText;
            btnEstatus.Location = new Point(541, 3);
            btnEstatus.Margin = new Padding(25, 3, 3, 3);
            btnEstatus.Name = "btnEstatus";
            btnEstatus.Size = new Size(230, 31);
            btnEstatus.TabIndex = 3;
            btnEstatus.Text = "Cambiar estatus";
            btnEstatus.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEstatus.UseVisualStyleBackColor = false;
            btnEstatus.Click += btnEstatus_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(25, 40);
            btnEliminar.Margin = new Padding(25, 3, 3, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(230, 31);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnterior.Location = new Point(618, 3);
            btnAnterior.Margin = new Padding(5, 3, 3, 3);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(33, 23);
            btnAnterior.TabIndex = 4;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSiguiente.Location = new Point(688, 3);
            btnSiguiente.Margin = new Padding(5, 3, 3, 3);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(33, 23);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(522, 8);
            label2.Name = "label2";
            label2.Size = new Size(47, 14);
            label2.TabIndex = 6;
            label2.Text = "Pagina";
            // 
            // txtPaginaActual
            // 
            txtPaginaActual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPaginaActual.Enabled = false;
            txtPaginaActual.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaginaActual.Location = new Point(575, 4);
            txtPaginaActual.Name = "txtPaginaActual";
            txtPaginaActual.Size = new Size(35, 21);
            txtPaginaActual.TabIndex = 7;
            // 
            // txtTotalPaginas
            // 
            txtTotalPaginas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalPaginas.Enabled = false;
            txtTotalPaginas.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPaginas.Location = new Point(727, 5);
            txtTotalPaginas.Name = "txtTotalPaginas";
            txtTotalPaginas.Size = new Size(35, 21);
            txtTotalPaginas.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(657, 8);
            label3.Name = "label3";
            label3.Size = new Size(23, 14);
            label3.TabIndex = 9;
            label3.Text = "De";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGenerarExcel);
            panel3.Controls.Add(btnReporte);
            panel3.Controls.Add(txtPaginaActual);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnAnterior);
            panel3.Controls.Add(txtTotalPaginas);
            panel3.Controls.Add(btnSiguiente);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 363);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 87);
            panel3.TabIndex = 10;
            // 
            // btnGenerarExcel
            // 
            btnGenerarExcel.BackColor = Color.MediumAquamarine;
            btnGenerarExcel.Cursor = Cursors.Hand;
            btnGenerarExcel.FlatAppearance.BorderSize = 2;
            btnGenerarExcel.FlatStyle = FlatStyle.Flat;
            btnGenerarExcel.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarExcel.Location = new Point(204, 8);
            btnGenerarExcel.Name = "btnGenerarExcel";
            btnGenerarExcel.Size = new Size(157, 34);
            btnGenerarExcel.TabIndex = 11;
            btnGenerarExcel.Text = "Generar Excel";
            btnGenerarExcel.UseVisualStyleBackColor = false;
            btnGenerarExcel.Click += btnGenerarExcel_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.MediumAquamarine;
            btnReporte.Cursor = Cursors.Hand;
            btnReporte.FlatAppearance.BorderSize = 2;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporte.Location = new Point(25, 8);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(161, 34);
            btnReporte.TabIndex = 10;
            btnReporte.Text = "Generar Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // Lista_Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgvInventario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Lista_Inventario";
            Text = "Lista_Inventario";
            FormClosed += Lista_Inventario_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private DataGridView dgvInventario;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEstatus;
        private TextBox txtNumFisico;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label label2;
        private TextBox txtPaginaActual;
        private TextBox txtTotalPaginas;
        private Label label3;
        private Panel panel3;
        private DataGridViewTextBoxColumn tableroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnReporte;
        private Button btnGenerarExcel;
        private Button btnRecargar;
        private Button btnEliminar;
    }
}