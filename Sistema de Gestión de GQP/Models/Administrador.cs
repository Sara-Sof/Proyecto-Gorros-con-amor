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

        public int idRol { get; set; } 
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
                
                string query = "INSERT INTO vendedores (nombre_completo, cedula, telefono, direccion, usuario, contrasena, rol_id) " +
                               "VALUES (@NombreCompleto, @Cedula, @Telefono, @Direccion, @Usuario, SHA2(@Contrasena, 256), @RolId)";

                using (MySqlCommand command = new MySqlCommand(query, conexionDB))
                {
                    
                    command.Parameters.AddWithValue("@NombreCompleto", vendedor.nombre);
                    command.Parameters.AddWithValue("@Cedula", vendedor.cedula);
                    command.Parameters.AddWithValue("@Telefono", vendedor.celular);
                    command.Parameters.AddWithValue("@Direccion", vendedor.direccion);
                    command.Parameters.AddWithValue("@Usuario", vendedor.usuario);
                    command.Parameters.AddWithValue("@Contrasena", vendedor.contrasena);
                    command.Parameters.AddWithValue("@RolId", vendedor.idRol);

                   
                    retorna = command.ExecuteNonQuery();

                    
                    if (retorna > 0)
                    {
                        MessageBox.Show("Usuario registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    } else {
                        MessageBox.Show("Error al crear el usuario. 💀", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }

            return retorna;
        }

    
        public static int agregarProduccion(Produccion produccion)
        {
            int retorna = 0;
            Conexion conexion = Conexion.ObtenerInstancia();

            using (var conexionDB = conexion.AbrirConexion())
            {
                
                string query = "INSERT INTO usuarios_produccion (nombre_completo, cedula, telefono, direccion, usuario, contrasena, rol_id) " +
                               "VALUES (@NombreCompleto, @Cedula, @Telefono, @Direccion, @Usuario, SHA2(@Contrasena, 256), @RolId)";

                using (MySqlCommand command = new MySqlCommand(query, conexionDB))
                {
                    
                    command.Parameters.AddWithValue("@NombreCompleto", produccion.nombre);
                    command.Parameters.AddWithValue("@Cedula", produccion.cedula);
                    command.Parameters.AddWithValue("@Telefono", produccion.celular);
                    command.Parameters.AddWithValue("@Direccion", produccion.direccion);
                    command.Parameters.AddWithValue("@Usuario", produccion.usuario);
                    command.Parameters.AddWithValue("@Contrasena", produccion.contrasena);
                    command.Parameters.AddWithValue("@RolId", produccion.idRol);

                    
                    retorna = command.ExecuteNonQuery();

                    
                    if (retorna > 0)
                    {
                        MessageBox.Show("Usuario de producción registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    } else
                    {
                        MessageBox.Show("Error al crear el usuario. 💀", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            return retorna;
        }

        public static List<Personal> registro()
        {
            List<Personal> personal_List = new List<Personal>();
            Conexion conexion = Conexion.ObtenerInstancia();

            try{ 
                using (var conexionDB = conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM vendedores";

                    using (MySqlCommand command = new MySqlCommand(query, conexionDB))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Personal personal = new Personal(
                                reader.GetInt32(7),       
                                reader.GetString(1),      
                                reader.GetString(2),       
                                reader.GetString(5),       
                                reader.GetString(6),     
                                reader.GetString(4),
                                reader.GetString(3)
                                );

                                personal_List.Add(personal);
                            }
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar registro 💀", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            return personal_List;
        
        }

    }
}


