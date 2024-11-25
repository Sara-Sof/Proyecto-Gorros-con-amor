using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_GQP
{
    public class Administrador
    {

        public int idRol { get; set; } 
        private string usuario { get; set; }
        private string contrasena { get; set; }

        private bool seguirEjecutando = true;
        private List<Personal> personal_List;


        public Administrador(int idRol, string usuario, string contrasena)
        {
            this.idRol = idRol;
            this.usuario = usuario;
            this.contrasena = contrasena;

            personal_List = new List<Personal>();


        }

        public int autentificacion(string nombre, string contraseña)
        {
            
            if (usuario == nombre) {
                if (contrasena == contraseña)
                {
                    return 1; // Acceso permitido
                }
                else
                {
                    MessageBox.Show("Acceso denegado. Contraseña incorrecta.");
                    return 0; // 0 para el acceso denegado
                }

            }
            else {
                foreach (Personal personal in personal_List)
                {
                    if (personal.usuario == nombre)
                    {
                        if (personal.contrasena == contrasena)
                        {
                            if(personal.idRol == 2)
                            {
                                return 2;

                            }else
                            {
                                return 3;

                            }

                            break;
                        }
              

                    } 

                }
            }       
                return 0;  


        }

        public static int agregarVendedor(Vendedor vendedor)
        {
            int retorna = 0;
            Conexion conexion = Conexion.ObtenerInstancia();

            using (var conexionDB = conexion.AbrirConexion())
            {
                
                string query = "INSERT INTO vendedores (nombre_completo, cedula, telefono, direccion, usuario, contrasena, rol_id) " +
                               "VALUES (@NombreCompleto, @Cedula, @Telefono, @Direccion, @Usuario,@Contrasena, @RolId)";

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
                               "VALUES (@NombreCompleto, @Cedula, @Telefono, @Direccion, @Usuario, @Contrasena, @RolId)";

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

        public void IniciarHiloRevisarBD()
        {
            Thread hiloRevisar = new Thread(() =>
            {
                while (seguirEjecutando)
                {
                    // Llama al método registro() para actualizar la lista
                    List<Personal> nuevaLista = registro();
                    personal_List = nuevaLista;

                    Console.WriteLine("Base de datos revisada. Total registros: " + personal_List.Count);

                    // Espera 5 segundos antes de la siguiente revisión
                    Thread.Sleep(5000);
                }
            });

            hiloRevisar.IsBackground = true; // Para que no bloquee el cierre del programa
            hiloRevisar.Start();
        }

        public void DetenerHilo()
        {
            seguirEjecutando = false; // Detener el bucle en el hilo
        }

        public List<Personal> registro()
        {
            Conexion conexion = Conexion.ObtenerInstancia();
            personal_List.Clear();

            try
            { 
                using (var conexionDB = conexion.AbrirConexion())
                {
                    string queryVendores = "SELECT * FROM vendedores";

                    using (MySqlCommand command = new MySqlCommand(queryVendores, conexionDB))
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

                    string queryProduccion = "SELECT * FROM usuarios_produccion";

                    using (MySqlCommand commandP = new MySqlCommand(queryProduccion, conexionDB)) //Agregamos los datos de la tabla "usuarios_produccion"
                    {
                        using (MySqlDataReader reader = commandP.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Personal personalProduccion = new Personal(
                                reader.GetInt32(7),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(5),
                                reader.GetString(6),
                                reader.GetString(4),
                                reader.GetString(3)
                                );

                                personal_List.Add(personalProduccion);

                            }
                        }
                    }
                    ImprimirListaEnConsola();
                    conexion.CerrarConexion(conexionDB);

                }
                Console.WriteLine("éxitooooooo");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar registro 💀", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            return personal_List;
        
        }
        public void ImprimirListaEnConsola()
        {
            foreach (Personal personal in personal_List)
            {
                // Imprime las propiedades del objeto Personal
                Console.WriteLine($"Nombre: {personal.nombre}, Usuario: {personal.usuario}, Contraseña: {personal.contrasena}");
            }
        }



    }
}


