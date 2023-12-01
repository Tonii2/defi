using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace definitivo
{
    public partial class Comprobar : Form
    {
        private static string connectionString = @"Data Source =LAPTOP-RHMTR2G9\SQLEXPRESS;Initial Catalog=pou;Integrated Security=True;TrustServerCertificate=True";
        public Comprobar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckCredentials(string contraseña)
        {
            // Crear la conexión SQL.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el comando SQL.
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Contraseña = @Contraseña", connection))
                {
                    // Agregar los parámetros al comando SQL.

                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    // Abrir la conexión y ejecutar el comando.
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();

                    // Si userCount es 1, entonces las credenciales son correctas.
                    return userCount == 1;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string contraseña = txtContra1.Text;
            if (CheckCredentials(contraseña))
            {

                // Aquí puedes abrir la siguiente ventana de tu aplicación.
                // Aquí puedes abrir la siguiente ventana de tu aplicación.url, href, direct string link=    que sea bool 1 act 0 inact nueva tabla   verifica si es 0 o 1  lo muestra si lo es
                Administracion Administracion = new Administracion();
                Administracion.Show();//abriendo el formulario principal
                Hide();//esto sirve para ocultar el formulario de login
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.");
            }
        }
    }
}
