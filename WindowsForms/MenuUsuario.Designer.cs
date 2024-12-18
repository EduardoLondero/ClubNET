namespace WindowsForms
{
    partial class MenuUsuario
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
            panel4 = new Panel();
            btonVolver = new Button();
            btonActualizar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            txtEmailNew = new TextBox();
            txtPassNew = new TextBox();
            panel3 = new Panel();
            dgvUsuario = new DataGridView();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
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
            menuStrip1.Size = new Size(180, 450);
            menuStrip1.TabIndex = 0;
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
            iconMenuItem1.Size = new Size(173, 54);
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(180, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 46);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 32);
            label1.TabIndex = 0;
            label1.Text = "Datos Actuales";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(180, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 286);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btonVolver);
            panel4.Controls.Add(btonActualizar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 253);
            panel4.Name = "panel4";
            panel4.Size = new Size(671, 33);
            panel4.TabIndex = 2;
            // 
            // btonVolver
            // 
            btonVolver.Location = new Point(562, 6);
            btonVolver.Name = "btonVolver";
            btonVolver.Size = new Size(109, 27);
            btonVolver.TabIndex = 4;
            btonVolver.Text = "Volver";
            btonVolver.UseVisualStyleBackColor = true;
            btonVolver.Click += btonVolver_Click;
            // 
            // btonActualizar
            // 
            btonActualizar.Location = new Point(0, 3);
            btonActualizar.Name = "btonActualizar";
            btonActualizar.Size = new Size(112, 30);
            btonActualizar.TabIndex = 3;
            btonActualizar.Text = "Actualizar";
            btonActualizar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(671, 40);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(665, 21);
            label2.TabIndex = 0;
            label2.Text = "Actualice los siguiente Datos:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(txtEmailNew, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPassNew, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 46);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.5519142F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.4480858F));
            tableLayoutPanel1.Size = new Size(502, 183);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 38);
            label3.Name = "label3";
            label3.Size = new Size(245, 21);
            label3.TabIndex = 0;
            label3.Text = "Email: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 130);
            label4.Name = "label4";
            label4.Size = new Size(245, 21);
            label4.TabIndex = 1;
            label4.Text = "Contraseña:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmailNew
            // 
            txtEmailNew.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmailNew.Location = new Point(254, 37);
            txtEmailNew.Name = "txtEmailNew";
            txtEmailNew.Size = new Size(245, 23);
            txtEmailNew.TabIndex = 2;
            // 
            // txtPassNew
            // 
            txtPassNew.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassNew.Location = new Point(254, 129);
            txtPassNew.Name = "txtPassNew";
            txtPassNew.Size = new Size(245, 23);
            txtPassNew.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvUsuario);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(180, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(671, 118);
            panel3.TabIndex = 3;
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Dock = DockStyle.Top;
            dgvUsuario.Location = new Point(0, 0);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(671, 149);
            dgvUsuario.TabIndex = 0;
            // 
            // MenuUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(851, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MenuUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mis Datos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvUsuario;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label4;
        private TextBox txtEmailNew;
        private TextBox txtPassNew;
        private Panel panel4;
        private Button btonActualizar;
        private Button btonVolver;
    }
}