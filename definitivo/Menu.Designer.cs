namespace definitivo
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panelSideMenu = new Panel();
            btnLogout = new Button();
            btnAcercade = new Button();
            btnAdministracion = new Button();
            panelMultaSubmenu = new Panel();
            button3 = new Button();
            btnRegistro = new Button();
            btnMulta = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelChildForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelMultaSubmenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.Black;
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Controls.Add(btnAcercade);
            panelSideMenu.Controls.Add(btnAdministracion);
            panelSideMenu.Controls.Add(panelMultaSubmenu);
            panelSideMenu.Controls.Add(btnMulta);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 600);
            panelSideMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Silver;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 555);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 45);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Salir";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAcercade
            // 
            btnAcercade.Dock = DockStyle.Top;
            btnAcercade.FlatAppearance.BorderSize = 0;
            btnAcercade.FlatStyle = FlatStyle.Flat;
            btnAcercade.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcercade.ForeColor = Color.Silver;
            btnAcercade.Image = (Image)resources.GetObject("btnAcercade.Image");
            btnAcercade.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcercade.Location = new Point(0, 309);
            btnAcercade.Name = "btnAcercade";
            btnAcercade.Size = new Size(250, 45);
            btnAcercade.TabIndex = 4;
            btnAcercade.Text = "       Acerca de";
            btnAcercade.TextAlign = ContentAlignment.MiddleLeft;
            btnAcercade.UseVisualStyleBackColor = true;
            btnAcercade.Click += btnAcercade_Click;
            // 
            // btnAdministracion
            // 
            btnAdministracion.Dock = DockStyle.Top;
            btnAdministracion.FlatAppearance.BorderSize = 0;
            btnAdministracion.FlatStyle = FlatStyle.Flat;
            btnAdministracion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministracion.ForeColor = Color.Silver;
            btnAdministracion.Image = (Image)resources.GetObject("btnAdministracion.Image");
            btnAdministracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdministracion.Location = new Point(0, 264);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.Size = new Size(250, 45);
            btnAdministracion.TabIndex = 3;
            btnAdministracion.Text = "       Administración";
            btnAdministracion.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministracion.UseVisualStyleBackColor = true;
            btnAdministracion.Click += btnAdministracion_Click;
            // 
            // panelMultaSubmenu
            // 
            panelMultaSubmenu.BackColor = Color.FromArgb(23, 21, 32);
            panelMultaSubmenu.Controls.Add(button3);
            panelMultaSubmenu.Controls.Add(btnRegistro);
            panelMultaSubmenu.Dock = DockStyle.Top;
            panelMultaSubmenu.Location = new Point(0, 170);
            panelMultaSubmenu.Name = "panelMultaSubmenu";
            panelMultaSubmenu.Size = new Size(250, 94);
            panelMultaSubmenu.TabIndex = 2;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Silver;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 45);
            button3.Name = "button3";
            button3.Size = new Size(250, 45);
            button3.TabIndex = 1;
            button3.Text = "          Historial";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Dock = DockStyle.Top;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.ForeColor = Color.Silver;
            btnRegistro.Image = (Image)resources.GetObject("btnRegistro.Image");
            btnRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistro.Location = new Point(0, 0);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(250, 45);
            btnRegistro.TabIndex = 0;
            btnRegistro.Text = "          Registro";
            btnRegistro.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnMulta
            // 
            btnMulta.Dock = DockStyle.Top;
            btnMulta.FlatAppearance.BorderSize = 0;
            btnMulta.FlatStyle = FlatStyle.Flat;
            btnMulta.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMulta.ForeColor = Color.Silver;
            btnMulta.Image = (Image)resources.GetObject("btnMulta.Image");
            btnMulta.ImageAlign = ContentAlignment.MiddleLeft;
            btnMulta.Location = new Point(0, 125);
            btnMulta.Name = "btnMulta";
            btnMulta.Size = new Size(250, 45);
            btnMulta.TabIndex = 1;
            btnMulta.Text = "       Multa";
            btnMulta.TextAlign = ContentAlignment.MiddleLeft;
            btnMulta.UseVisualStyleBackColor = true;
            btnMulta.Click += btnMulta_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Controls.Add(pictureBox4);
            panelLogo.Controls.Add(pictureBox3);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 125);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(50, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(153, 90);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(700, 600);
            panelChildForm.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(950, 600);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(950, 600);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panelSideMenu.ResumeLayout(false);
            panelMultaSubmenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelMultaSubmenu;
        private Button btnRegistro;
        private Button btnMulta;
        private Panel panelLogo;
        private Button btnAcercade;
        private Button btnAdministracion;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panelChildForm;
        private PictureBox pictureBox4;
        private Button btnLogout;
    }
}