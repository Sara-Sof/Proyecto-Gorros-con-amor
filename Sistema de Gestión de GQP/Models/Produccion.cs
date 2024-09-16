using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_GQP
{
    internal class Produccion
    {
        public int idRol { get; set; } //1 para el administrador, 2 para vendedor, 3 para producción
        private string usuario { get; set; }
        private string contrasena { get; set; }
        private string correo { get; set; }
        private string celular { get; set; }

        public Produccion(int idRol, string usuario, string contrasena, string correo, string celular)
        {
            this.idRol = idRol;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.correo = correo;
            this.celular = celular;
        }

    }
}
