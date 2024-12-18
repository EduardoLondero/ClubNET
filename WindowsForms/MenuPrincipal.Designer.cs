namespace WindowsForms
{
    partial class MenuPrincipal
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
            msjBienvenida = new Label();
            label1 = new Label();
            lblusuario = new Label();
            menuStrip2 = new MenuStrip();
            btonDeporte = new FontAwesome.Sharp.IconMenuItem();
            btonMembresia = new FontAwesome.Sharp.IconMenuItem();
            btonPagos = new FontAwesome.Sharp.IconMenuItem();
            btonUsuario = new FontAwesome.Sharp.IconMenuItem();
            btonAdministrar = new FontAwesome.Sharp.IconMenuItem();
            btonAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            panelContenido = new Panel();
            menuStrip2.SuspendLayout();
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
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // msjBienvenida
            // 
            msjBienvenida.BackColor = Color.SteelBlue;
            msjBienvenida.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msjBienvenida.ForeColor = SystemColors.Control;
            msjBienvenida.Location = new Point(0, 0);
            msjBienvenida.Name = "msjBienvenida";
            msjBienvenida.Size = new Size(124, 67);
            msjBienvenida.TabIndex = 4;
            msjBienvenida.Text = "CLUB";
            msjBienvenida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(376, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 67);
            label1.TabIndex = 5;
            label1.Text = "Usuario:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblusuario
            // 
            lblusuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblusuario.BackColor = Color.SteelBlue;
            lblusuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusuario.ForeColor = Color.White;
            lblusuario.Location = new Point(455, 22);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(345, 26);
            lblusuario.TabIndex = 6;
            lblusuario.Text = "label2";
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.SteelBlue;
            menuStrip2.Dock = DockStyle.Bottom;
            menuStrip2.Items.AddRange(new ToolStripItem[] { btonDeporte, btonMembresia, btonPagos, btonUsuario, btonAdministrar, btonAcercaDe });
            menuStrip2.Location = new Point(0, 361);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 89);
            menuStrip2.TabIndex = 7;
            menuStrip2.Text = "menuStrip2";
            // 
            // btonDeporte
            // 
            btonDeporte.AutoSize = false;
            btonDeporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btonDeporte.IconChar = FontAwesome.Sharp.IconChar.Basketball;
            btonDeporte.IconColor = Color.White;
            btonDeporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btonDeporte.IconSize = 50;
            btonDeporte.ImageScaling = ToolStripItemImageScaling.None;
            btonDeporte.Name = "btonDeporte";
            btonDeporte.Size = new Size(122, 70);
            btonDeporte.Text = "Deporte";
            btonDeporte.TextImageRelation = TextImageRelation.ImageAboveText;
            btonDeporte.Click += btonDeporte_Click;
            // 
            // btonMembresia
            // 
            btonMembresia.AutoSize = false;
            btonMembresia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btonMembresia.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            btonMembresia.IconColor = Color.White;
            btonMembresia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btonMembresia.IconSize = 50;
            btonMembresia.ImageScaling = ToolStripItemImageScaling.None;
            btonMembresia.Name = "btonMembresia";
            btonMembresia.Size = new Size(130, 70);
            btonMembresia.Text = "Membresia";
            btonMembresia.TextImageRelation = TextImageRelation.ImageAboveText;
            btonMembresia.Click += btonMembresia_Click;
            // 
            // btonPagos
            // 
            btonPagos.AutoSize = false;
            btonPagos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btonPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1;
            btonPagos.IconColor = Color.White;
            btonPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btonPagos.ImageScaling = ToolStripItemImageScaling.None;
            btonPagos.Name = "btonPagos";
            btonPagos.Size = new Size(122, 70);
            btonPagos.Text = "Pagos";
            btonPagos.TextImageRelation = TextImageRelation.ImageAboveText;
            btonPagos.Click += btonPagos_Click;
            // 
            // btonUsuario
            // 
            btonUsuario.AutoSize = false;
            btonUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btonUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            btonUsuario.IconColor = Color.White;
            btonUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btonUsuario.ImageScaling = ToolStripItemImageScaling.None;
            btonUsuario.Name = "btonUsuario";
            btonUsuario.Size = new Size(130, 70);
            btonUsuario.Text = "Usuario";
            btonUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            btonUsuario.Click += btonUsuario_Click;
            // 
            // btonAdministrar
            // 
            btonAdministrar.AutoSize = false;
            btonAdministrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btonAdministrar.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            btonAdministrar.IconColor = Color.White;
            btonAdministrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btonAdministrar.IconSize = 50;
            btonAdministrar.ImageScaling = ToolStripItemImageScaling.None;
            btonAdministrar.Name = "btonAdministrar";
            btonAdministrar.Size = new Size(130, 70);
            btonAdministrar.Text = "Administrar";
            btonAdministrar.TextAlign = ContentAlignment.BottomCenter;
            btonAdministrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btonAdministrar.Click += btonAdministrar_Click;
            // 
            // btonAcercaDe
            // 
            btonAcercaDe.AutoSize = false;
            btonAcercaDe.AutoToolTip = true;
            btonAcercaDe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btonAcercaDe.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btonAcercaDe.IconColor = Color.White;
            btonAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btonAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            btonAcercaDe.Name = "btonAcercaDe";
            btonAcercaDe.Size = new Size(122, 70);
            btonAcercaDe.Text = "Salir";
            btonAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            btonAcercaDe.Click += btonAcercaDe_Click;
            // 
            // panelContenido
            // 
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 67);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(800, 294);
            panelContenido.TabIndex = 8;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenido);
            Controls.Add(lblusuario);
            Controls.Add(label1);
            Controls.Add(msjBienvenida);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            MaximizeBox = false;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip1;
        private Label msjBienvenida;
        private Label label1;
        private Label lblusuario;
        private MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem btonDeporte;
        private FontAwesome.Sharp.IconMenuItem btonAdministrar;
        private FontAwesome.Sharp.IconMenuItem btonMembresia;
        private FontAwesome.Sharp.IconMenuItem btonPagos;
        private FontAwesome.Sharp.IconMenuItem btonUsuario;
        private FontAwesome.Sharp.IconMenuItem btonAcercaDe;
        private Panel panelContenido;
    }
}