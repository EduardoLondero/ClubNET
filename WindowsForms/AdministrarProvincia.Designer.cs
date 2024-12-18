namespace WindowsForms
{
    partial class AdministrarProvincia
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            btonBuscar = new Button();
            cBoxProvincia = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtNombrePronvincia = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtIdProvincia = new TextBox();
            btonEditar = new Button();
            btonCrear = new Button();
            btonVolver = new Button();
            btonEliminar = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            menuStrip1.Size = new Size(172, 450);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Map;
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
            panel1.Location = new Point(172, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 42);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 4);
            label1.Name = "label1";
            label1.Size = new Size(249, 32);
            label1.TabIndex = 0;
            label1.Text = "Administrar Provincias";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.8514862F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.14851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(btonBuscar, 2, 0);
            tableLayoutPanel1.Controls.Add(cBoxProvincia, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(172, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(628, 42);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(170, 15);
            label2.TabIndex = 0;
            label2.Text = "Ingrese Localidad a Editar :";
            // 
            // btonBuscar
            // 
            btonBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btonBuscar.Location = new Point(508, 9);
            btonBuscar.Name = "btonBuscar";
            btonBuscar.Size = new Size(117, 23);
            btonBuscar.TabIndex = 2;
            btonBuscar.Text = "Buscar";
            btonBuscar.UseVisualStyleBackColor = true;
            btonBuscar.Click += btonBuscar_Click;
            // 
            // cBoxProvincia
            // 
            cBoxProvincia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBoxProvincia.FormattingEnabled = true;
            cBoxProvincia.Location = new Point(179, 9);
            cBoxProvincia.Name = "cBoxProvincia";
            cBoxProvincia.Size = new Size(323, 23);
            cBoxProvincia.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CausesValidation = false;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.86624F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.13376F));
            tableLayoutPanel2.Controls.Add(txtNombrePronvincia, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(txtIdProvincia, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(172, 84);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(628, 276);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // txtNombrePronvincia
            // 
            txtNombrePronvincia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombrePronvincia.Location = new Point(177, 126);
            txtNombrePronvincia.Name = "txtNombrePronvincia";
            txtNombrePronvincia.Size = new Size(448, 23);
            txtNombrePronvincia.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 130);
            label5.Name = "label5";
            label5.Size = new Size(168, 15);
            label5.TabIndex = 2;
            label5.Text = "Ingrese Nombre Provincia:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 38);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 0;
            label3.Text = "ID de la Localidad:";
            // 
            // txtIdProvincia
            // 
            txtIdProvincia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdProvincia.Enabled = false;
            txtIdProvincia.Location = new Point(177, 34);
            txtIdProvincia.Name = "txtIdProvincia";
            txtIdProvincia.Size = new Size(448, 23);
            txtIdProvincia.TabIndex = 3;
            // 
            // btonEditar
            // 
            btonEditar.Location = new Point(641, 427);
            btonEditar.Name = "btonEditar";
            btonEditar.Size = new Size(75, 23);
            btonEditar.TabIndex = 13;
            btonEditar.Text = "Editar";
            btonEditar.UseVisualStyleBackColor = true;
            btonEditar.Click += btonEditar_Click;
            // 
            // btonCrear
            // 
            btonCrear.Location = new Point(722, 427);
            btonCrear.Name = "btonCrear";
            btonCrear.Size = new Size(75, 23);
            btonCrear.TabIndex = 12;
            btonCrear.Text = "Crear";
            btonCrear.UseVisualStyleBackColor = true;
            btonCrear.Click += btonCrear_Click;
            // 
            // btonVolver
            // 
            btonVolver.Location = new Point(175, 427);
            btonVolver.Name = "btonVolver";
            btonVolver.Size = new Size(75, 23);
            btonVolver.TabIndex = 11;
            btonVolver.Text = "Volver";
            btonVolver.UseVisualStyleBackColor = true;
            btonVolver.Click += btonVolver_Click;
            // 
            // btonEliminar
            // 
            btonEliminar.Location = new Point(560, 427);
            btonEliminar.Name = "btonEliminar";
            btonEliminar.Size = new Size(75, 23);
            btonEliminar.TabIndex = 14;
            btonEliminar.Text = "Eliminar";
            btonEliminar.UseVisualStyleBackColor = true;
            btonEliminar.Click += btonEliminar_Click;
            // 
            // AdministrarProvincia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btonEliminar);
            Controls.Add(btonEditar);
            Controls.Add(btonCrear);
            Controls.Add(btonVolver);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "AdministrarProvincia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar Provincia";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button btonBuscar;
        private ComboBox cBoxProvincia;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtNombrePronvincia;
        private Label label5;
        private Label label3;
        private TextBox txtIdProvincia;
        private Button btonEditar;
        private Button btonCrear;
        private Button btonVolver;
        private Button btonEliminar;
    }
}