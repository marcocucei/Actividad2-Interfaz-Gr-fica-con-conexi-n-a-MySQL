namespace MySQLConexion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtHost = new TextBox();
            txtBaseDeDatos = new TextBox();
            txtPuerto = new TextBox();
            btnConector = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(119, 70);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(187, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(119, 99);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(187, 23);
            txtContrasena.TabIndex = 1;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(119, 128);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(187, 23);
            txtHost.TabIndex = 2;
            // 
            // txtBaseDeDatos
            // 
            txtBaseDeDatos.Location = new Point(119, 157);
            txtBaseDeDatos.Name = "txtBaseDeDatos";
            txtBaseDeDatos.Size = new Size(187, 23);
            txtBaseDeDatos.TabIndex = 3;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(119, 186);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(187, 23);
            txtPuerto.TabIndex = 4;
            // 
            // btnConector
            // 
            btnConector.BackColor = Color.Gainsboro;
            btnConector.Location = new Point(211, 215);
            btnConector.Name = "btnConector";
            btnConector.Size = new Size(95, 26);
            btnConector.TabIndex = 5;
            btnConector.Text = "Conectar";
            btnConector.UseVisualStyleBackColor = false;
            btnConector.Click += btnConector_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 73);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "Usuario:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 107);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 7;
            label2.Text = "Contraseña:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(78, 136);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Host:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 165);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 9;
            label4.Text = "Base de Datos:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(68, 194);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Puerto:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(30, 23);
            label6.Name = "label6";
            label6.Size = new Size(276, 35);
            label6.TabIndex = 11;
            label6.Text = "Conexión a MySQL";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = Color.Black;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(323, 23);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(539, 218);
            dgvDatos.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(885, 260);
            Controls.Add(dgvDatos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConector);
            Controls.Add(txtPuerto);
            Controls.Add(txtBaseDeDatos);
            Controls.Add(txtHost);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Name = "Form1";
            Text = "MarcoHdez";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txtHost;
        private TextBox txtBaseDeDatos;
        private TextBox txtPuerto;
        private Button btnConector;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvDatos;
    }
}