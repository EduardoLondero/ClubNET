namespace WindowsForms
{
    partial class MenuAdministrar2
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btonAdministrarMembresias = new Button();
            btonAdministrarDeportes = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btonAdministrarUsuario = new Button();
            btonVolver = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.ImeMode = ImeMode.Disable;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 67);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(240, 0);
            label1.Name = "label1";
            label1.Size = new Size(383, 67);
            label1.TabIndex = 7;
            label1.Text = "Menu Administrador";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btonAdministrarMembresias, 1, 2);
            tableLayoutPanel1.Controls.Add(btonAdministrarDeportes, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(btonAdministrarUsuario, 1, 0);
            tableLayoutPanel1.Controls.Add(btonVolver, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Size = new Size(800, 383);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btonAdministrarMembresias
            // 
            btonAdministrarMembresias.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btonAdministrarMembresias.Location = new Point(403, 206);
            btonAdministrarMembresias.Name = "btonAdministrarMembresias";
            btonAdministrarMembresias.Size = new Size(394, 23);
            btonAdministrarMembresias.TabIndex = 6;
            btonAdministrarMembresias.Text = "Administrar";
            btonAdministrarMembresias.UseVisualStyleBackColor = true;
            btonAdministrarMembresias.Click += btonAdministrarMembresias_Click;
            // 
            // btonAdministrarDeportes
            // 
            btonAdministrarDeportes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btonAdministrarDeportes.Location = new Point(403, 119);
            btonAdministrarDeportes.Name = "btonAdministrarDeportes";
            btonAdministrarDeportes.Size = new Size(394, 23);
            btonAdministrarDeportes.TabIndex = 5;
            btonAdministrarDeportes.Text = "Administrar";
            btonAdministrarDeportes.UseVisualStyleBackColor = true;
            btonAdministrarDeportes.Click += btonAdministrarDeportes_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(394, 15);
            label2.TabIndex = 0;
            label2.Text = "Administrar Roles:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 123);
            label3.Name = "label3";
            label3.Size = new Size(394, 15);
            label3.TabIndex = 1;
            label3.Text = "Administrar Localidades:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 210);
            label4.Name = "label4";
            label4.Size = new Size(394, 15);
            label4.TabIndex = 2;
            label4.Text = "Administrar Provincias:";
            // 
            // btonAdministrarUsuario
            // 
            btonAdministrarUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btonAdministrarUsuario.Location = new Point(403, 32);
            btonAdministrarUsuario.Name = "btonAdministrarUsuario";
            btonAdministrarUsuario.Size = new Size(394, 23);
            btonAdministrarUsuario.TabIndex = 4;
            btonAdministrarUsuario.Text = "Administrar";
            btonAdministrarUsuario.UseVisualStyleBackColor = true;
            btonAdministrarUsuario.Click += btonAdministrarUsuario_Click;
            // 
            // btonVolver
            // 
            btonVolver.Location = new Point(3, 351);
            btonVolver.Name = "btonVolver";
            btonVolver.Size = new Size(75, 23);
            btonVolver.TabIndex = 8;
            btonVolver.Text = "Volver";
            btonVolver.UseVisualStyleBackColor = true;
            btonVolver.Click += btonVolver_Click;
            // 
            // MenuAdministrar2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "MenuAdministrar2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Administrar";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btonAdministrarMembresias;
        private Button btonAdministrarDeportes;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btonAdministrarUsuario;
        private Button btonVolver;
    }
}