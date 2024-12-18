namespace WindowsForms
{
    partial class AdministrarPagos
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
            txtPagoTotal = new TextBox();
            txtIDMembresia = new TextBox();
            txtFechaPago = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtEstado = new TextBox();
            btonFinalizar = new Button();
            btonVolver = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            menuStrip1.TabIndex = 2;
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 34);
            label1.TabIndex = 0;
            label1.Text = "Agregar Pagos";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(188, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 339);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.9281044F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.0718956F));
            tableLayoutPanel1.Controls.Add(txtPagoTotal, 1, 3);
            tableLayoutPanel1.Controls.Add(txtIDMembresia, 1, 2);
            tableLayoutPanel1.Controls.Add(txtFechaPago, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(txtEstado, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(612, 339);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtPagoTotal
            // 
            txtPagoTotal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPagoTotal.Location = new Point(229, 284);
            txtPagoTotal.Name = "txtPagoTotal";
            txtPagoTotal.PlaceholderText = "Ingrese Valor Entero";
            txtPagoTotal.Size = new Size(380, 23);
            txtPagoTotal.TabIndex = 7;
            // 
            // txtIDMembresia
            // 
            txtIDMembresia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIDMembresia.Location = new Point(229, 198);
            txtIDMembresia.Name = "txtIDMembresia";
            txtIDMembresia.PlaceholderText = "Ingrese numero del ID";
            txtIDMembresia.Size = new Size(380, 23);
            txtIDMembresia.TabIndex = 6;
            // 
            // txtFechaPago
            // 
            txtFechaPago.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFechaPago.Location = new Point(229, 114);
            txtFechaPago.Name = "txtFechaPago";
            txtFechaPago.PlaceholderText = "DD/MM/YYYY";
            txtFechaPago.Size = new Size(380, 23);
            txtFechaPago.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 118);
            label4.Name = "label4";
            label4.Size = new Size(220, 15);
            label4.TabIndex = 2;
            label4.Text = "Ingrese Fecha Del Pago:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(220, 15);
            label2.TabIndex = 0;
            label2.Text = "Ingrese Estado Del Pago:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 202);
            label3.Name = "label3";
            label3.Size = new Size(220, 15);
            label3.TabIndex = 1;
            label3.Text = "Ingrese El ID De La Membresia:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 288);
            label5.Name = "label5";
            label5.Size = new Size(220, 15);
            label5.TabIndex = 3;
            label5.Text = "Monto Total Abonado:";
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEstado.Location = new Point(229, 30);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "Pago, No Pago";
            txtEstado.Size = new Size(380, 23);
            txtEstado.TabIndex = 4;
            // 
            // btonFinalizar
            // 
            btonFinalizar.Location = new Point(713, 415);
            btonFinalizar.Name = "btonFinalizar";
            btonFinalizar.Size = new Size(75, 23);
            btonFinalizar.TabIndex = 5;
            btonFinalizar.Text = "Registrar";
            btonFinalizar.UseVisualStyleBackColor = true;
            btonFinalizar.Click += btonFinalizar_Click;
            // 
            // btonVolver
            // 
            btonVolver.Location = new Point(201, 415);
            btonVolver.Name = "btonVolver";
            btonVolver.Size = new Size(75, 23);
            btonVolver.TabIndex = 6;
            btonVolver.Text = "Volver";
            btonVolver.UseVisualStyleBackColor = true;
            btonVolver.Click += btonVolver_Click;
            // 
            // AdministrarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btonVolver);
            Controls.Add(btonFinalizar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "AdministrarPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar Pagos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtPagoTotal;
        private TextBox txtIDMembresia;
        private TextBox txtFechaPago;
        private TextBox txtEstado;
        private Button btonFinalizar;
        private Button btonVolver;
    }
}