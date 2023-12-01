using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace definitivo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelMultaSubmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelMultaSubmenu.Visible == true)
                panelMultaSubmenu.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMulta_Click(object sender, EventArgs e)
        {
            showSubmenu(panelMultaSubmenu);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            openChildForm(new registro());
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new histtorial());
            hideSubmenu();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            openChildForm(new Comprobar());
            hideSubmenu();
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            openChildForm(new acercade());
            hideSubmenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();//abriendo el formulario principal
            Hide();//esto sirve para ocultar el formulario de login
        }
    }
}
