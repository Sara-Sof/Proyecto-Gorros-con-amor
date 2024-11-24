using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_GQP
{
    public class Vendedor : Personal
    {
        
        public Vendedor(int idRol, string nombre, string cedula, string usuario, string contrasena, string direccion, string celular)
            : base(idRol, nombre, cedula, usuario, contrasena, direccion, celular) // Llama al constructor base
        {
            
        }
    }
}
