using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_GQP
{
    public class Produccion : Personal 
    {
        
        
        public Produccion(int idRol, string nombre, string cedula, string usuario, string contrasena, string direccion, string celular)
            : base(idRol, nombre, cedula, usuario, contrasena, direccion, celular) // Llama al constructor base
        {
            
        }

        public override string ToString()
        {
            return $"ID Rol: {idRol}\n" +
                   $"Nombre: {nombre}\n" +
                   $"Cédula: {cedula}\n" +
                   $"Usuario: {usuario}\n" +
                   $"Contraseña: {contrasena}\n" +
                   $"Dirección: {direccion}\n" +
                   $"Celular: {celular}";
        }

    }
}
