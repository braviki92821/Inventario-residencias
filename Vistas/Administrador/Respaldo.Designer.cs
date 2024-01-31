namespace Inventario_residencias.Vistas.Administrador
{
    partial class Respaldo
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnGenerarSql = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnCarga = new Button();
            label12 = new Label();
            btnGenerarJson = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(254, 24);
            label1.Name = "label1";
            label1.Size = new Size(288, 28);
            label1.TabIndex = 0;
            label1.Text = "Respaldo de base datos";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnGenerarSql);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 368);
            panel2.TabIndex = 1;
            // 
            // btnGenerarSql
            // 
            btnGenerarSql.BackColor = Color.ForestGreen;
            btnGenerarSql.FlatAppearance.BorderSize = 2;
            btnGenerarSql.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnGenerarSql.FlatStyle = FlatStyle.Flat;
            btnGenerarSql.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarSql.Location = new Point(88, 195);
            btnGenerarSql.Name = "btnGenerarSql";
            btnGenerarSql.Size = new Size(165, 38);
            btnGenerarSql.TabIndex = 5;
            btnGenerarSql.Text = "Generar copia";
            btnGenerarSql.UseVisualStyleBackColor = false;
            btnGenerarSql.Click += btnGenerarSql_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 157);
            label6.Name = "label6";
            label6.Size = new Size(356, 20);
            label6.TabIndex = 4;
            label6.Text = "3. Genere estos archivos de forma semanal o mensual";
            label6.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 118);
            label5.Name = "label5";
            label5.Size = new Size(328, 20);
            label5.TabIndex = 3;
            label5.Text = "2. Una vez generado  guardelo en un lugar seguro";
            label5.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 76);
            label4.Name = "label4";
            label4.Size = new Size(163, 15);
            label4.TabIndex = 2;
            label4.Text = "1. Genere el archivo .sql";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(157, 42);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 1;
            label3.Text = "Instrucciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 12);
            label2.Name = "label2";
            label2.Size = new Size(338, 17);
            label2.TabIndex = 0;
            label2.Text = "Crear copia de seguridad de la base de datos";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCarga);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(btnGenerarJson);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(397, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(403, 368);
            panel3.TabIndex = 2;
            // 
            // btnCarga
            // 
            btnCarga.BackColor = Color.ForestGreen;
            btnCarga.FlatAppearance.BorderSize = 2;
            btnCarga.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnCarga.FlatStyle = FlatStyle.Flat;
            btnCarga.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarga.Location = new Point(119, 298);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(165, 38);
            btnCarga.TabIndex = 11;
            btnCarga.Text = "Cargar archivo ";
            btnCarga.UseVisualStyleBackColor = false;
            btnCarga.Click += btnCarga_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(157, 260);
            label12.Name = "label12";
            label12.Size = new Size(95, 15);
            label12.TabIndex = 10;
            label12.Text = "Carga Masiva";
            // 
            // btnGenerarJson
            // 
            btnGenerarJson.BackColor = Color.ForestGreen;
            btnGenerarJson.FlatAppearance.BorderSize = 2;
            btnGenerarJson.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnGenerarJson.FlatStyle = FlatStyle.Flat;
            btnGenerarJson.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarJson.Location = new Point(119, 197);
            btnGenerarJson.Name = "btnGenerarJson";
            btnGenerarJson.Size = new Size(165, 38);
            btnGenerarJson.TabIndex = 9;
            btnGenerarJson.Text = "Generar copia";
            btnGenerarJson.UseVisualStyleBackColor = false;
            btnGenerarJson.Click += btnGenerarJson_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(24, 159);
            label8.Name = "label8";
            label8.Size = new Size(356, 20);
            label8.TabIndex = 8;
            label8.Text = "3. Genere estos archivos de forma semanal o mensual";
            label8.UseCompatibleTextRendering = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(24, 120);
            label9.Name = "label9";
            label9.Size = new Size(328, 20);
            label9.TabIndex = 7;
            label9.Text = "2. Una vez generado  guardelo en un lugar seguro";
            label9.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(24, 78);
            label10.Name = "label10";
            label10.Size = new Size(171, 15);
            label10.TabIndex = 6;
            label10.Text = "1. Genere el archivo .json";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(157, 44);
            label11.Name = "label11";
            label11.Size = new Size(96, 15);
            label11.TabIndex = 5;
            label11.Text = "Instrucciones";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(86, 14);
            label7.Name = "label7";
            label7.Size = new Size(230, 17);
            label7.TabIndex = 1;
            label7.Text = "Crear respaldo solo inventario";
            // 
            // Respaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(800, 450);
            MinimumSize = new Size(800, 450);
            Name = "Respaldo";
            Text = "Respaldo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Button btnGenerarSql;
        private Label label7;
        private Button btnCarga;
        private Label label12;
        private Button btnGenerarJson;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}