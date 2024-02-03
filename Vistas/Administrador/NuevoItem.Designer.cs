namespace Inventario_residencias
{
    partial class NuevoItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoItem));
            label1 = new Label();
            label2 = new Label();
            txtNumeroFisico = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnGuardar = new Button();
            pbxImagen = new PictureBox();
            label9 = new Label();
            cbxTablero = new ComboBox();
            tableroBindingSource = new BindingSource(components);
            cbxColumna = new ComboBox();
            cbxFila = new ComboBox();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableroBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 0;
            label1.Text = "Agregar Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 49);
            label2.Name = "label2";
            label2.Size = new Size(158, 24);
            label2.TabIndex = 1;
            label2.Text = "Numero Fisico";
            // 
            // txtNumeroFisico
            // 
            txtNumeroFisico.Location = new Point(29, 76);
            txtNumeroFisico.Name = "txtNumeroFisico";
            txtNumeroFisico.Size = new Size(206, 23);
            txtNumeroFisico.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 111);
            label3.Name = "label3";
            label3.Size = new Size(133, 24);
            label3.TabIndex = 3;
            label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(29, 138);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(206, 23);
            txtDescripcion.TabIndex = 4;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 175);
            label5.Name = "label5";
            label5.Size = new Size(88, 24);
            label5.TabIndex = 7;
            label5.Text = "Tablero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 243);
            label6.Name = "label6";
            label6.Size = new Size(102, 24);
            label6.TabIndex = 9;
            label6.Text = "Columna";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 313);
            label7.Name = "label7";
            label7.Size = new Size(47, 24);
            label7.TabIndex = 11;
            label7.Text = "Fila";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(301, 48);
            label8.Name = "label8";
            label8.Size = new Size(86, 24);
            label8.TabIndex = 13;
            label8.Text = "Imagen";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(301, 387);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(271, 36);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pbxImagen
            // 
            pbxImagen.BackColor = SystemColors.ButtonFace;
            pbxImagen.Location = new Point(301, 85);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(271, 242);
            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagen.TabIndex = 16;
            pbxImagen.TabStop = false;
            pbxImagen.Click += pbxImagen_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(393, 57);
            label9.Name = "label9";
            label9.Size = new Size(136, 15);
            label9.TabIndex = 17;
            label9.Text = "click para cargar imagen";
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
            cbxTablero.Location = new Point(29, 202);
            cbxTablero.MaxDropDownItems = 6;
            cbxTablero.Name = "cbxTablero";
            cbxTablero.Size = new Size(206, 25);
            cbxTablero.TabIndex = 18;
            cbxTablero.ValueMember = "tableroId";
            // 
            // tableroBindingSource
            // 
            tableroBindingSource.DataSource = typeof(Modelos.Tablero);
            // 
            // cbxColumna
            // 
            cbxColumna.Cursor = Cursors.Hand;
            cbxColumna.DropDownHeight = 60;
            cbxColumna.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxColumna.FormattingEnabled = true;
            cbxColumna.IntegralHeight = false;
            cbxColumna.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            cbxColumna.Location = new Point(29, 270);
            cbxColumna.MaxDropDownItems = 6;
            cbxColumna.Name = "cbxColumna";
            cbxColumna.Size = new Size(206, 25);
            cbxColumna.TabIndex = 19;
            cbxColumna.Text = "-----Seleccione-----";
            // 
            // cbxFila
            // 
            cbxFila.Cursor = Cursors.Hand;
            cbxFila.DropDownHeight = 60;
            cbxFila.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFila.FormattingEnabled = true;
            cbxFila.IntegralHeight = false;
            cbxFila.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbxFila.Location = new Point(29, 340);
            cbxFila.MaxDropDownItems = 6;
            cbxFila.Name = "cbxFila";
            cbxFila.Size = new Size(206, 25);
            cbxFila.TabIndex = 20;
            cbxFila.Text = "-----Seleccione-----";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(29, 415);
            dtpFecha.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(206, 23);
            dtpFecha.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 387);
            label4.Name = "label4";
            label4.Size = new Size(185, 24);
            label4.TabIndex = 22;
            label4.Text = "Fecha de compra";
            // 
            // NuevoItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(595, 450);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
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
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(611, 489);
            MinimizeBox = false;
            MinimumSize = new Size(611, 489);
            Name = "NuevoItem";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoItem";
            TopMost = true;
            Load += NuevoItem_Load;
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableroBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private TextBox txtNumeroFisico;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnGuardar;
        private PictureBox pbxImagen;
        private Label label9;
        private ComboBox cbxTablero;
        private ComboBox cbxColumna;
        private ComboBox cbxFila;
        private BindingSource tableroBindingSource;
        private DateTimePicker dtpFecha;
        private Label label4;
    }
}