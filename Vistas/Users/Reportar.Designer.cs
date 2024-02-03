namespace Inventario_residencias.Vistas.Users
{
    partial class Reportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportar));
            label1 = new Label();
            lblNumeroFisico = new Label();
            label3 = new Label();
            txtAsunto = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            btnReportar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 22);
            label1.Name = "label1";
            label1.Size = new Size(269, 18);
            label1.TabIndex = 0;
            label1.Text = "Reportar Item con numero fisico:";
            // 
            // lblNumeroFisico
            // 
            lblNumeroFisico.AutoSize = true;
            lblNumeroFisico.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroFisico.Location = new Point(321, 22);
            lblNumeroFisico.Name = "lblNumeroFisico";
            lblNumeroFisico.Size = new Size(56, 18);
            lblNumeroFisico.TabIndex = 1;
            lblNumeroFisico.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(78, 59);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 2;
            label3.Text = "Titulo";
            // 
            // txtAsunto
            // 
            txtAsunto.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAsunto.Location = new Point(78, 90);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.PlaceholderText = "Ejem. Faltan Herramientas";
            txtAsunto.Size = new Size(331, 26);
            txtAsunto.TabIndex = 3;
            txtAsunto.KeyPress += txtAsunto_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 134);
            label4.Name = "label4";
            label4.Size = new Size(104, 18);
            label4.TabIndex = 4;
            label4.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(78, 166);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ejem. No se encontro presencia de la herramienta";
            txtDescripcion.Size = new Size(327, 96);
            txtDescripcion.TabIndex = 5;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // btnReportar
            // 
            btnReportar.BackColor = Color.MediumSeaGreen;
            btnReportar.FlatAppearance.BorderColor = Color.Black;
            btnReportar.FlatAppearance.BorderSize = 2;
            btnReportar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnReportar.FlatStyle = FlatStyle.Flat;
            btnReportar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportar.Location = new Point(147, 285);
            btnReportar.Name = "btnReportar";
            btnReportar.Size = new Size(178, 34);
            btnReportar.TabIndex = 6;
            btnReportar.Text = "Enviar";
            btnReportar.UseVisualStyleBackColor = false;
            btnReportar.Click += btnReportar_Click;
            // 
            // Reportar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(498, 341);
            Controls.Add(btnReportar);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(txtAsunto);
            Controls.Add(label3);
            Controls.Add(lblNumeroFisico);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(514, 380);
            MinimizeBox = false;
            MinimumSize = new Size(514, 380);
            Name = "Reportar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportar";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNumeroFisico;
        private Label label3;
        private TextBox txtAsunto;
        private Label label4;
        private TextBox txtDescripcion;
        private Button btnReportar;
    }
}