using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_GQP
{
    public class Administrador
    {
        public int idRol { get; set; } //1 para el administrador, 2 para vendedor, 3 para producción
        private string usuario { get; set; }
        private string contrasena { get; set; }


        public Administrador(int idRol, string usuario, string contrasena)
        {
            this.idRol = idRol;
            this.usuario = usuario;
            this.contrasena = contrasena;
        }

        public bool autentificacion (string nombre, string contraseña)
        {
            return usuario == nombre && contrasena == contraseña;
        }
    }
}
