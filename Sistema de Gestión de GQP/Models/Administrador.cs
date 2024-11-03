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

        public bool autentificacion (string nombre, string contraseña)
        {
            return usuario == nombre && contrasena == contraseña;
        }

        public static int agregarVendedor(Vendedor vendedor)
        {
            int retorna = 0;

            Conexion conexion = Conexion.ObtenerInstancia();


            using (conexion.AbrirConexion())
            {
                string query = "INSERT INTO vendedores(nombre_completo, cedula, telefono, direccion, usuario, contraseña, rol_id) " +
                                "VALUES (@NombreCompleto, @Cedula, @Telefono, @Direccion, @Usuario, SHA2(@Contrasena, 256), @RolId)";

                MySqlCommand command = new MySqlCommand(query, conexion.AbrirConexion());


                command.Parameters.AddWithValue("@NombreCompleto", vendedor.nombre); // Asegúrate de tener un getter para el nombre
                command.Parameters.AddWithValue("@Cedula", vendedor.cedula); // Asegúrate de tener un getter para la cédula
                command.Parameters.AddWithValue("@Telefono", vendedor.celular); // Asegúrate de tener un getter para el celular
                command.Parameters.AddWithValue("@Direccion", vendedor.direccion); // Asegúrate de tener un getter para la dirección
                command.Parameters.AddWithValue("@Usuario", vendedor.usuario); // Asegúrate de tener un getter para el usuario
                command.Parameters.AddWithValue("@Contrasena", vendedor.contrasena); // Asegúrate de tener un getter para la contraseña
                command.Parameters.AddWithValue("@RolId", vendedor.idRol); // Asegúrate de tener un getter para el rol


                retorna = command.ExecuteNonQuery();

            }
            return retorna;
        }

        public static int agregarProduccion(Produccion produccion)
        {
            int retorna = 0;

            Conexion conexion = Conexion.ObtenerInstancia();


            using (conexion.AbrirConexion())
            {
                string query = "INSERT INTO vendedores(nombre_completo, cedula, telefono, direccion, usuario, contraseña, rol_id) " +
                                "VALUES (@NombreCompleto, @Cedula, @Telefono, @Direccion, @Usuario, SHA2(@Contrasena, 256), @RolId)";

                MySqlCommand command = new MySqlCommand(query, conexion.AbrirConexion());


                command.Parameters.AddWithValue("@NombreCompleto", produccion.nombre); // Asegúrate de tener un getter para el nombre
                command.Parameters.AddWithValue("@Cedula", produccion.cedula); // Asegúrate de tener un getter para la cédula
                command.Parameters.AddWithValue("@Telefono", produccion.celular); // Asegúrate de tener un getter para el celular
                command.Parameters.AddWithValue("@Direccion", produccion.direccion); // Asegúrate de tener un getter para la dirección
                command.Parameters.AddWithValue("@Usuario", produccion.usuario); // Asegúrate de tener un getter para el usuario
                command.Parameters.AddWithValue("@Contrasena", produccion.contrasena); // Asegúrate de tener un getter para la contraseña
                command.Parameters.AddWithValue("@RolId", produccion.idRol); // Asegúrate de tener un getter para el rol


                retorna = command.ExecuteNonQuery();
                if (retorna > 0)
                {
                    MessageBox.Show("Usuario registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            return retorna;
        }

    }


}
