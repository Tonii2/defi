using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace definitivo
{
    public class RegVehiculoDal
    {
        public static int Agregarmulta(RegVehiculo multa)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "insert into multa(Placa, Modelo, Marca, Color, Fecha, Lugar, Descripcion, Total) values('" + multa.Placa + "' , '" + multa.Modelo + "' , '" + multa.Marca + "' , '" + multa.Color + "' , '" + multa.Fecha + "' , '" + multa.Lugar + "' , '" + multa.Descripcion + "' , " + multa.Total + ")";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<RegVehiculo> PresentarRegVehiculo()
        {
            List<RegVehiculo> Lista = new List<RegVehiculo>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "select * from multa";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    RegVehiculo multa = new RegVehiculo();
                    multa.Remision = reader.GetInt32(0);
                    multa.Placa = reader.GetString(1);
                    multa.Modelo = reader.GetString(2);
                    multa.Marca = reader.GetString(3);
                    multa.Color = reader.GetString(4);
                    multa.Fecha = reader.GetString(5);
                    multa.Lugar = reader.GetString(6);
                    multa.Descripcion = reader.GetString(7);
                    multa.Total = reader.GetInt32(8);
                    Lista.Add(multa);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static int ModificarVehiculo(RegVehiculo multa)
        {
            int result = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "update multa set Placa= '" + multa.Placa + "' , Modelo='" + multa.Modelo + "' , Marca='" + multa.Marca + "' , Color='" + multa.Color + "' , Fecha='" + multa.Fecha + "' , Lugar='" + multa.Lugar + "' , Descripcion='" + multa.Descripcion + "' , Total="+multa.Total+" , where Remision=" + multa.Remision + " ";
                SqlCommand comando = new SqlCommand(query, conexion);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }

        public static int EliminarVehiculo(int Remision)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "delete from multa where Remision= " + Remision + "";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();

            }

            return retorna;
        }
    }
}
