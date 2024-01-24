namespace Inventario_residencias.Vistas.Administrador
{
    partial class ModificarUsuario
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
            btnGuardar = new Button();
            label5 = new Label();
            pbxImagen = new PictureBox();
            cbxTipo = new ComboBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(336, 311);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(218, 34);
            btnGuardar.TabIndex = 63;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(332, 79);
            label5.Name = "label5";
            label5.Size = new Size(78, 22);
            label5.TabIndex = 62;
            label5.Text = "Imagen";
            // 
            // pbxImagen
            // 
            pbxImagen.BackColor = SystemColors.ButtonFace;
            pbxImagen.Location = new Point(332, 104);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(222, 170);
            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagen.TabIndex = 61;
            pbxImagen.TabStop = false;
            pbxImagen.Click += pbxImagen_Click;
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Administrador", "Usuario" });
            cbxTipo.Location = new Point(27, 294);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(221, 23);
            cbxTipo.TabIndex = 60;
            cbxTipo.Text = "-----Seleccione-----";
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(27, 231);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(221, 23);
            txtCorreo.TabIndex = 59;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 169);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(210, 22);
            label1.Name = "label1";
            label1.Size = new Size(190, 24);
            label1.TabIndex = 57;
            label1.Text = "Modificar Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 79);
            label2.Name = "label2";
            label2.Size = new Size(28, 22);
            label2.TabIndex = 66;
            label2.Text = "Id";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(27, 104);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(221, 23);
            txtUsuario.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 144);
            label3.Name = "label3";
            label3.Size = new Size(83, 22);
            label3.TabIndex = 67;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 206);
            label4.Name = "label4";
            label4.Size = new Size(73, 22);
            label4.TabIndex = 68;
            label4.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 269);
            label6.Name = "label6";
            label6.Size = new Size(50, 22);
            label6.TabIndex = 69;
            label6.Text = "Tipo";
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(595, 367);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(pbxImagen);
            Controls.Add(cbxTipo);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(611, 406);
            MinimizeBox = false;
            MinimumSize = new Size(611, 406);
            Name = "ModificarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarUsuario";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label5;
        private PictureBox pbxImagen;
        private ComboBox cbxTipo;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}