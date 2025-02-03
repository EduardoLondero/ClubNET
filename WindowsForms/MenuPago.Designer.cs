namespace WindowsForms
{
    partial class MenuPago
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
            btonActualizar = new Button();
            btonVolver = new Button();
            panel3 = new Panel();
            dgvPagos = new DataGridView();
            btonGenerarReporte = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
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
            menuStrip1.Size = new Size(188, 450);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1;
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
            panel1.Location = new Point(188, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 45);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 10);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 1;
            label1.Text = "Estos son tus pagos";
            // 
            // panel2
            // 
            panel2.Controls.Add(btonGenerarReporte);
            panel2.Controls.Add(btonActualizar);
            panel2.Controls.Add(btonVolver);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(188, 424);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 26);
            panel2.TabIndex = 3;
            // 
            // btonActualizar
            // 
            btonActualizar.Dock = DockStyle.Left;
            btonActualizar.Location = new Point(0, 0);
            btonActualizar.Name = "btonActualizar";
            btonActualizar.Size = new Size(75, 26);
            btonActualizar.TabIndex = 1;
            btonActualizar.Text = "Actualizar";
            btonActualizar.UseVisualStyleBackColor = true;
            btonActualizar.Click += btonActualizar_Click;
            // 
            // btonVolver
            // 
            btonVolver.Dock = DockStyle.Right;
            btonVolver.Location = new Point(537, 0);
            btonVolver.Name = "btonVolver";
            btonVolver.Size = new Size(75, 26);
            btonVolver.TabIndex = 0;
            btonVolver.Text = "Volver";
            btonVolver.UseVisualStyleBackColor = true;
            btonVolver.Click += btonVolver_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvPagos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(188, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 379);
            panel3.TabIndex = 4;
            // 
            // dgvPagos
            // 
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Dock = DockStyle.Fill;
            dgvPagos.Location = new Point(0, 0);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.Size = new Size(612, 379);
            dgvPagos.TabIndex = 0;
            // 
            // btonGenerarReporte
            // 
            btonGenerarReporte.Location = new Point(81, 2);
            btonGenerarReporte.Name = "btonGenerarReporte";
            btonGenerarReporte.Size = new Size(75, 23);
            btonGenerarReporte.TabIndex = 2;
            btonGenerarReporte.Text = "Reporte";
            btonGenerarReporte.UseVisualStyleBackColor = true;
            btonGenerarReporte.Click += btonGenerarReporte_Click;
            // 
            // MenuPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "MenuPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mis Pagos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btonActualizar;
        private Button btonVolver;
        private Panel panel3;
        private DataGridView dgvPagos;
        private Button btonGenerarReporte;
    }
}