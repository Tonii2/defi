namespace definitivo
{
    partial class Comprobar
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtContra1 = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(612, 12);
            button1.Name = "button1";
            button1.Size = new Size(76, 35);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(57, 149);
            label1.Name = "label1";
            label1.Size = new Size(585, 27);
            label1.TabIndex = 1;
            label1.Text = "Ponga su contraseña de administrador para entrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(89, 257);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 2;
            label2.Text = "Contraseña;";
            // 
            // txtContra1
            // 
            txtContra1.BackColor = Color.FromArgb(23, 21, 32);
            txtContra1.BorderStyle = BorderStyle.None;
            txtContra1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContra1.ForeColor = Color.Silver;
            txtContra1.Location = new Point(89, 281);
            txtContra1.Name = "txtContra1";
            txtContra1.Size = new Size(290, 21);
            txtContra1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(89, 308);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 1);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(245, 371);
            button2.Name = "button2";
            button2.Size = new Size(200, 55);
            button2.TabIndex = 5;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Comprobar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(700, 600);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(txtContra1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Comprobar";
            Text = "Comprobar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtContra1;
        private Panel panel1;
        private Button button2;
    }
}