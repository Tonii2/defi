using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definitivo
{
    public class Persona
    {
        public int ID { get; set; }
        public string usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string Correo { get; set; }
        public string Tipo_usuario { get; set; }

        public Persona(int iD, string usuario, string contraseña, string nombre, string ap_paterno, string ap_materno, string correo, string tipo_usuario)
        {
            ID = iD;
            this.usuario = usuario;
            Contraseña = contraseña;
            Nombre = nombre;
            this.ap_paterno = ap_paterno;
            this.ap_materno = ap_materno;
            Correo = correo;
            Tipo_usuario = tipo_usuario;
        }

        public Persona()
        {
        }
    }
}
