namespace Inventario_residencias.Vistas.Administrador
{
    partial class ModificarItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarItem));
            cbxFila = new ComboBox();
            cbxColumna = new ComboBox();
            cbxTablero = new ComboBox();
            tableroBindingSource = new BindingSource(components);
            label9 = new Label();
            pbxImagen = new PictureBox();
            btnGuardar = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtNumeroFisico = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableroBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // cbxFila
            // 
            cbxFila.Cursor = Cursors.Hand;
            cbxFila.DropDownHeight = 60;
            cbxFila.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFila.FormattingEnabled = true;
            cbxFila.IntegralHeight = false;
            cbxFila.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbxFila.Location = new Point(27, 403);
            cbxFila.MaxDropDownItems = 6;
            cbxFila.Name = "cbxFila";
            cbxFila.Size = new Size(206, 25);
            cbxFila.TabIndex = 34;
            cbxFila.Text = "-----Seleccione-----";
            // 
            // cbxColumna
            // 
            cbxColumna.Cursor = Cursors.Hand;
            cbxColumna.DropDownHeight = 60;
            cbxColumna.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxColumna.FormattingEnabled = true;
            cbxColumna.IntegralHeight = false;
            cbxColumna.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            cbxColumna.Location = new Point(27, 325);
            cbxColumna.MaxDropDownItems = 6;
            cbxColumna.Name = "cbxColumna";
            cbxColumna.Size = new Size(206, 25);
            cbxColumna.TabIndex = 33;
            cbxColumna.Text = "-----Seleccione-----";
            // 
            // cbxTablero
            // 
            cbxTablero.Cursor = Cursors.Hand;
            cbxTablero.DataSource = tableroBindingSource;
            cbxTablero.DisplayMember = "tablero";
            cbxTablero.DropDownHeight = 60;
            cbxTablero.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTablero.FormattingEnabled = true;
            cbxTablero.IntegralHeight = false;
            cbxTablero.Location = new Point(27, 251);
            cbxTablero.MaxDropDownItems = 6;
            cbxTablero.Name = "cbxTablero";
            cbxTablero.Size = new Size(206, 25);
            cbxTablero.TabIndex = 32;
            cbxTablero.ValueMember = "tableroId";
            // 
            // tableroBindingSource
            // 
            tableroBindingSource.DataSource = typeof(Modelos.Tablero);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(391, 80);
            label9.Name = "label9";
            label9.Size = new Size(136, 15);
            label9.TabIndex = 31;
            label9.Text = "click para cargar imagen";
            // 
            // pbxImagen
            // 
            pbxImagen.BackColor = SystemColors.ButtonFace;
            pbxImagen.Location = new Point(299, 108);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(271, 242);
            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagen.TabIndex = 30;
            pbxImagen.TabStop = false;
            pbxImagen.Click += pbxImagen_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(299, 392);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(271, 36);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(299, 71);
            label8.Name = "label8";
            label8.Size = new Size(86, 24);
            label8.TabIndex = 28;
            label8.Text = "Imagen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(27, 370);
            label7.Name = "label7";
            label7.Size = new Size(47, 24);
            label7.TabIndex = 27;
            label7.Text = "Fila";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 292);
            label6.Name = "label6";
            label6.Size = new Size(102, 24);
            label6.TabIndex = 26;
            label6.Text = "Columna";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 218);
            label5.Name = "label5";
            label5.Size = new Size(88, 24);
            label5.TabIndex = 25;
            label5.Text = "Tablero";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(27, 181);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(206, 23);
            txtDescripcion.TabIndex = 24;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 144);
            label3.Name = "label3";
            label3.Size = new Size(133, 24);
            label3.TabIndex = 23;
            label3.Text = "Descripcion";
            // 
            // txtNumeroFisico
            // 
            txtNumeroFisico.Enabled = false;
            txtNumeroFisico.Location = new Point(27, 108);
            txtNumeroFisico.Name = "txtNumeroFisico";
            txtNumeroFisico.Size = new Size(206, 23);
            txtNumeroFisico.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 71);
            label2.Name = "label2";
            label2.Size = new Size(158, 24);
            label2.TabIndex = 21;
            label2.Text = "Numero Fisico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 19);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 35;
            label1.Text = "Modificar Item";
            // 
            // ModificarItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(595, 450);
            Controls.Add(label1);
            Controls.Add(cbxFila);
            Controls.Add(cbxColumna);
            Controls.Add(cbxTablero);
            Controls.Add(label9);
            Controls.Add(pbxImagen);
            Controls.Add(btnGuardar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtNumeroFisico);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(611, 489);
            MinimizeBox = false;
            MinimumSize = new Size(611, 489);
            Name = "ModificarItem";
            RightToLeftLayout = true;
            Text = "ModificarItem";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)tableroBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxFila;
        private ComboBox cbxColumna;
        private ComboBox cbxTablero;
        private Label label9;
        private PictureBox pbxImagen;
        private Button btnGuardar;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtNumeroFisico;
        private Label label2;
        private Label label1;
        private BindingSource tableroBindingSource;
    }
}