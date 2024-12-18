namespace WindowsForms
{
    partial class AdministrarRoles
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
            cBoxRol = new ComboBox();
            btonBuscar = new Button();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtFechaCreacion = new TextBox();
            txtDescripcionRol = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdRol = new TextBox();
            btonEditar = new Button();
            btonVolver = new Button();
            btonCrear = new Button();
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
            menuStrip1.Size = new Size(123, 450);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
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
            panel1.Location = new Point(123, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 42);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 0;
            label1.Text = "Administrar Roles";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(123, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(677, 51);
            panel2.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2195129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.78049F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(cBoxRol, 1, 0);
            tableLayoutPanel1.Controls.Add(btonBuscar, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(677, 51);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 0;
            label2.Text = "Ingresar Rol a Editar:";
            // 
            // cBoxRol
            // 
            cBoxRol.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBoxRol.FormattingEnabled = true;
            cBoxRol.Location = new Point(146, 14);
            cBoxRol.Name = "cBoxRol";
            cBoxRol.Size = new Size(397, 23);
            cBoxRol.TabIndex = 1;
            // 
            // btonBuscar
            // 
            btonBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btonBuscar.Location = new Point(549, 14);
            btonBuscar.Name = "btonBuscar";
            btonBuscar.Size = new Size(125, 23);
            btonBuscar.TabIndex = 2;
            btonBuscar.Text = "Buscar";
            btonBuscar.UseVisualStyleBackColor = true;
            btonBuscar.Click += btonBuscar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(123, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(677, 246);
            panel3.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.7680931F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.2319069F));
            tableLayoutPanel2.Controls.Add(txtFechaCreacion, 1, 2);
            tableLayoutPanel2.Controls.Add(txtDescripcionRol, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(txtIdRol, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.22259F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.22259F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.55482F));
            tableLayoutPanel2.Size = new Size(677, 246);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtFechaCreacion
            // 
            txtFechaCreacion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFechaCreacion.Location = new Point(279, 192);
            txtFechaCreacion.Name = "txtFechaCreacion";
            txtFechaCreacion.PlaceholderText = "Asignado Automaticamente";
            txtFechaCreacion.Size = new Size(395, 23);
            txtFechaCreacion.TabIndex = 5;
            // 
            // txtDescripcionRol
            // 
            txtDescripcionRol.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcionRol.Location = new Point(279, 110);
            txtDescripcionRol.Name = "txtDescripcionRol";
            txtDescripcionRol.PlaceholderText = "Ingrese descripcion Del Rol";
            txtDescripcionRol.Size = new Size(395, 23);
            txtDescripcionRol.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 114);
            label5.Name = "label5";
            label5.Size = new Size(270, 15);
            label5.TabIndex = 2;
            label5.Text = "Descipcion del Rol:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Size = new Size(270, 15);
            label3.TabIndex = 0;
            label3.Text = "ID del Rol:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 196);
            label4.Name = "label4";
            label4.Size = new Size(270, 15);
            label4.TabIndex = 1;
            label4.Text = "Fecha de Creacion del Rol:";
            // 
            // txtIdRol
            // 
            txtIdRol.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdRol.Location = new Point(279, 29);
            txtIdRol.Name = "txtIdRol";
            txtIdRol.PlaceholderText = "Se Asigna Automaticamente";
            txtIdRol.Size = new Size(395, 23);
            txtIdRol.TabIndex = 3;
            // 
            // btonEditar
            // 
            btonEditar.Location = new Point(641, 427);
            btonEditar.Name = "btonEditar";
            btonEditar.Size = new Size(75, 23);
            btonEditar.TabIndex = 17;
            btonEditar.Text = "Editar";
            btonEditar.UseVisualStyleBackColor = true;
            btonEditar.Click += btonEditar_Click;
            // 
            // btonVolver
            // 
            btonVolver.Location = new Point(126, 427);
            btonVolver.Name = "btonVolver";
            btonVolver.Size = new Size(75, 23);
            btonVolver.TabIndex = 18;
            btonVolver.Text = "Volver";
            btonVolver.UseVisualStyleBackColor = true;
            btonVolver.Click += btonVolver_Click;
            // 
            // btonCrear
            // 
            btonCrear.Location = new Point(722, 427);
            btonCrear.Name = "btonCrear";
            btonCrear.Size = new Size(75, 23);
            btonCrear.TabIndex = 19;
            btonCrear.Text = "Crear";
            btonCrear.UseVisualStyleBackColor = true;
            btonCrear.Click += btonCrear_Click;
            // 
            // btonEliminar
            // 
            btonEliminar.Location = new Point(560, 427);
            btonEliminar.Name = "btonEliminar";
            btonEliminar.Size = new Size(75, 23);
            btonEliminar.TabIndex = 20;
            btonEliminar.Text = "Eliminar";
            btonEliminar.UseVisualStyleBackColor = true;
            btonEliminar.Click += btonEliminar_Click;
            // 
            // AdministrarRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btonEliminar);
            Controls.Add(btonCrear);
            Controls.Add(btonVolver);
            Controls.Add(btonEditar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "AdministrarRoles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar Roles";
            Load += AdministrarRoles_Load;
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
        private ComboBox cBoxRol;
        private Button btonBuscar;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtFechaCreacion;
        private TextBox txtDescripcionRol;
        private TextBox txtIdRol;
        private Button btonEditar;
        private Button btonVolver;
        private Button btonCrear;
        private Button btonEliminar;
    }
}