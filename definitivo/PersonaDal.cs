using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace definitivo
{
    public class PersonaDal
    {
        public static int AgregarPersonal(Persona usuarios)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "insert into usuarios(usuario, Contraseña, Nombre, ap_paterno, ap_materno, Correo, Tipo_usuario) values('" + usuarios.usuario + "' , '" + usuarios.Contraseña + "' , '" + usuarios.Nombre + "' , '" + usuarios.ap_paterno + "' , '" + usuarios.ap_materno + "' , '" + usuarios.Correo + "' , '" + usuarios.Tipo_usuario + "')";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();

            }

            return retorna;
        }

        public static List<Persona> PresentarRegistro()
        {
            List<Persona> Lista = new List<Persona>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from usuarios";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Persona usuarios = new Persona();
                    usuarios.ID = reader.GetInt32(0);
                    usuarios.usuario = reader.GetString(1);
                    usuarios.Contraseña = reader.GetString(2);
                    usuarios.Nombre = reader.GetString(3);
                    usuarios.ap_paterno = reader.GetString(4);
                    usuarios.ap_materno = reader.GetString(5);
                    usuarios.Correo = reader.GetString(6);
                    usuarios.Tipo_usuario = reader.GetString(7);
                    Lista.Add(usuarios);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static int ModificarPersona(Persona usuarios)
        {
            int result = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "update usuarios set usuarios= '" + usuarios.usuario + "' , Contraseña='" + usuarios.Contraseña + "' , Nombre='" + usuarios.Nombre + "' , ap_paterno='" + usuarios.ap_paterno + "' , ap_materno='" + usuarios.ap_materno + "' , Correo='" + usuarios.Correo + "' , Tipo_usuario='" + usuarios.Tipo_usuario + "' where ID=" + usuarios.ID + " ";
                SqlCommand comando = new SqlCommand(query, conexion);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }

        public static int EliminarPersonal(int ID)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "delete from usuarios where ID= " + ID + "";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();

            }

            return retorna;
        }
    }
}
