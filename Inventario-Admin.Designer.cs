namespace Inventario_residencias
{
    partial class Inventario_Admin
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dgvInventario = new DataGridView();
            inventarioBindingSource = new BindingSource(components);
            label2 = new Label();
            txtNumFisico = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            numeroFisicoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            columnaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ubicacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imagenDataGridViewImageColumn = new DataGridViewImageColumn();
            existenciaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventarioBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(308, 32);
            label1.Name = "label1";
            label1.Size = new Size(226, 28);
            label1.TabIndex = 0;
            label1.Text = "Lista de Inventario";
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AutoGenerateColumns = false;
            dgvInventario.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { numeroFisicoIdDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, tableroDataGridViewTextBoxColumn, columnaDataGridViewTextBoxColumn, filaDataGridViewTextBoxColumn, ubicacionDataGridViewTextBoxColumn, imagenDataGridViewImageColumn, existenciaDataGridViewCheckBoxColumn });
            dgvInventario.DataSource = inventarioBindingSource;
            dgvInventario.Dock = DockStyle.Bottom;
            dgvInventario.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInventario.Location = new Point(0, 342);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.Size = new Size(800, 108);
            dgvInventario.TabIndex = 1;
            // 
            // inventarioBindingSource
            // 
            inventarioBindingSource.DataSource = typeof(modelos.Inventario);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 19);
            label2.Name = "label2";
            label2.Size = new Size(208, 18);
            label2.TabIndex = 3;
            label2.Text = "Buscar por numero fisico";
            // 
            // txtNumFisico
            // 
            txtNumFisico.Location = new Point(227, 19);
            txtNumFisico.Name = "txtNumFisico";
            txtNumFisico.Size = new Size(116, 23);
            txtNumFisico.TabIndex = 4;
            txtNumFisico.TextChanged += txtNumFisico_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(582, 19);
            label3.Name = "label3";
            label3.Size = new Size(70, 18);
            label3.TabIndex = 5;
            label3.Text = "Mostrar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "10", "15", "20", "25" });
            comboBox1.Location = new Point(658, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(54, 23);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "5";
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNumFisico);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 49);
            panel1.TabIndex = 8;
            // 
            // numeroFisicoIdDataGridViewTextBoxColumn
            // 
            numeroFisicoIdDataGridViewTextBoxColumn.DataPropertyName = "numeroFisicoId";
            numeroFisicoIdDataGridViewTextBoxColumn.HeaderText = "numeroFisicoId";
            numeroFisicoIdDataGridViewTextBoxColumn.Name = "numeroFisicoIdDataGridViewTextBoxColumn";
            numeroFisicoIdDataGridViewTextBoxColumn.ReadOnly = true;
            numeroFisicoIdDataGridViewTextBoxColumn.Width = 110;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            descripcionDataGridViewTextBoxColumn.Width = 140;
            // 
            // tableroDataGridViewTextBoxColumn
            // 
            tableroDataGridViewTextBoxColumn.DataPropertyName = "tablero";
            tableroDataGridViewTextBoxColumn.HeaderText = "tablero";
            tableroDataGridViewTextBoxColumn.Name = "tableroDataGridViewTextBoxColumn";
            tableroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnaDataGridViewTextBoxColumn
            // 
            columnaDataGridViewTextBoxColumn.DataPropertyName = "columna";
            columnaDataGridViewTextBoxColumn.HeaderText = "columna";
            columnaDataGridViewTextBoxColumn.Name = "columnaDataGridViewTextBoxColumn";
            columnaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filaDataGridViewTextBoxColumn
            // 
            filaDataGridViewTextBoxColumn.DataPropertyName = "fila";
            filaDataGridViewTextBoxColumn.HeaderText = "fila";
            filaDataGridViewTextBoxColumn.Name = "filaDataGridViewTextBoxColumn";
            filaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            ubicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion";
            ubicacionDataGridViewTextBoxColumn.HeaderText = "ubicacion";
            ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            ubicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagenDataGridViewImageColumn
            // 
            imagenDataGridViewImageColumn.DataPropertyName = "imagen";
            imagenDataGridViewImageColumn.HeaderText = "imagen";
            imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            imagenDataGridViewImageColumn.ReadOnly = true;
            imagenDataGridViewImageColumn.Visible = false;
            // 
            // existenciaDataGridViewCheckBoxColumn
            // 
            existenciaDataGridViewCheckBoxColumn.DataPropertyName = "existencia";
            existenciaDataGridViewCheckBoxColumn.HeaderText = "existencia";
            existenciaDataGridViewCheckBoxColumn.Name = "existenciaDataGridViewCheckBoxColumn";
            existenciaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Inventario_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgvInventario);
            Controls.Add(label1);
            Name = "Inventario_Admin";
            Text = "Inventario_Admin";
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventarioBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvInventario;
        private Label label2;
        private TextBox txtNumFisico;
        private Label label3;
        private ComboBox comboBox1;
        private Panel panel1;
        private BindingSource inventarioBindingSource;
        private DataGridViewTextBoxColumn numeroFisicoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tableroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn columnaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imagenDataGridViewImageColumn;
        private DataGridViewCheckBoxColumn existenciaDataGridViewCheckBoxColumn;
    }
}