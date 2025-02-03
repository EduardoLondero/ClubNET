namespace WindowsForms
{
    partial class ReportePagos
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
            dgvReporte = new DataGridView();
            panel3 = new Panel();
            btonRegresar = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            panel3.SuspendLayout();
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
            menuStrip1.TabIndex = 3;
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
            panel1.Size = new Size(612, 39);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 34);
            label1.TabIndex = 1;
            label1.Text = "Todos Los Pagos";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvReporte);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(188, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 382);
            panel2.TabIndex = 5;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Dock = DockStyle.Fill;
            dgvReporte.Location = new Point(0, 0);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.Size = new Size(612, 382);
            dgvReporte.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btonRegresar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(188, 421);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 29);
            panel3.TabIndex = 6;
            // 
            // btonRegresar
            // 
            btonRegresar.Location = new Point(12, 3);
            btonRegresar.Name = "btonRegresar";
            btonRegresar.Size = new Size(75, 23);
            btonRegresar.TabIndex = 0;
            btonRegresar.Text = "Regresar";
            btonRegresar.UseVisualStyleBackColor = true;
            btonRegresar.Click += btonRegresar_Click;
            // 
            // ReportePagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "ReportePagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte Pagos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvReporte;
        private Panel panel3;
        private Button btonRegresar;
    }
}