using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definitivo
{
    public class RegVehiculo
    {
        public int Remision { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Fecha { get; set; }
        public string Lugar { get; set; }
        public string Descripcion { get; set; }
        public int Total { get; set; }

        public RegVehiculo(int remision, string placa, string modelo, string marca, string color, string fecha,string lugar, string descripcion, int total)
        {
            Remision = remision;
            Placa = placa;
            Modelo = modelo;
            Marca = marca;
            Color = color;
            Fecha = fecha;
            Lugar = lugar;
            Descripcion = descripcion;
            Total = total;

        }
        public RegVehiculo()
        {

        }
    }
}
