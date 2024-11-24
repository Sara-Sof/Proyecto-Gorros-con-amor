using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_GQP
{
    public class Personal
    {
        public int idRol { get; set; } //1 para el administrador, 2 para vendedor, 3 para producción
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string direccion { get; set; }
        public string celular { get; set; }

        public Personal (int idRol, string nombre, string cedula, string usuario, string contrasena, string direccion, string celular){

            this.idRol = idRol;
            this.nombre = nombre;
            this.cedula = cedula;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.direccion = direccion;
            this.celular = celular;
        }
    }
}
