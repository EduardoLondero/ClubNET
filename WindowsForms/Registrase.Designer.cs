namespace WindowsForms
{
    partial class Registrase
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
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btonRegistrar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtContraseña = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtEmail = new TextBox();
            txtLocalidad = new TextBox();
            label11 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label13 = new Label();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label12 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label15 = new Label();
            label14 = new Label();
            dgvProvincia = new DataGridView();
            dgvLocalidad = new DataGridView();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProvincia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocalidad).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(144, 605);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Computer;
            iconMenuItem1.IconColor = Color.White;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 50;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Margin = new Padding(5, 180, 5, 5);
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(181, 54);
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(144, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 38);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 3);
            label1.Name = "label1";
            label1.Size = new Size(343, 32);
            label1.TabIndex = 1;
            label1.Text = "Ingrese sus Datos";
            // 
            // panel3
            // 
            panel3.Controls.Add(btonRegistrar);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(144, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(773, 298);
            panel3.TabIndex = 6;
            // 
            // btonRegistrar
            // 
            btonRegistrar.Location = new Point(613, 264);
            btonRegistrar.Name = "btonRegistrar";
            btonRegistrar.Size = new Size(75, 23);
            btonRegistrar.TabIndex = 6;
            btonRegistrar.Text = "Registrar";
            btonRegistrar.UseVisualStyleBackColor = true;
            btonRegistrar.Click += btonRegistrar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.54004F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.45996F));
            tableLayoutPanel1.Controls.Add(txtContraseña, 1, 3);
            tableLayoutPanel1.Controls.Add(txtDireccion, 1, 2);
            tableLayoutPanel1.Controls.Add(txtTelefono, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 0);
            tableLayoutPanel1.Controls.Add(txtLocalidad, 1, 4);
            tableLayoutPanel1.Controls.Add(label11, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(537, 298);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtContraseña.Location = new Point(167, 195);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(367, 23);
            txtContraseña.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Location = new Point(167, 136);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(367, 23);
            txtDireccion.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(167, 77);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(367, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(158, 32);
            label6.TabIndex = 1;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 72);
            label7.Name = "label7";
            label7.Size = new Size(158, 32);
            label7.TabIndex = 2;
            label7.Text = "Telefono:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 131);
            label8.Name = "label8";
            label8.Size = new Size(158, 32);
            label8.TabIndex = 3;
            label8.Text = "Direccion:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 190);
            label9.Name = "label9";
            label9.Size = new Size(158, 32);
            label9.TabIndex = 4;
            label9.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(167, 18);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(367, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLocalidad.Location = new Point(167, 255);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(367, 23);
            txtLocalidad.TabIndex = 12;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 251);
            label11.Name = "label11";
            label11.Size = new Size(158, 32);
            label11.TabIndex = 11;
            label11.Text = "Id Localidad";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 199);
            label4.Name = "label4";
            label4.Size = new Size(343, 60);
            label4.TabIndex = 3;
            label4.Text = "Datos Actuales";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 132);
            label3.Name = "label3";
            label3.Size = new Size(343, 60);
            label3.TabIndex = 2;
            label3.Text = "Datos Actuales";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 71);
            label2.Name = "label2";
            label2.Size = new Size(297, 60);
            label2.TabIndex = 1;
            label2.Text = "Datos Actuales";
            // 
            // panel4
            // 
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(144, 336);
            panel4.Name = "panel4";
            panel4.Size = new Size(773, 39);
            panel4.TabIndex = 8;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label13.Location = new Point(191, 4);
            label13.Name = "label13";
            label13.Size = new Size(427, 32);
            label13.TabIndex = 3;
            label13.Text = "Datos Localidad y Provincia";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(191, 3);
            label5.Name = "label5";
            label5.Size = new Size(369, 0);
            label5.TabIndex = 2;
            label5.Text = "Datos Localidades";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.54004F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.45996F));
            tableLayoutPanel2.Controls.Add(label12, 0, 5);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 100);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 11;
            label12.Text = "Id Localidad";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(64, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(144, 375);
            panel2.Name = "panel2";
            panel2.Size = new Size(773, 230);
            panel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6229515F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.37705F));
            tableLayoutPanel3.Controls.Add(label15, 0, 1);
            tableLayoutPanel3.Controls.Add(label14, 0, 0);
            tableLayoutPanel3.Controls.Add(dgvProvincia, 1, 0);
            tableLayoutPanel3.Controls.Add(dgvLocalidad, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(773, 230);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 156);
            label15.Name = "label15";
            label15.Size = new Size(130, 32);
            label15.TabIndex = 5;
            label15.Text = "Localidad";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 41);
            label14.Name = "label14";
            label14.Size = new Size(130, 32);
            label14.TabIndex = 4;
            label14.Text = "Provincia";
            // 
            // dgvProvincia
            // 
            dgvProvincia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProvincia.Dock = DockStyle.Fill;
            dgvProvincia.Location = new Point(139, 3);
            dgvProvincia.Name = "dgvProvincia";
            dgvProvincia.Size = new Size(631, 109);
            dgvProvincia.TabIndex = 6;
            // 
            // dgvLocalidad
            // 
            dgvLocalidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalidad.Dock = DockStyle.Fill;
            dgvLocalidad.Location = new Point(139, 118);
            dgvLocalidad.Name = "dgvLocalidad";
            dgvLocalidad.Size = new Size(631, 109);
            dgvLocalidad.TabIndex = 7;
            // 
            // Registrase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 605);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MinimizeBox = false;
            Name = "Registrase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProvincia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocalidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtContraseña;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label label9;
        private TextBox txtEmail;
        private Panel panel4;
        private Label label5;
        private TextBox txtLocalidad;
        private Label label11;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label12;
        private TextBox textBox1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label15;
        private Label label14;
        private DataGridView dgvProvincia;
        private DataGridView dgvLocalidad;
        private Button btonRegistrar;
    }
}