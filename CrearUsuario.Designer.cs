namespace Inventario_residencias
{
    partial class Usuarios
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
            dgvUsuarios = new DataGridView();
            usuarioIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            imagenDataGridViewImageColumn = new DataGridViewImageColumn();
            usuarioBindingSource = new BindingSource(components);
            panel1 = new Panel();
            textBox1 = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            pbxImagen = new PictureBox();
            cbxTipo = new ComboBox();
            label2 = new Label();
            txtCorreo = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtUsuarioId = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { usuarioIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, statusDataGridViewCheckBoxColumn, imagenDataGridViewImageColumn });
            dgvUsuarios.DataSource = usuarioBindingSource;
            dgvUsuarios.Dock = DockStyle.Bottom;
            dgvUsuarios.Location = new Point(0, 304);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(800, 146);
            dgvUsuarios.TabIndex = 38;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "usuarioId";
            usuarioIdDataGridViewTextBoxColumn.HeaderText = "usuarioId";
            usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            usuarioIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            correoDataGridViewTextBoxColumn.HeaderText = "correo";
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            statusDataGridViewCheckBoxColumn.HeaderText = "status";
            statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // imagenDataGridViewImageColumn
            // 
            imagenDataGridViewImageColumn.DataPropertyName = "imagen";
            imagenDataGridViewImageColumn.HeaderText = "imagen";
            imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            imagenDataGridViewImageColumn.ReadOnly = true;
            imagenDataGridViewImageColumn.Visible = false;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(modelos.Usuario);
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 257);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 47);
            panel1.TabIndex = 39;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(374, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(206, 16);
            label6.Name = "label6";
            label6.Size = new Size(162, 18);
            label6.TabIndex = 0;
            label6.Text = "Buscar por nombre";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(pbxImagen);
            panel2.Controls.Add(cbxTipo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtUsuarioId);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 257);
            panel2.TabIndex = 40;
            // 
            // button1
            // 
            button1.Location = new Point(289, 180);
            button1.Name = "button1";
            button1.Size = new Size(219, 23);
            button1.TabIndex = 58;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(305, 9);
            label8.Name = "label8";
            label8.Size = new Size(213, 28);
            label8.TabIndex = 57;
            label8.Text = "Lista de Usuarios";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(566, 59);
            label7.Name = "label7";
            label7.Size = new Size(78, 22);
            label7.TabIndex = 56;
            label7.Text = "Imagen";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(290, 209);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(219, 23);
            btnLimpiar.TabIndex = 55;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(289, 151);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(219, 23);
            btnModificar.TabIndex = 54;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(289, 122);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(220, 23);
            btnAgregar.TabIndex = 53;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pbxImagen
            // 
            pbxImagen.BackColor = SystemColors.ButtonFace;
            pbxImagen.Location = new Point(566, 84);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(222, 152);
            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagen.TabIndex = 52;
            pbxImagen.TabStop = false;
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Administrador", "Usuario" });
            cbxTipo.Location = new Point(289, 84);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(220, 23);
            cbxTipo.TabIndex = 49;
            cbxTipo.Text = "-----Seleccione-----";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(289, 59);
            label2.Name = "label2";
            label2.Size = new Size(50, 22);
            label2.TabIndex = 48;
            label2.Text = "Tipo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(22, 210);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(221, 23);
            txtCorreo.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 185);
            label1.Name = "label1";
            label1.Size = new Size(73, 22);
            label1.TabIndex = 46;
            label1.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 123);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 44;
            label4.Text = "Nombre";
            // 
            // txtUsuarioId
            // 
            txtUsuarioId.Enabled = false;
            txtUsuarioId.Location = new Point(22, 84);
            txtUsuarioId.Name = "txtUsuarioId";
            txtUsuarioId.Size = new Size(221, 23);
            txtUsuarioId.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 59);
            label5.Name = "label5";
            label5.Size = new Size(133, 22);
            label5.TabIndex = 42;
            label5.Text = "Id del usuario";
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Usuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private DataGridViewImageColumn imagenDataGridViewImageColumn;
        private BindingSource usuarioBindingSource;
        private Panel panel1;
        private TextBox textBox1;
        private Label label6;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnAgregar;
        private PictureBox pbxImagen;
        private ComboBox cbxTipo;
        private Label label2;
        private TextBox txtCorreo;
        private Label label1;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtUsuarioId;
        private Label label5;
        private Button button1;
    }
}