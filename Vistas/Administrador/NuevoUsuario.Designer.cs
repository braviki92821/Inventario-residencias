namespace Inventario_residencias.Vistas.Administrador
{
    partial class NuevoUsuario
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
            txtCorreo = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            cbxTipo = new ComboBox();
            label3 = new Label();
            pbxImagen = new PictureBox();
            label5 = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 22);
            label1.Name = "label1";
            label1.Size = new Size(160, 24);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Usuario";
            // 
            // txtCorreo
            // 
            txtCorreo.CharacterCasing = CharacterCasing.Lower;
            txtCorreo.Location = new Point(23, 179);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(221, 23);
            txtCorreo.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 154);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 50;
            label2.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 49;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 79);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 48;
            label4.Text = "Nombre";
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Administrador", "Usuario" });
            cbxTipo.Location = new Point(23, 251);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(221, 23);
            cbxTipo.TabIndex = 53;
            cbxTipo.Text = "-----Seleccione-----";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 226);
            label3.Name = "label3";
            label3.Size = new Size(50, 22);
            label3.TabIndex = 52;
            label3.Text = "Tipo";
            // 
            // pbxImagen
            // 
            pbxImagen.BackColor = SystemColors.ButtonFace;
            pbxImagen.Location = new Point(328, 104);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(222, 170);
            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagen.TabIndex = 54;
            pbxImagen.TabStop = false;
            pbxImagen.Click += pbxImagen_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(328, 79);
            label5.Name = "label5";
            label5.Size = new Size(78, 22);
            label5.TabIndex = 55;
            label5.Text = "Imagen";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(332, 311);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(218, 34);
            btnGuardar.TabIndex = 56;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(595, 367);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(pbxImagen);
            Controls.Add(cbxTipo);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(611, 406);
            MinimizeBox = false;
            MinimumSize = new Size(611, 406);
            Name = "NuevoUsuario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoUsuario";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCorreo;
        private Label label2;
        private TextBox txtNombre;
        private Label label4;
        private ComboBox cbxTipo;
        private Label label3;
        private PictureBox pbxImagen;
        private Label label5;
        private Button btnGuardar;
    }
}