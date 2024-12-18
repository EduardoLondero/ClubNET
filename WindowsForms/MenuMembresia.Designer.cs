namespace WindowsForms
{
    partial class MenuMembresia
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
            panel7 = new Panel();
            panel8 = new Panel();
            btonRegresar = new Button();
            btonEliminar = new Button();
            txtEliminarMembresia = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            btonActualizar = new Button();
            btonInscribirse = new Button();
            txtTipoMembresia = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            dgvTipoMembresia = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            dgvMembresia = new DataGridView();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoMembresia).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).BeginInit();
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
            menuStrip1.Size = new Size(188, 533);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
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
            panel1.Size = new Size(748, 48);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 25);
            label1.TabIndex = 0;
            label1.Text = "Estas son sus Membresias";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvMembresia);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(188, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 485);
            panel2.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(373, 290);
            panel7.Name = "panel7";
            panel7.Size = new Size(375, 195);
            panel7.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.Controls.Add(btonRegresar);
            panel8.Controls.Add(btonEliminar);
            panel8.Controls.Add(txtEliminarMembresia);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(label5);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(375, 195);
            panel8.TabIndex = 5;
            // 
            // btonRegresar
            // 
            btonRegresar.Location = new Point(288, 160);
            btonRegresar.Name = "btonRegresar";
            btonRegresar.Size = new Size(75, 23);
            btonRegresar.TabIndex = 10;
            btonRegresar.Text = "Regresar";
            btonRegresar.UseVisualStyleBackColor = true;
            btonRegresar.Click += btonRegresar_Click;
            // 
            // btonEliminar
            // 
            btonEliminar.Location = new Point(287, 94);
            btonEliminar.Name = "btonEliminar";
            btonEliminar.Size = new Size(75, 23);
            btonEliminar.TabIndex = 9;
            btonEliminar.Text = "Eliminar";
            btonEliminar.UseVisualStyleBackColor = true;
            btonEliminar.Click += btonEliminar_Click;
            // 
            // txtEliminarMembresia
            // 
            txtEliminarMembresia.Location = new Point(59, 94);
            txtEliminarMembresia.Name = "txtEliminarMembresia";
            txtEliminarMembresia.PlaceholderText = "Ingrese ID De la Membresia a Eliminar";
            txtEliminarMembresia.Size = new Size(222, 23);
            txtEliminarMembresia.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 92);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 7;
            label6.Text = "ID:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(94, 15);
            label5.Name = "label5";
            label5.Size = new Size(187, 25);
            label5.TabIndex = 7;
            label5.Text = "Eliminar Membresia";
            // 
            // panel6
            // 
            panel6.Controls.Add(btonActualizar);
            panel6.Controls.Add(btonInscribirse);
            panel6.Controls.Add(txtTipoMembresia);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 290);
            panel6.Name = "panel6";
            panel6.Size = new Size(373, 195);
            panel6.TabIndex = 3;
            // 
            // btonActualizar
            // 
            btonActualizar.Location = new Point(13, 160);
            btonActualizar.Name = "btonActualizar";
            btonActualizar.Size = new Size(75, 23);
            btonActualizar.TabIndex = 7;
            btonActualizar.Text = "Actualizar";
            btonActualizar.UseVisualStyleBackColor = true;
            btonActualizar.Click += btonActualizar_Click;
            // 
            // btonInscribirse
            // 
            btonInscribirse.Location = new Point(292, 92);
            btonInscribirse.Name = "btonInscribirse";
            btonInscribirse.Size = new Size(75, 23);
            btonInscribirse.TabIndex = 6;
            btonInscribirse.Text = "Inscribirse";
            btonInscribirse.UseVisualStyleBackColor = true;
            btonInscribirse.Click += btonInscribirse_Click;
            // 
            // txtTipoMembresia
            // 
            txtTipoMembresia.Location = new Point(46, 92);
            txtTipoMembresia.Name = "txtTipoMembresia";
            txtTipoMembresia.PlaceholderText = "Ingrese ID Del Tipo De Membresia";
            txtTipoMembresia.Size = new Size(243, 23);
            txtTipoMembresia.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 87);
            label4.Name = "label4";
            label4.Size = new Size(37, 25);
            label4.TabIndex = 4;
            label4.Text = "ID:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(135, 15);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 3;
            label3.Text = "Inscribirse";
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvTipoMembresia);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 168);
            panel5.Name = "panel5";
            panel5.Size = new Size(748, 122);
            panel5.TabIndex = 2;
            // 
            // dgvTipoMembresia
            // 
            dgvTipoMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoMembresia.Dock = DockStyle.Fill;
            dgvTipoMembresia.Location = new Point(0, 0);
            dgvTipoMembresia.Name = "dgvTipoMembresia";
            dgvTipoMembresia.Size = new Size(748, 122);
            dgvTipoMembresia.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(748, 42);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(748, 39);
            panel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 0);
            label2.Name = "label2";
            label2.Size = new Size(279, 25);
            label2.TabIndex = 2;
            label2.Text = "Tipos Membresias Disponibles";
            // 
            // dgvMembresia
            // 
            dgvMembresia.AllowDrop = true;
            dgvMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembresia.Dock = DockStyle.Top;
            dgvMembresia.Location = new Point(0, 0);
            dgvMembresia.Name = "dgvMembresia";
            dgvMembresia.Size = new Size(748, 126);
            dgvMembresia.TabIndex = 0;
            // 
            // MenuMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MenuMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Membresias";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTipoMembresia).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvMembresia;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dgvTipoMembresia;
        private Panel panel7;
        private Panel panel8;
        private Label label6;
        private Label label5;
        private Panel panel6;
        private Button btonInscribirse;
        private TextBox txtTipoMembresia;
        private Label label4;
        private Label label3;
        private Button btonEliminar;
        private TextBox txtEliminarMembresia;
        private Button btonActualizar;
        private Button btonRegresar;
    }
}