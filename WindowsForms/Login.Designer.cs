namespace WindowsForms
{
    partial class Login
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
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPass = new TextBox();
            registrarse = new Button();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label4 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 47);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 3;
            label1.Text = "Mail:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(145, 48);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese su email";
            txtEmail.Size = new Size(405, 23);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 166);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 5;
            label2.Text = "Contraseña:";
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPass.Location = new Point(145, 167);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Ingrese su contraseña";
            txtPass.Size = new Size(405, 23);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            // 
            // registrarse
            // 
            registrarse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            registrarse.Cursor = Cursors.Hand;
            registrarse.Location = new Point(160, 426);
            registrarse.Name = "registrarse";
            registrarse.Size = new Size(75, 53);
            registrarse.TabIndex = 7;
            registrarse.Text = "Registrarse";
            registrarse.UseVisualStyleBackColor = true;
            registrarse.Click += registrarse_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(340, 85);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 8;
            label3.Text = "Iniciar Sesion";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.67812F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.3218842F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtPass, 1, 1);
            tableLayoutPanel1.Location = new Point(126, 123);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(553, 297);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label4);
            panel2.ForeColor = Color.Black;
            panel2.ImeMode = ImeMode.On;
            panel2.Location = new Point(120, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 50);
            panel2.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(166, 9);
            label4.Name = "label4";
            label4.Size = new Size(252, 25);
            label4.TabIndex = 12;
            label4.Text = "Bienvenidos A el Programa";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(591, 426);
            button1.Name = "button1";
            button1.Size = new Size(75, 53);
            button1.TabIndex = 8;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += iniciarSesion_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(123, 489);
            menuStrip1.TabIndex = 12;
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
            // Login
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            ClientSize = new Size(708, 489);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(registrarse);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPass;
        private Button registrarse;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label4;
        private Button button1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}
