namespace WindowsForms
{
    partial class AdministrarUsuario
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
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            btonBuscar = new Button();
            cboxUsuario = new ComboBox();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtPassword = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            cBoxRol = new ComboBox();
            cBoxLocalidad = new ComboBox();
            txtEmail = new TextBox();
            btonAdministrar = new Button();
            btonVolver = new Button();
            btonEliminar = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            menuStrip1.Size = new Size(160, 450);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconMenuItem1.IconColor = Color.White;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 50;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Margin = new Padding(0, 150, 0, 0);
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(153, 54);
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(160, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 46);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 0;
            label1.Text = "Administrar Usuarios";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(160, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 56);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2326336F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.7673645F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(btonBuscar, 2, 0);
            tableLayoutPanel1.Controls.Add(cboxUsuario, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(640, 56);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 0;
            label2.Text = "Ingresar ID Usuario:";
            // 
            // btonBuscar
            // 
            btonBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btonBuscar.Location = new Point(508, 16);
            btonBuscar.Name = "btonBuscar";
            btonBuscar.Size = new Size(129, 23);
            btonBuscar.TabIndex = 2;
            btonBuscar.Text = "Buscar";
            btonBuscar.UseVisualStyleBackColor = true;
            btonBuscar.Click += btonBuscar_Click;
            // 
            // cboxUsuario
            // 
            cboxUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboxUsuario.FormattingEnabled = true;
            cboxUsuario.Location = new Point(125, 16);
            cboxUsuario.Name = "cboxUsuario";
            cboxUsuario.Size = new Size(377, 23);
            cboxUsuario.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(160, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(640, 303);
            panel3.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(txtPassword, 1, 3);
            tableLayoutPanel2.Controls.Add(txtDireccion, 1, 2);
            tableLayoutPanel2.Controls.Add(txtTelefono, 1, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label8, 0, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 5);
            tableLayoutPanel2.Controls.Add(cBoxRol, 1, 4);
            tableLayoutPanel2.Controls.Add(cBoxLocalidad, 1, 5);
            tableLayoutPanel2.Controls.Add(txtEmail, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(640, 303);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(323, 163);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Ingrese su Contraseña";
            txtPassword.Size = new Size(314, 23);
            txtPassword.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Location = new Point(323, 113);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese su Direccion";
            txtDireccion.Size = new Size(314, 23);
            txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(323, 63);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese su Telefono";
            txtTelefono.Size = new Size(314, 23);
            txtTelefono.TabIndex = 9;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 117);
            label7.Name = "label7";
            label7.Size = new Size(314, 15);
            label7.TabIndex = 4;
            label7.Text = "Direccion:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 67);
            label5.Name = "label5";
            label5.Size = new Size(314, 15);
            label5.TabIndex = 2;
            label5.Text = "Telefono:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 17);
            label3.Name = "label3";
            label3.Size = new Size(314, 15);
            label3.TabIndex = 0;
            label3.Text = "Email:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 167);
            label8.Name = "label8";
            label8.Size = new Size(314, 15);
            label8.TabIndex = 5;
            label8.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 217);
            label6.Name = "label6";
            label6.Size = new Size(314, 15);
            label6.TabIndex = 3;
            label6.Text = "Rol ID:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 269);
            label4.Name = "label4";
            label4.Size = new Size(314, 15);
            label4.TabIndex = 1;
            label4.Text = "Localidad ID:";
            // 
            // cBoxRol
            // 
            cBoxRol.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBoxRol.FormattingEnabled = true;
            cBoxRol.Location = new Point(323, 213);
            cBoxRol.Name = "cBoxRol";
            cBoxRol.Size = new Size(314, 23);
            cBoxRol.TabIndex = 6;
            // 
            // cBoxLocalidad
            // 
            cBoxLocalidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBoxLocalidad.FormattingEnabled = true;
            cBoxLocalidad.Location = new Point(323, 265);
            cBoxLocalidad.Name = "cBoxLocalidad";
            cBoxLocalidad.Size = new Size(314, 23);
            cBoxLocalidad.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(323, 13);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese su Email";
            txtEmail.Size = new Size(314, 23);
            txtEmail.TabIndex = 8;
            // 
            // btonAdministrar
            // 
            btonAdministrar.Location = new Point(703, 422);
            btonAdministrar.Name = "btonAdministrar";
            btonAdministrar.Size = new Size(85, 23);
            btonAdministrar.TabIndex = 5;
            btonAdministrar.Text = "Editar";
            btonAdministrar.UseVisualStyleBackColor = true;
            btonAdministrar.Click += btonAdministrar_Click;
            // 
            // btonVolver
            // 
            btonVolver.Location = new Point(174, 422);
            btonVolver.Name = "btonVolver";
            btonVolver.Size = new Size(75, 23);
            btonVolver.TabIndex = 6;
            btonVolver.Text = "Volver";
            btonVolver.UseVisualStyleBackColor = true;
            btonVolver.Click += btonVolver_Click;
            // 
            // btonEliminar
            // 
            btonEliminar.Location = new Point(622, 422);
            btonEliminar.Name = "btonEliminar";
            btonEliminar.Size = new Size(75, 23);
            btonEliminar.TabIndex = 7;
            btonEliminar.Text = "Eliminar";
            btonEliminar.UseVisualStyleBackColor = true;
            btonEliminar.Click += btonEliminar_Click;
            // 
            // AdministrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btonEliminar);
            Controls.Add(btonVolver);
            Controls.Add(btonAdministrar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "AdministrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar Usuario";
            Load += AdministrarUsuario_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button btonBuscar;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label8;
        private Label label6;
        private Label label4;
        private ComboBox cBoxRol;
        private ComboBox cBoxLocalidad;
        private TextBox txtPassword;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button btonAdministrar;
        private Button btonVolver;
        private Button btonEliminar;
        private ComboBox cboxUsuario;
    }
}