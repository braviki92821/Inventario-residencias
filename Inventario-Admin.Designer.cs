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
            numeroFisicoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            columnaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ubicacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imagenDataGridViewImageColumn = new DataGridViewImageColumn();
            existenciaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            inventarioBindingSource = new BindingSource(components);
            label2 = new Label();
            txtNumFisico = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            txtDescripcion = new TextBox();
            label4 = new Label();
            txtNumeroFisico = new TextBox();
            label5 = new Label();
            cbxColumna = new ComboBox();
            cbxTablero = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cbxExistencia = new ComboBox();
            label8 = new Label();
            cbxFila = new ComboBox();
            label9 = new Label();
            pbxImagen = new PictureBox();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventarioBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(312, 20);
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
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(800, 108);
            dgvInventario.TabIndex = 1;
            dgvInventario.CellClick += dgvInventario_CellClick;
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
            columnaDataGridViewTextBoxColumn.Visible = false;
            // 
            // filaDataGridViewTextBoxColumn
            // 
            filaDataGridViewTextBoxColumn.DataPropertyName = "fila";
            filaDataGridViewTextBoxColumn.HeaderText = "fila";
            filaDataGridViewTextBoxColumn.Name = "filaDataGridViewTextBoxColumn";
            filaDataGridViewTextBoxColumn.ReadOnly = true;
            filaDataGridViewTextBoxColumn.Visible = false;
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
            imagenDataGridViewImageColumn.Image = Properties.Resources.WVG;
            imagenDataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            imagenDataGridViewImageColumn.ReadOnly = true;
            imagenDataGridViewImageColumn.Width = 150;
            // 
            // existenciaDataGridViewCheckBoxColumn
            // 
            existenciaDataGridViewCheckBoxColumn.DataPropertyName = "existencia";
            existenciaDataGridViewCheckBoxColumn.HeaderText = "existencia";
            existenciaDataGridViewCheckBoxColumn.Name = "existenciaDataGridViewCheckBoxColumn";
            existenciaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // inventarioBindingSource
            // 
            inventarioBindingSource.DataSource = typeof(modelos.Inventario);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(208, 18);
            label2.TabIndex = 3;
            label2.Text = "Buscar por numero fisico";
            // 
            // txtNumFisico
            // 
            txtNumFisico.Location = new Point(227, 10);
            txtNumFisico.Name = "txtNumFisico";
            txtNumFisico.Size = new Size(116, 23);
            txtNumFisico.TabIndex = 4;
            txtNumFisico.TextChanged += txtNumFisico_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(582, 10);
            label3.Name = "label3";
            label3.Size = new Size(70, 18);
            label3.TabIndex = 5;
            label3.Text = "Mostrar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "5", "10", "15", "20", "25" });
            comboBox1.Location = new Point(658, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(63, 23);
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
            panel1.Location = new Point(0, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(25, 154);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(221, 23);
            txtDescripcion.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 127);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 11;
            label4.Text = "Descripcion";
            // 
            // txtNumeroFisico
            // 
            txtNumeroFisico.Location = new Point(25, 90);
            txtNumeroFisico.Name = "txtNumeroFisico";
            txtNumeroFisico.Size = new Size(221, 23);
            txtNumeroFisico.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 65);
            label5.Name = "label5";
            label5.Size = new Size(140, 22);
            label5.TabIndex = 9;
            label5.Text = "Numero Fisico";
            // 
            // cbxColumna
            // 
            cbxColumna.Cursor = Cursors.Hand;
            cbxColumna.DropDownHeight = 60;
            cbxColumna.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxColumna.FormattingEnabled = true;
            cbxColumna.IntegralHeight = false;
            cbxColumna.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            cbxColumna.Location = new Point(25, 269);
            cbxColumna.MaxDropDownItems = 6;
            cbxColumna.Name = "cbxColumna";
            cbxColumna.Size = new Size(221, 25);
            cbxColumna.TabIndex = 23;
            cbxColumna.Text = "-----Seleccione-----";
            // 
            // cbxTablero
            // 
            cbxTablero.Cursor = Cursors.Hand;
            cbxTablero.DropDownHeight = 60;
            cbxTablero.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTablero.FormattingEnabled = true;
            cbxTablero.IntegralHeight = false;
            cbxTablero.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            cbxTablero.Location = new Point(25, 207);
            cbxTablero.MaxDropDownItems = 6;
            cbxTablero.Name = "cbxTablero";
            cbxTablero.Size = new Size(221, 25);
            cbxTablero.TabIndex = 22;
            cbxTablero.Text = "-----Seleccione-----";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 244);
            label6.Name = "label6";
            label6.Size = new Size(90, 22);
            label6.TabIndex = 21;
            label6.Text = "Columna";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 180);
            label7.Name = "label7";
            label7.Size = new Size(80, 22);
            label7.TabIndex = 20;
            label7.Text = "Tablero";
            // 
            // cbxExistencia
            // 
            cbxExistencia.Cursor = Cursors.Hand;
            cbxExistencia.DropDownHeight = 60;
            cbxExistencia.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxExistencia.FormattingEnabled = true;
            cbxExistencia.IntegralHeight = false;
            cbxExistencia.Items.AddRange(new object[] { "Si", "No" });
            cbxExistencia.Location = new Point(278, 156);
            cbxExistencia.MaxDropDownItems = 6;
            cbxExistencia.Name = "cbxExistencia";
            cbxExistencia.Size = new Size(209, 25);
            cbxExistencia.TabIndex = 27;
            cbxExistencia.Text = "-----Seleccione-----";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(278, 131);
            label8.Name = "label8";
            label8.Size = new Size(104, 22);
            label8.TabIndex = 26;
            label8.Text = "Existencia";
            // 
            // cbxFila
            // 
            cbxFila.Cursor = Cursors.Hand;
            cbxFila.DropDownHeight = 60;
            cbxFila.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFila.FormattingEnabled = true;
            cbxFila.IntegralHeight = false;
            cbxFila.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbxFila.Location = new Point(278, 92);
            cbxFila.MaxDropDownItems = 6;
            cbxFila.Name = "cbxFila";
            cbxFila.Size = new Size(209, 25);
            cbxFila.TabIndex = 25;
            cbxFila.Text = "-----Seleccione-----";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(278, 65);
            label9.Name = "label9";
            label9.Size = new Size(42, 22);
            label9.TabIndex = 24;
            label9.Text = "Fila";
            // 
            // pbxImagen
            // 
            pbxImagen.BackColor = SystemColors.Control;
            pbxImagen.Location = new Point(537, 90);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(251, 142);
            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagen.TabIndex = 28;
            pbxImagen.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(537, 255);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(102, 28);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(278, 255);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(102, 28);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(408, 255);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 28);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Inventario_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnLimpiar);
            Controls.Add(pbxImagen);
            Controls.Add(cbxExistencia);
            Controls.Add(label8);
            Controls.Add(cbxFila);
            Controls.Add(label9);
            Controls.Add(cbxColumna);
            Controls.Add(cbxTablero);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(txtNumeroFisico);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(dgvInventario);
            Controls.Add(label1);
            Name = "Inventario_Admin";
            Text = "Inventario_Admin";
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventarioBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
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
        private TextBox txtDescripcion;
        private Label label4;
        private TextBox txtNumeroFisico;
        private Label label5;
        private ComboBox cbxColumna;
        private ComboBox cbxTablero;
        private Label label6;
        private Label label7;
        private ComboBox cbxExistencia;
        private Label label8;
        private ComboBox cbxFila;
        private Label label9;
        private PictureBox pbxImagen;
        private DataGridViewTextBoxColumn numeroFisicoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tableroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn columnaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imagenDataGridViewImageColumn;
        private DataGridViewCheckBoxColumn existenciaDataGridViewCheckBoxColumn;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}