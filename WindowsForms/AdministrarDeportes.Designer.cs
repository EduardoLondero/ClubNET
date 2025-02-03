namespace WindowsForms
{
    partial class AdministrarDeportes
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
            cBoxDeporte = new ComboBox();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtPrecioDeporte = new TextBox();
            txtHoraFin = new TextBox();
            txtHoraInicio = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreDeporte = new TextBox();
            btonVolver = new Button();
            btonEditar = new Button();
            btonCrear = new Button();
            btonEliminar = new Button();
            btonGenerarReporte = new Button();
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
            menuStrip1.Size = new Size(165, 450);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
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
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(165, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 37);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 1);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 0;
            label1.Text = "Administrar Deportes";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(165, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 36);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.774847F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.22515F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(btonBuscar, 2, 0);
            tableLayoutPanel1.Controls.Add(cBoxDeporte, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(635, 36);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 0;
            label2.Text = "Ingrese ID Deporte:";
            // 
            // btonBuscar
            // 
            btonBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btonBuscar.Location = new Point(496, 6);
            btonBuscar.Name = "btonBuscar";
            btonBuscar.Size = new Size(136, 23);
            btonBuscar.TabIndex = 2;
            btonBuscar.Text = "Buscar";
            btonBuscar.UseVisualStyleBackColor = true;
            btonBuscar.Click += btonBuscar_Click;
            // 
            // cBoxDeporte
            // 
            cBoxDeporte.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBoxDeporte.FormattingEnabled = true;
            cBoxDeporte.Location = new Point(135, 6);
            cBoxDeporte.Name = "cBoxDeporte";
            cBoxDeporte.Size = new Size(355, 23);
            cBoxDeporte.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(165, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(635, 331);
            panel3.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(txtPrecioDeporte, 1, 3);
            tableLayoutPanel2.Controls.Add(txtHoraFin, 1, 2);
            tableLayoutPanel2.Controls.Add(txtHoraInicio, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(txtNombreDeporte, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(635, 331);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtPrecioDeporte
            // 
            txtPrecioDeporte.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrecioDeporte.Location = new Point(320, 277);
            txtPrecioDeporte.Name = "txtPrecioDeporte";
            txtPrecioDeporte.Size = new Size(312, 23);
            txtPrecioDeporte.TabIndex = 7;
            // 
            // txtHoraFin
            // 
            txtHoraFin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHoraFin.Location = new Point(320, 193);
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.Size = new Size(312, 23);
            txtHoraFin.TabIndex = 6;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHoraInicio.Location = new Point(320, 111);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new Size(312, 23);
            txtHoraInicio.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Size = new Size(311, 15);
            label3.TabIndex = 0;
            label3.Text = "Ingrese Nombre Deporte:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 115);
            label4.Name = "label4";
            label4.Size = new Size(311, 15);
            label4.TabIndex = 1;
            label4.Text = "Ingrese Hora Inicio:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 197);
            label5.Name = "label5";
            label5.Size = new Size(311, 15);
            label5.TabIndex = 2;
            label5.Text = "Ingrese Hora Fin:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 281);
            label6.Name = "label6";
            label6.Size = new Size(311, 15);
            label6.TabIndex = 3;
            label6.Text = "Ingrese Precio Deporte:";
            // 
            // txtNombreDeporte
            // 
            txtNombreDeporte.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreDeporte.Location = new Point(320, 29);
            txtNombreDeporte.Name = "txtNombreDeporte";
            txtNombreDeporte.Size = new Size(312, 23);
            txtNombreDeporte.TabIndex = 4;
            // 
            // btonVolver
            // 
            btonVolver.Location = new Point(168, 427);
            btonVolver.Name = "btonVolver";
            btonVolver.Size = new Size(75, 23);
            btonVolver.TabIndex = 7;
            btonVolver.Text = "Volver";
            btonVolver.UseVisualStyleBackColor = true;
            btonVolver.Click += btonVolver_Click;
            // 
            // btonEditar
            // 
            btonEditar.Location = new Point(644, 427);
            btonEditar.Name = "btonEditar";
            btonEditar.Size = new Size(75, 23);
            btonEditar.TabIndex = 8;
            btonEditar.Text = "Editar";
            btonEditar.UseVisualStyleBackColor = true;
            btonEditar.Click += btonEditar_Click;
            // 
            // btonCrear
            // 
            btonCrear.Location = new Point(725, 427);
            btonCrear.Name = "btonCrear";
            btonCrear.Size = new Size(75, 23);
            btonCrear.TabIndex = 9;
            btonCrear.Text = "Crear";
            btonCrear.UseVisualStyleBackColor = true;
            btonCrear.Click += btonCrear_Click;
            // 
            // btonEliminar
            // 
            btonEliminar.Location = new Point(563, 427);
            btonEliminar.Name = "btonEliminar";
            btonEliminar.Size = new Size(75, 23);
            btonEliminar.TabIndex = 10;
            btonEliminar.Text = "Eliminar";
            btonEliminar.UseVisualStyleBackColor = true;
            btonEliminar.Click += btonEliminar_Click;
            // 
            // btonGenerarReporte
            // 
            btonGenerarReporte.Location = new Point(249, 427);
            btonGenerarReporte.Name = "btonGenerarReporte";
            btonGenerarReporte.Size = new Size(75, 23);
            btonGenerarReporte.TabIndex = 11;
            btonGenerarReporte.Text = "Reporte";
            btonGenerarReporte.UseVisualStyleBackColor = true;
            btonGenerarReporte.Click += btonGenerarReporte_Click;
            // 
            // AdministrarDeportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btonGenerarReporte);
            Controls.Add(btonEliminar);
            Controls.Add(btonCrear);
            Controls.Add(btonEditar);
            Controls.Add(btonVolver);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "AdministrarDeportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar Deportes";
            Load += AdministrarDeportes_Load;
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
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtPrecioDeporte;
        private TextBox txtHoraFin;
        private TextBox txtHoraInicio;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombreDeporte;
        private Button btonVolver;
        private Button btonEditar;
        private Button btonCrear;
        private Button btonBuscar;
        private Button btonEliminar;
        private ComboBox cBoxDeporte;
        private Button btonGenerarReporte;
    }
}