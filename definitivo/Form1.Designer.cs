namespace definitivo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnlogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(749, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(721, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(323, 0);
            label1.Name = "label1";
            label1.Size = new Size(392, 49);
            label1.TabIndex = 3;
            label1.Text = "SISTEMA DE MULTAS";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.Black;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.Silver;
            txtUser.Location = new Point(345, 109);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(350, 25);
            txtUser.TabIndex = 1;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter_1;
            txtUser.Leave += txtUser_Leave_1;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.Black;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.Silver;
            txtPass.Location = new Point(345, 172);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(294, 25);
            txtPass.TabIndex = 2;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter_1;
            txtPass.Leave += txtPass_Leave_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(345, 203);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 1);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(345, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 1);
            panel3.TabIndex = 5;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(40, 40, 40);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = Color.Silver;
            btnlogin.Location = new Point(323, 253);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(408, 40);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "INICIAR SESION";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(780, 330);
            Controls.Add(btnlogin);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Panel panel2;
        private Panel panel3;
        private Button btnlogin;
    }
}