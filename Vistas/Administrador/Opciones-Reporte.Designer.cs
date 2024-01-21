namespace Inventario_residencias.Vistas.Administrador
{
    partial class Opciones_Reporte
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
            groupBox1 = new GroupBox();
            rbtnTablero = new RadioButton();
            rbtnGeneral = new RadioButton();
            panel1 = new Panel();
            label6 = new Label();
            chbxTablero = new CheckBox();
            chbxFechaG = new CheckBox();
            chbxExistenciaG = new CheckBox();
            chbxUbicacionG = new CheckBox();
            chbxFilaG = new CheckBox();
            chbxColumnaG = new CheckBox();
            chbxDescripcionG = new CheckBox();
            chbxNumeroFG = new CheckBox();
            btnReporteGeneral = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            chbxFechaT = new CheckBox();
            chbxExistenciaT = new CheckBox();
            chbxUbicacionT = new CheckBox();
            chbxFilaT = new CheckBox();
            chbxColumnaT = new CheckBox();
            chbxDescripcionT = new CheckBox();
            chbxNumeroFT = new CheckBox();
            label4 = new Label();
            cbxTablero = new ComboBox();
            tableroBindingSource = new BindingSource(components);
            btnReporteTablero = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableroBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 22);
            label1.TabIndex = 0;
            label1.Text = "Opciones para generar reporte";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnTablero);
            groupBox1.Controls.Add(rbtnGeneral);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(24, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 50);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione el tipo de reporte";
            // 
            // rbtnTablero
            // 
            rbtnTablero.AutoSize = true;
            rbtnTablero.Location = new Point(103, 22);
            rbtnTablero.Name = "rbtnTablero";
            rbtnTablero.Size = new Size(63, 19);
            rbtnTablero.TabIndex = 1;
            rbtnTablero.Text = "Tablero";
            rbtnTablero.UseVisualStyleBackColor = true;
            rbtnTablero.CheckedChanged += rbtnTablero_CheckedChanged;
            // 
            // rbtnGeneral
            // 
            rbtnGeneral.AutoSize = true;
            rbtnGeneral.Checked = true;
            rbtnGeneral.Location = new Point(6, 22);
            rbtnGeneral.Name = "rbtnGeneral";
            rbtnGeneral.Size = new Size(65, 19);
            rbtnGeneral.TabIndex = 0;
            rbtnGeneral.TabStop = true;
            rbtnGeneral.Text = "General";
            rbtnGeneral.UseVisualStyleBackColor = true;
            rbtnGeneral.CheckedChanged += rbtnGeneral_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(chbxTablero);
            panel1.Controls.Add(chbxFechaG);
            panel1.Controls.Add(chbxExistenciaG);
            panel1.Controls.Add(chbxUbicacionG);
            panel1.Controls.Add(chbxFilaG);
            panel1.Controls.Add(chbxColumnaG);
            panel1.Controls.Add(chbxDescripcionG);
            panel1.Controls.Add(chbxNumeroFG);
            panel1.Controls.Add(btnReporteGeneral);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 242);
            panel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 43);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 19;
            label6.Text = "Contenido";
            // 
            // chbxTablero
            // 
            chbxTablero.AutoSize = true;
            chbxTablero.Checked = true;
            chbxTablero.CheckState = CheckState.Checked;
            chbxTablero.Location = new Point(26, 95);
            chbxTablero.Name = "chbxTablero";
            chbxTablero.Size = new Size(64, 19);
            chbxTablero.TabIndex = 18;
            chbxTablero.Text = "Tablero";
            chbxTablero.UseVisualStyleBackColor = true;
            // 
            // chbxFechaG
            // 
            chbxFechaG.AutoSize = true;
            chbxFechaG.Checked = true;
            chbxFechaG.CheckState = CheckState.Checked;
            chbxFechaG.Location = new Point(135, 145);
            chbxFechaG.Name = "chbxFechaG";
            chbxFechaG.Size = new Size(103, 19);
            chbxFechaG.TabIndex = 17;
            chbxFechaG.Text = "Fecha Compra";
            chbxFechaG.UseVisualStyleBackColor = true;
            // 
            // chbxExistenciaG
            // 
            chbxExistenciaG.AutoSize = true;
            chbxExistenciaG.Checked = true;
            chbxExistenciaG.CheckState = CheckState.Checked;
            chbxExistenciaG.Location = new Point(135, 120);
            chbxExistenciaG.Name = "chbxExistenciaG";
            chbxExistenciaG.Size = new Size(78, 19);
            chbxExistenciaG.TabIndex = 16;
            chbxExistenciaG.Text = "Existencia";
            chbxExistenciaG.UseVisualStyleBackColor = true;
            // 
            // chbxUbicacionG
            // 
            chbxUbicacionG.AutoSize = true;
            chbxUbicacionG.Checked = true;
            chbxUbicacionG.CheckState = CheckState.Checked;
            chbxUbicacionG.Location = new Point(26, 145);
            chbxUbicacionG.Name = "chbxUbicacionG";
            chbxUbicacionG.Size = new Size(79, 19);
            chbxUbicacionG.TabIndex = 15;
            chbxUbicacionG.Text = "Ubicación";
            chbxUbicacionG.UseVisualStyleBackColor = true;
            // 
            // chbxFilaG
            // 
            chbxFilaG.AutoSize = true;
            chbxFilaG.Checked = true;
            chbxFilaG.CheckState = CheckState.Checked;
            chbxFilaG.Location = new Point(26, 120);
            chbxFilaG.Name = "chbxFilaG";
            chbxFilaG.Size = new Size(44, 19);
            chbxFilaG.TabIndex = 14;
            chbxFilaG.Text = "Fila";
            chbxFilaG.UseVisualStyleBackColor = true;
            // 
            // chbxColumnaG
            // 
            chbxColumnaG.AutoSize = true;
            chbxColumnaG.Checked = true;
            chbxColumnaG.CheckState = CheckState.Checked;
            chbxColumnaG.Location = new Point(135, 95);
            chbxColumnaG.Name = "chbxColumnaG";
            chbxColumnaG.Size = new Size(75, 19);
            chbxColumnaG.TabIndex = 13;
            chbxColumnaG.Text = "Columna";
            chbxColumnaG.UseVisualStyleBackColor = true;
            // 
            // chbxDescripcionG
            // 
            chbxDescripcionG.AutoSize = true;
            chbxDescripcionG.Checked = true;
            chbxDescripcionG.CheckState = CheckState.Checked;
            chbxDescripcionG.Location = new Point(135, 70);
            chbxDescripcionG.Name = "chbxDescripcionG";
            chbxDescripcionG.Size = new Size(88, 19);
            chbxDescripcionG.TabIndex = 12;
            chbxDescripcionG.Text = "Descripción";
            chbxDescripcionG.UseVisualStyleBackColor = true;
            // 
            // chbxNumeroFG
            // 
            chbxNumeroFG.AutoSize = true;
            chbxNumeroFG.Checked = true;
            chbxNumeroFG.CheckState = CheckState.Checked;
            chbxNumeroFG.Location = new Point(26, 70);
            chbxNumeroFG.Name = "chbxNumeroFG";
            chbxNumeroFG.Size = new Size(103, 19);
            chbxNumeroFG.TabIndex = 11;
            chbxNumeroFG.Text = "Numero Fisico";
            chbxNumeroFG.UseVisualStyleBackColor = true;
            // 
            // btnReporteGeneral
            // 
            btnReporteGeneral.Location = new Point(51, 203);
            btnReporteGeneral.Name = "btnReporteGeneral";
            btnReporteGeneral.Size = new Size(114, 34);
            btnReporteGeneral.TabIndex = 2;
            btnReporteGeneral.Text = "Generar Reporte";
            btnReporteGeneral.UseVisualStyleBackColor = true;
            btnReporteGeneral.Click += btnReporteGeneral_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 13);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 0;
            label2.Text = "General";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(chbxFechaT);
            panel2.Controls.Add(chbxExistenciaT);
            panel2.Controls.Add(chbxUbicacionT);
            panel2.Controls.Add(chbxFilaT);
            panel2.Controls.Add(chbxColumnaT);
            panel2.Controls.Add(chbxDescripcionT);
            panel2.Controls.Add(chbxNumeroFT);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cbxTablero);
            panel2.Controls.Add(btnReporteTablero);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(289, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 242);
            panel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 70);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 11;
            label5.Text = "Contenido";
            // 
            // chbxFechaT
            // 
            chbxFechaT.AutoSize = true;
            chbxFechaT.Checked = true;
            chbxFechaT.CheckState = CheckState.Checked;
            chbxFechaT.Location = new Point(18, 170);
            chbxFechaT.Name = "chbxFechaT";
            chbxFechaT.Size = new Size(103, 19);
            chbxFechaT.TabIndex = 10;
            chbxFechaT.Text = "Fecha Compra";
            chbxFechaT.UseVisualStyleBackColor = true;
            // 
            // chbxExistenciaT
            // 
            chbxExistenciaT.AutoSize = true;
            chbxExistenciaT.Checked = true;
            chbxExistenciaT.CheckState = CheckState.Checked;
            chbxExistenciaT.Location = new Point(127, 145);
            chbxExistenciaT.Name = "chbxExistenciaT";
            chbxExistenciaT.Size = new Size(78, 19);
            chbxExistenciaT.TabIndex = 9;
            chbxExistenciaT.Text = "Existencia";
            chbxExistenciaT.UseVisualStyleBackColor = true;
            // 
            // chbxUbicacionT
            // 
            chbxUbicacionT.AutoSize = true;
            chbxUbicacionT.Checked = true;
            chbxUbicacionT.CheckState = CheckState.Checked;
            chbxUbicacionT.Location = new Point(18, 145);
            chbxUbicacionT.Name = "chbxUbicacionT";
            chbxUbicacionT.Size = new Size(79, 19);
            chbxUbicacionT.TabIndex = 8;
            chbxUbicacionT.Text = "Ubicación";
            chbxUbicacionT.UseVisualStyleBackColor = true;
            // 
            // chbxFilaT
            // 
            chbxFilaT.AutoSize = true;
            chbxFilaT.Checked = true;
            chbxFilaT.CheckState = CheckState.Checked;
            chbxFilaT.Location = new Point(127, 120);
            chbxFilaT.Name = "chbxFilaT";
            chbxFilaT.Size = new Size(44, 19);
            chbxFilaT.TabIndex = 7;
            chbxFilaT.Text = "Fila";
            chbxFilaT.UseVisualStyleBackColor = true;
            // 
            // chbxColumnaT
            // 
            chbxColumnaT.AutoSize = true;
            chbxColumnaT.Checked = true;
            chbxColumnaT.CheckState = CheckState.Checked;
            chbxColumnaT.Location = new Point(18, 120);
            chbxColumnaT.Name = "chbxColumnaT";
            chbxColumnaT.Size = new Size(75, 19);
            chbxColumnaT.TabIndex = 6;
            chbxColumnaT.Text = "Columna";
            chbxColumnaT.UseVisualStyleBackColor = true;
            // 
            // chbxDescripcionT
            // 
            chbxDescripcionT.AutoSize = true;
            chbxDescripcionT.Checked = true;
            chbxDescripcionT.CheckState = CheckState.Checked;
            chbxDescripcionT.Location = new Point(127, 95);
            chbxDescripcionT.Name = "chbxDescripcionT";
            chbxDescripcionT.Size = new Size(88, 19);
            chbxDescripcionT.TabIndex = 5;
            chbxDescripcionT.Text = "Descripción";
            chbxDescripcionT.UseVisualStyleBackColor = true;
            // 
            // chbxNumeroFT
            // 
            chbxNumeroFT.AutoSize = true;
            chbxNumeroFT.Checked = true;
            chbxNumeroFT.CheckState = CheckState.Checked;
            chbxNumeroFT.Location = new Point(18, 95);
            chbxNumeroFT.Name = "chbxNumeroFT";
            chbxNumeroFT.Size = new Size(103, 19);
            chbxNumeroFT.TabIndex = 4;
            chbxNumeroFT.Text = "Numero Fisico";
            chbxNumeroFT.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 41);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 3;
            label4.Text = "Tablero:";
            // 
            // cbxTablero
            // 
            cbxTablero.DataSource = tableroBindingSource;
            cbxTablero.DisplayMember = "tablero";
            cbxTablero.FormattingEnabled = true;
            cbxTablero.Location = new Point(93, 40);
            cbxTablero.Name = "cbxTablero";
            cbxTablero.Size = new Size(121, 23);
            cbxTablero.TabIndex = 2;
            cbxTablero.ValueMember = "tableroId";
            // 
            // tableroBindingSource
            // 
            tableroBindingSource.DataSource = typeof(Modelos.Tablero);
            // 
            // btnReporteTablero
            // 
            btnReporteTablero.Location = new Point(65, 203);
            btnReporteTablero.Name = "btnReporteTablero";
            btnReporteTablero.Size = new Size(114, 34);
            btnReporteTablero.TabIndex = 1;
            btnReporteTablero.Text = "Generar Reporte";
            btnReporteTablero.UseVisualStyleBackColor = true;
            btnReporteTablero.Click += btnReporteTablero_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(89, 13);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 0;
            label3.Text = "Tablero";
            // 
            // Opciones_Reporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(542, 344);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(558, 383);
            MinimizeBox = false;
            MinimumSize = new Size(558, 383);
            Name = "Opciones_Reporte";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opciones_Reporte";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableroBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtnTablero;
        private RadioButton rbtnGeneral;
        private Panel panel1;
        private Button btnReporteGeneral;
        private Label label2;
        private Panel panel2;
        private Button btnReporteTablero;
        private Label label3;
        private CheckBox chbxDescripcionT;
        private CheckBox chbxNumeroFT;
        private Label label4;
        private ComboBox cbxTablero;
        private BindingSource tableroBindingSource;
        private CheckBox chbxTablero;
        private CheckBox chbxFechaG;
        private CheckBox chbxExistenciaG;
        private CheckBox chbxUbicacionG;
        private CheckBox chbxFilaG;
        private CheckBox chbxColumnaG;
        private CheckBox chbxDescripcionG;
        private CheckBox chbxNumeroFG;
        private CheckBox chbxFechaT;
        private CheckBox chbxExistenciaT;
        private CheckBox chbxUbicacionT;
        private CheckBox chbxFilaT;
        private CheckBox chbxColumnaT;
        private Label label6;
        private Label label5;
    }
}