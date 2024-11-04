using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool autentificacion(string nombre, string contraseña)
        {
            return usuario == nombre && contrasena == contraseña;
        }

        public static int agregarVendedor(Vendedor vendedor)
        {
            int retorna = 0;
            Conexion conexion = Conexion.ObtenerInstancia();

            using (var conexionDB = conexion.AbrirConexion())
            {
                // Consulta SQL para insertar un nuevo vendedor
                string query = "INSERT INTO vendedores (nombre_completo, cedula, telefono, direccion, usuario, contrasena, rol_id) " +
                               "VALUES (@NombreCompleto, @Cedula, @Telefono, @Direccion, @Usuario, SHA2(@Contrasena, 256), @RolId)";

                using (MySqlCommand command = new MySqlCommand(query, conexionDB))
                {
                    // Configurar los parámetros de la consulta
                    command.Parameters.AddWithValue("@NombreCompleto", vendedor.nombre);
                    command.Parameters.AddWithValue("@Cedula", vendedor.cedula);
                    command.Parameters.AddWithValue("@Telefono", vendedor.celular);
                    command.Parameters.AddWithValue("@Direccion", vendedor.direccion);
                    command.Parameters.AddWithValue("@Usuario", vendedor.usuario);
                    command.Parameters.AddWithValue("@Contrasena", vendedor.contrasena);
                    command.Parameters.AddWithValue("@RolId", vendedor.idRol);

                    // Ejecutar la consulta e insertar el registro
                    retorna = command.ExecuteNonQuery();

                    // Confirmación de registro exitoso
                    if (retorna > 0)
                    {
                        MessageBox.Show("Usuario registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            return retorna;
        }

        // Método para agregar un nuevo usuario de producción
        public static int agregarProduccion(Produccion produccion)
        {
            int retorna = 0;
            Conexion conexion = Conexion.ObtenerInstancia();

            using (var conexionDB = conexion.AbrirConexion())
            {
                // Consulta SQL para insertar un nuevo usuario de producción
                string query = "INSERT INTO usuarios_produccion (nombre_completo, cedula, telefono, direccion, usuario, contrasena, rol_id) " +
                               "VALUES (@NombreCompleto, @Cedula, @Telefono, @Direccion, @Usuario, SHA2(@Contrasena, 256), @RolId)";

                using (MySqlCommand command = new MySqlCommand(query, conexionDB))
                {
                    // Configurar los parámetros de la consulta
                    command.Parameters.AddWithValue("@NombreCompleto", produccion.nombre);
                    command.Parameters.AddWithValue("@Cedula", produccion.cedula);
                    command.Parameters.AddWithValue("@Telefono", produccion.celular);
                    command.Parameters.AddWithValue("@Direccion", produccion.direccion);
                    command.Parameters.AddWithValue("@Usuario", produccion.usuario);
                    command.Parameters.AddWithValue("@Contrasena", produccion.contrasena);
                    command.Parameters.AddWithValue("@RolId", produccion.idRol);

                    // Ejecutar la consulta e insertar el registro
                    retorna = command.ExecuteNonQuery();

                    // Confirmación de registro exitoso
                    if (retorna > 0)
                    {
                        MessageBox.Show("Usuario de producción registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            return retorna;
        }
    }
}
    

