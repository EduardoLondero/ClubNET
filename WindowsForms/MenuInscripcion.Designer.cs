namespace WindowsForms
{
    partial class MenuInscripcion
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
            btonVolver = new Button();
            panel3 = new Panel();
            dgvDeportes = new DataGridView();
            panel4 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            txtIdDeporte = new TextBox();
            label5 = new Label();
            dgvMembresia = new DataGridView();
            btonInscribirse = new Button();
            txtMembresiaId = new TextBox();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1 = new MenuStrip();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeportes).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(188, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 45);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 1;
            label1.Text = "Deportes Disponibles";
            // 
            // panel2
            // 
            panel2.Controls.Add(btonVolver);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(188, 486);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 30);
            panel2.TabIndex = 4;
            // 
            // btonVolver
            // 
            btonVolver.Dock = DockStyle.Right;
            btonVolver.Location = new Point(575, 0);
            btonVolver.Name = "btonVolver";
            btonVolver.Size = new Size(75, 30);
            btonVolver.TabIndex = 0;
            btonVolver.Text = "Volver";
            btonVolver.UseVisualStyleBackColor = true;
            btonVolver.Click += btonVolver_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvDeportes);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(188, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(650, 159);
            panel3.TabIndex = 5;
            // 
            // dgvDeportes
            // 
            dgvDeportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeportes.Dock = DockStyle.Fill;
            dgvDeportes.Location = new Point(0, 0);
            dgvDeportes.Name = "dgvDeportes";
            dgvDeportes.Size = new Size(650, 159);
            dgvDeportes.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(188, 204);
            panel4.Name = "panel4";
            panel4.Size = new Size(650, 36);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(650, 36);
            panel5.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(240, 6);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 3;
            label6.Text = "Inscribirse";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(240, -116);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 2;
            label4.Text = "Inscribirse";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, -84);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 2;
            label2.Text = "Inscribirse";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.7368422F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.26316F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(txtIdDeporte, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(dgvMembresia, 1, 2);
            tableLayoutPanel1.Controls.Add(btonInscribirse, 2, 1);
            tableLayoutPanel1.Controls.Add(txtMembresiaId, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(188, 240);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.81818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.18182F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.Size = new Size(511, 246);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 22);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // txtIdDeporte
            // 
            txtIdDeporte.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdDeporte.Location = new Point(66, 23);
            txtIdDeporte.Name = "txtIdDeporte";
            txtIdDeporte.PlaceholderText = "Ingrese ID deporte";
            txtIdDeporte.Size = new Size(359, 23);
            txtIdDeporte.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 168);
            label5.Name = "label5";
            label5.Size = new Size(57, 45);
            label5.TabIndex = 7;
            label5.Text = "Tus Membresias";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvMembresia
            // 
            dgvMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembresia.Dock = DockStyle.Fill;
            dgvMembresia.Location = new Point(66, 138);
            dgvMembresia.Name = "dgvMembresia";
            dgvMembresia.Size = new Size(359, 105);
            dgvMembresia.TabIndex = 8;
            // 
            // btonInscribirse
            // 
            btonInscribirse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btonInscribirse.Location = new Point(431, 91);
            btonInscribirse.Name = "btonInscribirse";
            btonInscribirse.Size = new Size(77, 23);
            btonInscribirse.TabIndex = 6;
            btonInscribirse.Text = "Inscribirse";
            btonInscribirse.UseVisualStyleBackColor = true;
            btonInscribirse.Click += btonInscribirse_Click;
            // 
            // txtMembresiaId
            // 
            txtMembresiaId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMembresiaId.Location = new Point(66, 91);
            txtMembresiaId.Name = "txtMembresiaId";
            txtMembresiaId.PlaceholderText = "Ingrese su ID de Membresia";
            txtMembresiaId.Size = new Size(359, 23);
            txtMembresiaId.TabIndex = 9;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Basketball;
            iconMenuItem1.IconColor = Color.White;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 50;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Margin = new Padding(5, 180, 5, 5);
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(200, 80);
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(188, 516);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 516);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "MenuInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripcion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeportes).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btonVolver;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private DataGridView dgvDeportes;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private TextBox txtIdDeporte;
        private Button btonInscribirse;
        private Label label5;
        private DataGridView dgvMembresia;
        private TextBox txtMembresiaId;
        private Panel panel5;
        private Label label6;
        private Label label4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private MenuStrip menuStrip1;
    }
}