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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona usuarios = new Persona();
            usuarios.usuario = txtUsuario.Text;
            usuarios.Contraseña = txtContra.Text;
            usuarios.Nombre = txtNombre.Text;
            usuarios.ap_paterno = txtApPA.Text;
            usuarios.ap_materno = txtApMA.Text;
            usuarios.Correo = txtCorreo.Text;
            usuarios.Tipo_usuario = txtTipoUsu.Text;



            if (dataGridView1.SelectedRows.Count == 1)
            {


                int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                if (ID != null)
                {
                    usuarios.ID = ID;
                    int result = PersonaDal.ModificarPersona(usuarios);

                    if (result > 0)
                    {
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar");
                    }
                }
            }
            else
            {
                int result = PersonaDal.AgregarPersonal(usuarios);

                if (result > 0)
                {
                    MessageBox.Show("Guardado exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }

            }
            refressPantalla();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            refressPantalla();
            txtID.Enabled = false;
        }

        public void refressPantalla()
        {
            dataGridView1.DataSource = PersonaDal.PresentarRegistro();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value);
            txtUsuario.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["usuario"].Value);
            txtContra.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Contraseña"].Value);
            txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value);
            txtApPA.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["ap_paterno"].Value);
            txtApMA.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["ap_materno"].Value);
            txtCorreo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Correo"].Value);
            txtTipoUsu.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Tipo_usuario"].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            txtNombre.Clear();
            txtApPA.Clear();
            txtApMA.Clear();
            txtCorreo.Clear();
            txtTipoUsu.Clear();
            dataGridView1.CurrentCell = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                int resultado = PersonaDal.EliminarPersonal(ID);
                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            refressPantalla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
